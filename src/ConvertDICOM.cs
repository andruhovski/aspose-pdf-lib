using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Text;
using Microsoft.JavaScript.NodeApi;
using System.IO;

namespace AsposePdfLib
{
    [JSExport]
    public static class ConvertDICOM
    {
        public static void ToPDF(string inputFile, string outputFile)
        {
            // load PDFA with an instance of Document
            Document pdfDocument = new Document();

            // Add a page to pages collection of document
            Page page = pdfDocument.Pages.Add();

            Image image = new Image
            {
                FileType = ImageFileType.Dicom,
                File = inputFile
            };
            page.Paragraphs.Add(image);
            // Save output as PDF format
            pdfDocument.Save(outputFile);                                
        }
    }
}