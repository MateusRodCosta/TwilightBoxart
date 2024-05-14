﻿using System;
using System.Threading.Tasks;
using KirovAir.Core.Extensions;
using KirovAir.Core.Utilities;

namespace TwilightBoxart.Models.Base
{
    public class LibRetroRom : Rom
    {
        /// <summary>
        /// Used for 'simple' name or sha1 mapping only.
        /// </summary>
        /// <param name="targetFile"></param>
        public override async Task DownloadBoxArt(string targetFile)
        {
            if (string.IsNullOrEmpty(NoIntroName))
            {
                await DownloadByName(targetFile);
                return;
            }

            try
            {
                // Try NoIntroName first.
                await DownloadWithRetry(NoIntroName, targetFile);
            }
            catch
            {
                if (NoIntroName == SearchName)
                {
                    throw new NoMatchException("Nothing was found! (Using sha1/filename)");
                }
                // Else try filename.
                await DownloadByName(targetFile);
            }
        }

        private async Task DownloadByName(string targetFile)
        {
            try
            {
                await DownloadWithRetry(SearchName, targetFile);
            }
            catch
            {
                throw new NoMatchException("Nothing was found! (Using sha1/filename)");
            }
        }

        private async Task DownloadWithRetry(string name, string targetFile)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NoMatchException("Invalid filename.");
            }

            try
            {
                await Download(ConsoleType, name, targetFile);
            }
            catch (Exception)
            {
                if (NoIntroConsoleType == ConsoleType.Unknown || ConsoleType == NoIntroConsoleType) throw;

                // Try again on NoIntroDb ConsoleType if found.
                await Download(NoIntroConsoleType, name, targetFile);
            }
        }

        private async Task Download(ConsoleType consoleType, string name, string targetFile)
        {
            // We can generate the LibRetro content url based on the NoIntroDb name.
            var consoleStr = consoleType.GetDescription().Replace(" ", "_");
            var url = $"https://raw.githubusercontent.com/libretro-thumbnails/{consoleStr}/master/Named_Boxarts/";

            // Found the characters: https://docs.libretro.com/guides/roms-playlists-thumbnails/
            // &*/:`<>?\|
            name = name.Replace("&", "_");
            name = name.Replace("*", "_");
            name = name.Replace("/", "_");
            name = name.Replace(":", "_");
            name = name.Replace("`", "_");
            name = name.Replace("<", "_");
            name = name.Replace(">", "_");
            name = name.Replace("?", "_");
            name = name.Replace("\\", "_");
            name = name.Replace("|", "_");

            url = FileHelper.CombineUri(url, $"{name}.png");
            await ImgDownloader.DownloadAndResize(url, targetFile);
        }
    }
}
