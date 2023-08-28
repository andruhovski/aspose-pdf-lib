using Aspose.Pdf;
using Microsoft.JavaScript.NodeApi;

namespace AsposePdfLib
{
    [JSExport]
    public static class ConvertEMF
    {
        public static void ToPDF(string inputFile, string outputFile)
        {
            // load PDFA with an instance of Document
            Document pdfDocument = new();

            // Add a page to pages collection of document
            Page page = pdfDocument.Pages.Add();

            Image image = new()
            {
                File = inputFile
            };
            page.Paragraphs.Add(image);
            // Save output as PDF format
            pdfDocument.Save(outputFile);
        }
    }
}