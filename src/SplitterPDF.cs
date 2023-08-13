using Aspose.Pdf;
using Microsoft.JavaScript.NodeApi;

namespace AsposePdfNodeLib
{
    [JSExport]
    public static class SplitterPDF
    {
        public static void EachPages(string inFile, string template)
        {
            // Load input PDF file
            Document document = new(inFile);

            // Loop through each page
            foreach (Page page in document.Pages)
            {
                // Create a new Document class object to split PDF pages
                Document splitPDF = new();

                // Add current page to the document
                splitPDF.Pages.Add(page);

                // Save current page as a seprate PDF
                splitPDF.Save(string.Format(template, page.Number));
            }
        }
    }
}