using System.Runtime.CompilerServices;
using Microsoft.JavaScript.NodeApi;

namespace AsposePdfLib
{
    [JSExport]
    public static class Setup
    {
        public static void Init(string path)
        {
            Aspose.Pdf.License license = new();
            if (System.IO.File.Exists(path))
            {
                license.SetLicense(path);
            }
            else
            {
                System.Console.WriteLine();
            }
        }
    }
}
