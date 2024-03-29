﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommonArguments.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.Cmd
{
    using System;
    using System.CommandLine;
    using System.IO;

    // internal static class CommonArguments
    // {
    //    public static Argument<FileInfo> CredentialsFile
    //    {
    //        get
    //        {
    //            return new Argument<FileInfo>(r => GetCredentialFile(), true)
    //                       {
    //                           Arity = ArgumentArity.Zero,
    //                           Description = "The credentials file",
    //                           Name = "credentialsFile"
    //                       };
    //        }
    //    }

    // public static Argument<FileInfo> SessionFile
    //    {
    //        get
    //        {
    //            return new Argument<FileInfo>(r => GetSessionFile(), true)
    //                       {
    //                           Arity = ArgumentArity.Zero, Description = "The session file", Name = "sessionFile"
    //                       };
    //        }
    //    }

    // private static string GetAppDataDirectoryPath()
    //    {
    //        var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    //        var appDataPath = Path.Combine(folderPath, "nauta-session");

    // if (!Directory.Exists(appDataPath))
    //        {
    //            Directory.CreateDirectory(appDataPath);
    //        }

    // return appDataPath;
    //    }

    // private static FileInfo GetCredentialFile()
    //    {
    //        return new FileInfo(Path.Combine(GetAppDataDirectoryPath(), "credentials.json"));
    //    }

    // private static FileInfo GetSessionFile()
    //    {
    //        return new FileInfo(Path.Combine(GetAppDataDirectoryPath(), "session.json"));
    //    }
    // }
    public class FilesHelper
    {
        public static FileInfo GetCredentialFile(string alias)
        {
            if (!string.IsNullOrWhiteSpace(alias))
            {
                return new FileInfo(Path.Combine(GetAppDataDirectoryPath(), $"credentials.{alias}.json"));
            }

            return new FileInfo(Path.Combine(GetAppDataDirectoryPath(), "credentials.json"));
        }

        public static FileInfo GetSessionFile()
        {
            return new FileInfo(Path.Combine(GetAppDataDirectoryPath(), "session.json"));
        }

        private static string GetAppDataDirectoryPath()
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appDataPath = Path.Combine(folderPath, "nauta-session");

            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            return appDataPath;
        }
    }
}