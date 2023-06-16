using IronOcr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCExtended.DataHandling
{
    public static class OCRHandling
    {
        public static string GetTextFromImg(string imgName)
        {
            string collectedData = null;

            var Ocr = new IronTesseract();

            try
            {
                using (var Input = new OcrInput(imgName))
                {
                    // Input.Deskew();  // use if image not straight
                    // Input.DeNoise(); // use if image contains digital noise
                    var Result = Ocr.Read(Input);
                    collectedData += Result.Text;
                }

                File.Delete(imgName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("      Unable to find file!");
            }

            return collectedData;
        }
    }
}
