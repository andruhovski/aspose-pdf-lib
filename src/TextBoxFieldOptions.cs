using Aspose.Pdf.Annotations;
using Microsoft.JavaScript.NodeApi;

namespace AsposePdfLib
{
    [JSExport]
    public class TextBoxFieldOptions
    {
        public TextBoxFieldOptions()
        {
            Name = "untitled";
            PageIndex = 1;
            Value = string.Empty;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int PageIndex { get; set; }
        public Border? Border { get; set; }
    }

    [JSExport]
    public class Border
    {
        public Border()
        {
            Gap = 1;
            Dash = 1;
            Color = "#000000";
        }
        public int Gap { get; set; }
        public int Dash { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }
    }
}