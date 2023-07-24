using Microsoft.JavaScript.NodeApi;

namespace AsposePdfNodeLib
{
    [JSExport]
    public static class ProtectPDF
    {
        public static void Encrypt(string inputFile, string outPutFile, string userPassword, string ownerPassword)
        {
            using var document = new Aspose.Pdf.Document(inputFile);
            var documentPrivilege = Aspose.Pdf.Facades.DocumentPrivilege.ForbidAll;
            documentPrivilege.AllowScreenReaders = true;
            document.Encrypt(userPassword, ownerPassword, documentPrivilege, Aspose.Pdf.CryptoAlgorithm.AESx128, false);
            document.Save(outPutFile);
        }
        
        public static void Decrypt(string inputFile, string outPutFile, string password)
        {
            using var document = new Aspose.Pdf.Document(inputFile,password);
            document.Decrypt();            
            document.Save(outPutFile);
        }
    }
}