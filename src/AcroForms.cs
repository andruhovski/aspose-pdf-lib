using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Forms;
using Microsoft.JavaScript.NodeApi;
using System.Collections.Generic;
using System.Linq;

namespace AsposePdfLib
{
    [JSExport]
    public static class AcroFormsPDF
    {
        public static void CreateTextBoxField(string infile, string outfile, JSObject field)
        {
            // Open document
            Document document = new(infile);
            var index = (int)field["pageIndex"];
            var llx = (int)field["llx"];
            var lly = (int)field["lly"];
            var urx = (int)field["urx"];
            var ury = (int)field["ury"];

            // Create a field
            TextBoxField textBoxField = new(document.Pages[index], new Aspose.Pdf.Rectangle(llx, lly, urx, ury))
            {
                PartialName = (string)field["partialname"],
                Value = (string)field["value"]
            };

            // Create decorations (like Border)
            Border border = new(textBoxField)
            {
                Width = (int)field["border_width"],
                Dash = new Dash(1, 1)
            };
            textBoxField.Border = border;

            textBoxField.Color = Aspose.Pdf.Color.FromRgb(128, 128, 128);

            // Add field to the document
            document.Form.Add(textBoxField, index);

            // Save modified PDF
            document.Save(infile);
        }

        public static IDictionary<string,string> Extract(string infile)
        {
            Document document = new(infile);
            IDictionary<string,string> formData = new Dictionary<string, string>();
            foreach (Field formField in document.Form.Cast<Field>())
            {
                formData.Add(formField.PartialName, formField.Value);
            }
            return formData;
        }
        public static void FillTextbox(string infile, string outfile, string[] fields, string[] values)
        {
            // Open document
            Document document = new(infile);
            for (int i = 0; i < fields.Length; i++)
            {
                // Modify field value
                if (document.Form[fields[i]] is TextBoxField textBoxField)
                {
                    textBoxField.Value = values[i];
                }
            }
            document.Save(outfile);
        }
    }
}