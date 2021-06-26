﻿using System;
using System.IO;

namespace MWinNet.Core
{
    public partial class CommonToolkit
    {
        public static string[] GetDllFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath, "*.dll");
            return files;
        }

        public static string[] GetConfigFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath, "*.config");
            return files;
        }

        public static DirectoryInfo[] GetEnvironmentDirectorys()
        {
            string exePath = Environment.CurrentDirectory;
            DirectoryInfo info = new DirectoryInfo(Directory.GetParent(exePath).FullName + @"\Environment");
            return info.GetDirectories();
        }

        public static string GetResourceDirectory(string imgPath)
        {
            string exePath = Environment.CurrentDirectory;
            DirectoryInfo info = new DirectoryInfo(Directory.GetParent(exePath).FullName);
            if (!imgPath.StartsWith("\\"))
            {
                return info.FullName + "\\" + imgPath;
            }
            return info.FullName + imgPath;
        }
    }
}
