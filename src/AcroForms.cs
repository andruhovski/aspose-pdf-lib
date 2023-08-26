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
        public static void CreateTextBoxField(string infile, TextBoxFieldOptions field)
        {
            // Open document
            Document document = new(infile);
            var rectangle = new Rectangle(field.X, field.Y, field.X + field.Width, field.Y + field.Height);
            // Create a field
            TextBoxField textBoxField = new(document.Pages[field.PageIndex], rectangle)
            {
                PartialName = field.Name,
                Value = field.Value
            };

            if (field.Border != null)
            {
                // Create decorations (like Border)
                Aspose.Pdf.Annotations.Border border = new(textBoxField)
                {
                    Width = field.Border.Width,
                    Dash = new Dash(field.Border.Gap, field.Border.Dash)
                };
                textBoxField.Border = border;
            }
            textBoxField.Color = Color.Black;

            // Add field to the document
            document.Form.Add(textBoxField, field.PageIndex);

            // Save modified PDF
            document.Save(infile);
        }

        public static IDictionary<string, string> Extract(string infile)
        {
            Document document = new(infile);
            IDictionary<string, string> formData = new Dictionary<string, string>();
            foreach (Field formField in document.Form.Cast<Field>())
            {
                formData.Add(formField.PartialName, formField.Value);
            }
            return formData;
        }
        public static void FillTextBoxFields(string infile, string outfile, string[] fields, string[] values)
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