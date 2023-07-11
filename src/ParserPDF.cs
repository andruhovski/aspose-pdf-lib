using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;
using Microsoft.JavaScript.NodeApi;
using System.IO;

namespace AsposePdfLib
{
    [JSExport]
    public static class ParserPDF
    {
        public static void ExtractText(string inputFile, string outputFile)
        {
            // Open document
            Document document = new(inputFile);
            // Create TextAbsorber object to extract text
            TextAbsorber textAbsorber = new();
            // Accept the absorber for all the pages
            document.Pages.Accept(textAbsorber);
            // Get the extracted text
            File.WriteAllText(outputFile, textAbsorber.Text);
        }

        public static void ExtractImages(string inputFile, string outputFile)
        {
            // Open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(inputFile);

            pdfExtractor.ExtractImage();

            int count=0;

            while (pdfExtractor.HasNextImage())
                pdfExtractor.GetNextImage($"{outputFile}{count++}_out.jpg");
        }
    }
}