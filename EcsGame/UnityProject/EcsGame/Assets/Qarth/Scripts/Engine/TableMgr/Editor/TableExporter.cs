﻿

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace GameFrame.Editor
{
    public class TableExporter
    {
        public static bool IsLinuxSystem()
        {
            PlatformID platformID = System.Environment.OSVersion.Platform;

            if (platformID == PlatformID.MacOSX || platformID == PlatformID.Unix)
            {
                return true;
            }

            return false;
        }

        [MenuItem("Assets/GameFramework/Table/Build C#")]
        public static void BuildCSharpFile()
        {
            string path = ProjectPathConfig.projectToolsFolder;
            if (IsLinuxSystem())
            {
                path += ProjectPathConfig.buildCSharpLinuxShell;
            }
            else
            {
                path += ProjectPathConfig.buildCSharpWinShell;
            }

            Thread newThread = new Thread(new ThreadStart(() =>
            {
                BuildCSharpThreadStart(path);
            }));
            newThread.Start();
        }

        [MenuItem("Assets/GameFramework/Table/Build Data(txt)")]
        public static void BuildDataTxtMode()
        {
            string path = ProjectPathConfig.projectToolsFolder;
            if (IsLinuxSystem())
            {
                path += ProjectPathConfig.buildTxtDataLinuxShell;
            }
            else
            {
                path += ProjectPathConfig.buildTxtDataWinShell;
            }

            Thread newThread = new Thread(new ThreadStart(() =>
            {
                BuildCSharpThreadStart(path);
            }));
            newThread.Start();
        }

        [MenuItem("Assets/GameFramework/Table/Build Data(lrg)")]
        public static void BuildDataLrgMode()
        {
            string path = ProjectPathConfig.projectToolsFolder;
            if (IsLinuxSystem())
            {
                path += ProjectPathConfig.buildLrgDataLinuxShell;
            }
            else
            {
                path += ProjectPathConfig.buildLrgDataWinShell;
            }

            Thread newThread = new Thread(new ThreadStart(() =>
            {
                BuildCSharpThreadStart(path);
            }));
            newThread.Start();
        }

        public static void BuildCSharpThreadStart(string path)
        {
            if (IsLinuxSystem())
            {
                CommandThreadStartLinux(path);
            }
            else
            {
                CommandThreadStartWin(path);
            }

        }

        private static void CommandThreadStartLinux(string path)
        {
            Process process = new Process();
            process.StartInfo.FileName = "/bin/sh";
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.ErrorDialog = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.Arguments = path + " arg1 arg2";

            process.Start();
            string outPutstr = process.StandardOutput.ReadToEnd();
            if (!string.IsNullOrEmpty(outPutstr))
            {
                //Log.i(outPutstr);
            }

            process.WaitForExit();
            process.Close();
        }

        private static void CommandThreadStartWin(string path)
        {
            Process process = new Process();
            process.StartInfo.FileName = path;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.ErrorDialog = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();
            string outPutstr = process.StandardOutput.ReadToEnd();
            if (!string.IsNullOrEmpty(outPutstr))
            {
                //Log.i(outPutstr);
            }

            process.WaitForExit();
            process.Close();
        }
    }
}
