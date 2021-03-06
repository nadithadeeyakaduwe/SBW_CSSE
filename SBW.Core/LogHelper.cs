﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Core
{
    public class LogHelper
    {
        private const string ERROR_LOG_FILE_PATH = @"C:\SBW\ErrorLog.txt";

        private static FileStream file;
        public static void Log(string message)
        {
            try
            {
                if (!File.Exists(ERROR_LOG_FILE_PATH))
                {
                    file = File.Create(ERROR_LOG_FILE_PATH);
                }
                else
                {
                    file = File.Open(ERROR_LOG_FILE_PATH, FileMode.Append, FileAccess.Write);
                }
                using (StreamWriter streamWriter = new StreamWriter(file))
                {
                    Log(streamWriter, message);
                }
                file.Close();
            }
            catch { }
        }

        private static void Log(TextWriter textWriter, string message)
        {
            textWriter.Write("\r\nLog Entry : ");
            textWriter.WriteLine($" {DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} : ");
            textWriter.WriteLine("{0}", message);
            textWriter.WriteLine("-------------------------------------------------------------------------------------");
        }
    }
}
