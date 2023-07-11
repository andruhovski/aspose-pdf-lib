using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Text;
using Microsoft.JavaScript.NodeApi;
using System.IO;

namespace AsposePdfNodeLib
{
    [JSExport]
    public static class ConvertCGM
    {
        private static Document ConvertImageFile(string inputFile)
        {
            Document document = new(inputFile, new CgmLoadOptions());
            return document;
        }
        private static void ConvertPDFtoImage(ImageDevice imageDevice, string outputFile, string ext, Document document)
        {
            for (int pageCount = 1; pageCount <= document.Pages.Count; pageCount++)
            {
                using FileStream imageStream = new($"{outputFile}{pageCount}_out.{ext}", FileMode.Create);
                // Convert a particular page and save the image to stream
                imageDevice.Process(document.Pages[pageCount], imageStream);

                // Close stream
                imageStream.Close();
            }
        }
        public static void ToBMP(string inputFile, string outputFile, int resolution)
        {
            var document = ConvertImageFile(inputFile);
            BmpDevice device = new(new Resolution(resolution));
            ConvertPDFtoImage(device, outputFile, "bmp", document);
        }

        public static void ToDOC(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, SaveFormat.Doc);
        }

        public static void ToDOCX(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, SaveFormat.DocX);
        }

        public static void ToEMF(string inputFile, string outputFile, int resolution)
        {
            var document = ConvertImageFile(inputFile);
            EmfDevice device = new(new Resolution(resolution));
            ConvertPDFtoImage(device, outputFile, "emf", document);
        }

        public static void ToEPUB(string inputFile, string outputFile)
        {
            var document = ConvertImageFile(inputFile);
            document.Save(outputFile, Aspose.Pdf.SaveFormat.Epub);
        }

        public static void ToGIF(string inputFile, string outputFile, int resolution)
        {
            var document = ConvertImageFile(inputFile);
            GifDevice device = new(new Resolution(resolution));
            ConvertPDFtoImage(device, outputFile, "gif", document);
        }

        public static void ToHTML(string inputFile, string outputFile)
        {
            // load PDF with an instance of Document
            var document = ConvertImageFile(inputFile);

            // save document in HTML format
            document.Save(outputFile, Aspose.Pdf.SaveFormat.Html);
        }

        public static void ToJPEG(string inputFile, string outputFile, int resolution, int quality)
        {
            var document = ConvertImageFile(inputFile);
            JpegDevice device = new(new Resolution(resolution), quality);
            ConvertPDFtoImage(device, outputFile, "jpeg", document);
        }

        public static void ToPDFA(string inputFile, string outputFile, string logFile)
        {
            // load PDFA with an instance of Document
            var document = ConvertImageFile(inputFile);
            document.Convert(logFile, PdfFormat.PDF_A_1A, ConvertErrorAction.None);
            // save document in PDFA format
            document.Save(outputFile);
        }

        public static void ToPNG(string inputFile, string outputFile, int resolution)
        {
            var document = ConvertImageFile(inputFile);
            PngDevice device = new(new Resolution(resolution));
            ConvertPDFtoImage(device, outputFile, "png", document);
        }

        public static void ToPPTX(string inputFile, string outputFile)
        {
            // load PDF with an instance of Document
            var document = ConvertImageFile(inputFile);

            // save document in PPTX format
            document.Save(outputFile, Aspose.Pdf.SaveFormat.Pptx);
        }

        public static void ToSVG(string inputFile, string outputFile)
        {
            // load PDF with an instance of Document
            var document = ConvertImageFile(inputFile);

            // save document in PPTX format
            document.Save(outputFile, Aspose.Pdf.SaveFormat.Svg);
        }

        public static void ToTEX(string inputFile, string outputFile)
        {
            // load PDF with an instance of Document
            var document = ConvertImageFile(inputFile);

            // save document in TEX format
            document.Save(outputFile, Aspose.Pdf.SaveFormat.TeX);
        }

        public static void ToTIFF(string inputFile, string outputFile, int resolution)
        {
            // load PDF with an instance of Document
            var document = ConvertImageFile(inputFile);

            // create an object of tiffDevice
            var renderer = new TiffDevice(new Resolution(resolution));

            // convert a particular page and save the image in TIFF format
            renderer.Process(document, outputFile);
        }

        public static void ToTXT(string inputFile, string outputFile)
        {
            // load PDF with an instance of Document
            var document = ConvertImageFile(inputFile);

            TextAbsorber ta = new();
            ta.Visit(document);

            // Save the extracted text in text file
            File.WriteAllText(outputFile, ta.Text);
        }

        public static void ToXPS(string inputFile, string outputFile)
        {
            // load PDF with an instance of Document
            var document = ConvertImageFile(inputFile);

            // save document in XPS format
            document.Save(outputFile, Aspose.Pdf.SaveFormat.Xps);
        }
    }
}