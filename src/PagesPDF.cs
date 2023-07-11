using Aspose.Pdf;
using Microsoft.JavaScript.NodeApi;

namespace AsposePdfNodeLib
{


    [JSExport]
    public static class PagesPDF
    {
        public static void AddEmpty(string inputFile, int index)
        {
            // Open document
            Document document = new(inputFile);

            // Insert a empty page in a PDF
            document.Pages.Insert(index);

            // Save output file
            document.Save(inputFile);
        }

        public static void DeletePage(string inputFile, int index)
        {
            // Open document
            Document document = new(inputFile);

            //// Delete a particular page
            document.Pages.Delete(index);

            // Save updated PDF
            document.Save(inputFile);
        }

        public static void CopyPage(string srcFileName, int source, string dstFileName, int destination)
        {
            // Open document
            var srcDocument = new Aspose.Pdf.Document(srcFileName);
            var dstDocument = new Aspose.Pdf.Document(dstFileName);
            var page = srcDocument.Pages[source];

            dstDocument.Pages.Add(page);
            // Save updated PDFs
            dstDocument.Save(dstFileName);
        }

        public static void MovePage(string srcFileName, int source, string dstFileName, int destination)
        {
            // Open document
            var srcDocument = new Aspose.Pdf.Document(srcFileName);
            var dstDocument = new Aspose.Pdf.Document(dstFileName);
            var page = srcDocument.Pages[source];

            dstDocument.Pages.Add(page);
            srcDocument.Pages.Delete(source);

            // Save updated PDFs
            dstDocument.Save(dstFileName);
            dstDocument.Save(srcFileName);
        }
    }
}