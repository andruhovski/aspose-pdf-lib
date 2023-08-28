using System.Runtime.CompilerServices;

namespace AsposePdfLib
{
    public class Setup
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
