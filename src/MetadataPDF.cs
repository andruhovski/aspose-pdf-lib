using Aspose.Pdf;
using Microsoft.JavaScript.NodeApi;
using System.Text.Json;

namespace AsposePdfNodeLib
{
    [JSExport]
    public static class MetadataPDF
    {
        public static string getInfo(string inputFile)
        {
            var document = new Document(inputFile);
            string jsonString = JsonSerializer.Serialize(document.Info);
            return jsonString;
        }
        public static string getAuthor(string inputFile)
        {
            var document = new Document(inputFile);
            return document.Info.Author;
        }
        public static string getCreator(string inputFile)
        {
            var document = new Document(inputFile);
            return document.Info.Creator;
        }

        public static string getModDate(string inputFile)
        {
            var document = new Document(inputFile);
            return document.Info.ModDate.ToShortDateString();
        }
    }
}