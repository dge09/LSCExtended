using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LSCExtended.DataHandling
{
    public static class WebHandling
    {
        public static string GenerateUrl(int urlLength)
        {
            string url = @"https://prnt.sc/";
            Random r = new Random();

            for (int i = 0; i < urlLength; i++)
            {

                if (r.Next(0, 1) == 1)
                {
                    url += r.Next(0, 9);
                }
                else
                {
                    url += char.ConvertFromUtf32(r.Next(97, 122));
                }

            }

            return url;
        }

        public static string GetHttpString(string url, string fileName)
        {

            string httpString = null;

            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }

            WebClient wb = new();
            wb.Headers.Add("User-Agent: Other");   //that is the simple line!
            wb.DownloadFile(url, fileName);

            using (StreamReader reader = new StreamReader(fileName))
            {
                httpString = reader.ReadLine();

                reader.Close();
            }


            return httpString;
        }

        public static string GetHttpString(string url)
        {
            WebClient wb = new();
            wb.Headers.Add("User-Agent: Other");   //that is the simple line!
            string httpString = wb.DownloadString(url);

            return httpString;
        }

        public static string GetImgUrl(string fileName, string httpString)
        {
            string imgUrl = null;
            Match tmp;

            Regex html = new Regex("<meta property=.{1,2}og:image.{1,3}content=.{1,2}(?<capture>https://[a-zA-Z0-9\\-:/\\._]+).{1,2}/>");

            tmp = html.Match(httpString);

            imgUrl = tmp.Groups["capture"].ToString();

            return imgUrl;
        }

        public static string GetImgUrl(string httpString)
        {
            string imgUrl = null;
            Match tmp;

            Regex html = new Regex("<meta property=.{1,2}og:image.{1,3}content=.{1,2}(?<capture>https://[a-zA-Z0-9\\-:/\\._]+).{1,2}/>");

            tmp = html.Match(httpString);

            imgUrl = tmp.Groups["capture"].ToString();

            return imgUrl;
        }


        public static bool CheckWebsiteExistance(string imgUrl)
        {
            WebClient imgWebClient = new();

            try
            {
                Stream stream = imgWebClient.OpenRead(imgUrl);
            }
            catch (WebException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public static string DownloadImg(string imgUrl, string basePath)
        {
            string imgName = basePath + "\\LSimg.png";

            using (WebClient client = new())
            {
                try
                {
                    client.DownloadFile(new Uri(imgUrl), imgName);
                }
                catch (WebException)
                {
                    // alle Console.WriteLine loswerden,
                    // ("     404 no real img detected");
                    imgName = "404";
                }
            }

            return imgName;
        }
    }
}
