using System;
using System.IO;

namespace Store_1
{
    
    public static class Logger
    {
        static string LogFilePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\\";

        public static string LogText = "";

        public static void LogFileCreate()
        {
            LogFilePath += "StoreLogs-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".log";
            FileInfo LogFileInfo = new FileInfo(LogFilePath);
            if (!LogFileInfo.Exists)
            {
                LogFileInfo.Create();
            }
        }

        public static void LogWrite(string OpLogText)
        {
            string LogFileStream = LogFilePath;
            using (StreamWriter sw = new StreamWriter(LogFilePath, true))
            {
                sw.Write("\r\n" + DateTime.Now + " " + OpLogText);
            }
            LogText = "";
        }
    }
}
