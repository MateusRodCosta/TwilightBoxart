using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using KirovAir.Core.Utilities;
using SixLabors.ImageSharp;
using TwilightBoxart.Data;
using TwilightBoxart.Helpers;
using TwilightBoxart.Models.Base;
using System.Linq;
using System.Collections.Generic;

namespace TwilightBoxart
{
    public class BoxartCrawler
    {
        private readonly IProgress<string> _progress;
        private static RomDatabase _romDb;

        public BoxartCrawler(IProgress<string> progress = null)
        {
            // Disable all SSL cert pinning for now as users have reported problems with github.
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            _progress = progress;
            _romDb = new RomDatabase(Path.Combine(FileHelper.GetCurrentDirectory(), "NoIntro.db"));
        }

        public void InitializeDb()
        {
            _romDb.Initialize(_progress);
        }

        public async Task DownloadArt(string romsPath, string boxArtPath, int defaultWidth, int defaultHeight, bool useAspect = false)
        {
            _progress?.Report($"Scanning {romsPath}..");

            try
            {
                if (!Directory.Exists(romsPath))
                {
                    _progress?.Report($"Could not open {romsPath}.");
                    return;
                }

                // Skip system directories that might cause permission issues
                var skipDirs = new[] { ".Spotlight-V100", ".Trashes", ".fseventsd", ".TemporaryItems" };

                // Use a safer approach to enumerate files
                var files = new List<string>();
                try
                {
                    // Start with just the root directory
                    var directoriesToScan = new Queue<string>();
                    directoriesToScan.Enqueue(romsPath);

                    // Process directories one by one, avoiding system directories
                    while (directoriesToScan.Count > 0)
                    {
                        var currentDir = directoriesToScan.Dequeue();
                        
                        // Skip if this is a system directory
                        if (skipDirs.Any(skipDir => currentDir.Contains(Path.DirectorySeparatorChar + skipDir + Path.DirectorySeparatorChar)))
                        {
                            continue;
                        }

                        try
                        {
                            // Get files from current directory
                            files.AddRange(Directory.GetFiles(currentDir, "*.*"));

                            // Get subdirectories and add them to the queue
                            foreach (var subDir in Directory.GetDirectories(currentDir))
                            {
                                // Only add if it's not a system directory
                                if (!skipDirs.Any(skipDir => subDir.EndsWith(Path.DirectorySeparatorChar + skipDir)))
                                {
                                    directoriesToScan.Enqueue(subDir);
                                }
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            // Skip directories we can't access
                            continue;
                        }
                        catch (IOException)
                        {
                            // Skip directories that cause I/O errors
                            continue;
                        }
                    }
                }
                catch (Exception e)
                {
                    _progress?.Report($"Error scanning directories: {e.Message}");
                    return;
                }

                foreach (var romFile in files)
                {
                    try
                    {
                        var ext = Path.GetExtension(romFile).ToLower();
                        if (!BoxartConfig.ExtensionMapping.ContainsKey(ext))
                            continue;

                        var targetArtFile = Path.Combine(boxArtPath, Path.GetFileName(romFile) + ".png");
                        if (File.Exists(targetArtFile))
                        {
                            // We already have it.
                            _progress?.Report($"Skipping {Path.GetFileName(romFile)}.. (We already have it)");
                            continue;
                        }

                        try
                        {
                            _progress?.Report($"Searching art for {Path.GetFileName(romFile)}.. ");

                            var rom = Rom.FromFile(romFile);
                            _romDb.AddMetadata(rom);

                            var downloader = new ImgDownloader(defaultWidth, defaultHeight);
                            if (useAspect && BoxartConfig.AspectRatioMapping.TryGetValue(rom.ConsoleType, out var size))
                            {
                                if (rom.ConsoleType == ConsoleType.SuperNintendoEntertainmentSystem)
                                {
                                    if ((rom.NoIntroName?.ToLower().Contains("(japan)", StringComparison.OrdinalIgnoreCase) ?? false) ||
                                        (rom.SearchName?.ToLower().Contains("(japan)", StringComparison.OrdinalIgnoreCase) ?? false))
                                    {
                                        size = new Size(84, 115);
                                    }
                                }
                                downloader.SetSizeAdjustedToAspectRatio(size);
                            }

                            rom.SetDownloader(downloader);

                            Directory.CreateDirectory(Path.GetDirectoryName(targetArtFile));
                            await rom.DownloadBoxArt(targetArtFile);
                            _progress?.Report("Got it!");
                        }
                        catch (NoMatchException ex)
                        {
                            _progress?.Report(ex.Message);
                        }
                        catch (Exception e)
                        {
                            _progress?.Report("Something bad happened: " + e.Message);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Skip files we don't have permission to access
                        continue;
                    }
                    catch (IOException)
                    {
                        // Skip files that cause I/O errors
                        continue;
                    }
                }

                _progress?.Report("Finished scan.");
            }
            catch (Exception e)
            {
                _progress?.Report("Unhandled exception occurred! " + e);
            }
        }
    }
}

