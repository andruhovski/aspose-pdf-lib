using Aspose.Pdf;
using Microsoft.JavaScript.NodeApi;

namespace AsposePdfLib
{
    [JSExport]
    public static class ConvertImage
    {
        private static Document ConvertImageFile(string inputFile)
        {
            Document document = new();
            document.Pages.Add();
            Image image = new()
            {
                File = inputFile
            };
            document.Pages[1].Paragraphs.Add(image);
            return document;
        }

        public static void ToPDF(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile);
        }

        public static void ToXPS(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, SaveFormat.Xps);
        }

        public static void ToDOCX(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, SaveFormat.DocX);
        }

        public static void ToPPTX(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, SaveFormat.Pptx);
        }
        public static void ToTEX(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, SaveFormat.TeX);
        }
        public static void ToEPUB(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, SaveFormat.Epub);
        }

    }
}

