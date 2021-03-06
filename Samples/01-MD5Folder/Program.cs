﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace ActorsLifeForMe.MD5Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready to start.");
            Console.ReadLine();

            ProcessFolder(@"E:\Disks\.NET Core SDK June 2016 (RC2 Preview 1)");

            Console.WriteLine("Completed.");
            Console.ReadLine();
        }

        private static void ProcessFolder(string folder)
        {
            var files = System.IO.Directory.GetFiles(folder);
            foreach (var filepath in files)
            {
                Console.WriteLine("Begin {0} ", MaxFilename(filepath, 30));
                Console.WriteLine("End {0} : {1}", MaxFilename(filepath, 30), MD5FromFile(filepath));
                Console.WriteLine();
            }
        }

        private static string MaxFilename(string filepath, int maxLength)
        {
            var filename = Path.GetFileName(filepath);
            if (filename.Length > maxLength) { filename = filename.Substring(0, maxLength); }
            return filename;
        }

        private static string MD5FromFile(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }
    }
}