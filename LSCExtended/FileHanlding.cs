using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC
{
    public static class FileHanlding
    {
        public static string CheckRequiredBasePath()
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            basePath += "\\LSC";

            if (!(Directory.Exists(basePath)))
            {
                Directory.CreateDirectory(basePath);
            }

            return basePath;
        }

        public static string CheckStorageFileExistance(string basePath)
        {
            string storageFile = basePath + "\\LSColletion.txt";

            if (!(File.Exists(storageFile)))
            {
                using (StreamWriter sw = File.CreateText(storageFile)) ;
            }

            return storageFile;
        }

        public static string CheckHTTPFileExistance(string basePath)
        {
            string httpfile = basePath + "\\HTTPCode.txt";

            if (!(File.Exists(httpfile)))
            {
                using (StreamWriter sw = File.CreateText(httpfile)) ;
            }

            return httpfile;
        }

        public static string CheckSummaryFileExistance(string basePath)
        {
            string summaryfile = basePath + "\\SummaryFile.txt";

            if (!(File.Exists(summaryfile)))
            {
                using (StreamWriter sw = File.CreateText(summaryfile));
            }

            return summaryfile;
        }

        public static string ValidateReadData(string haystack)
        {
            string[] needles = { "Pw", "Password", "Passwort", "пароль", "Username", "User-Name", "EMail", "E-Mail", "E Mail", "email", "license", "key", "€", "$", "¥", "₽" };

            if (haystack != null)
            {
                for (int i = 0; i < needles.Length; i++)
                {
                    if (haystack.Contains(needles[i]))
                    {
                        return needles[i];
                    }
                }
            }
            return null;
        }

        public static void WriteDataToTxt(string collectedData, string collectionFilePath, string category, string url, string imgUrl)
        {
            long fileSizeRefference = new System.IO.FileInfo(collectionFilePath).Length;

            using StreamWriter writer = new StreamWriter(collectionFilePath, true);
            writer.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            writer.WriteLine(category + " found in:        " + url);
            writer.WriteLine(collectedData);
            writer.Close();


            long fileSize = new System.IO.FileInfo(collectionFilePath).Length;

            if (fileSize > fileSizeRefference)
            {
                Console.WriteLine("Data saved.");
            }

        }

        public static void WriteSummaryToTxt(List <string> linksWithData, string collectionFilePath, string category)
        {
            using StreamWriter writer = new StreamWriter(collectionFilePath, true);
            
            foreach (var item in linksWithData)
            {
                writer.WriteLine(item + "           " + category);
            }
        }
    }
}
