using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Text;
using Microsoft.JavaScript.NodeApi;
using System;
using System.IO;
using System.Linq;

namespace AsposePdfNodeLib
{
    [JSExport]
    public static class MergerPDF
    {
        private static void MergeFileToPDF(string[] inputFiles, string outputFile, LoadOptions options)
        {
            var outputDoc = MergeDocuments(inputFiles, options);
            outputDoc.Save(outputFile);
        }

        private static void MergePDFtoFile(string[] inputFiles, string outputFile, SaveOptions options)
        {
            Document outputDoc = MergeDocuments(inputFiles);
            outputDoc.Save(outputFile, options);
        }

        private static Document MergeDocuments(string[] inputFiles)
        {
            var outputDoc = new Aspose.Pdf.Document();
            foreach (var inputFile in inputFiles)
            {
                var document = new Aspose.Pdf.Document(inputFile);
                outputDoc.Pages.Add(document.Pages);
            }

            return outputDoc;
        }

        private static Document MergeDocuments(string[] inputFiles, LoadOptions loadOptions)
        {
            var outputDoc = new Aspose.Pdf.Document();
            foreach (var inputFile in inputFiles)
            {
                var document = new Aspose.Pdf.Document(inputFile, loadOptions);
                outputDoc.Pages.Add(document.Pages);
            }

            return outputDoc;
        }

        private static void MergeFileToFile(string[] inputFiles, LoadOptions loadOptions, string outputFile, SaveOptions saveOptions)
        {
            var outputDoc = MergeDocuments(inputFiles, loadOptions);
            outputDoc.Save(outputFile, saveOptions);
        }

        private static Document MergeImage(string[] inputFiles)
        {
            var document = new Aspose.Pdf.Document();
            var streams = inputFiles.Select(fileName => File.Open(fileName, FileMode.Open));
            foreach (var fs in streams)
            {
                var page = document.Pages.Add();
                page.AddImage(fs, new Aspose.Pdf.Rectangle(0, 0, 700, 1000));
            }
            return document;
        }

        public static void MergeBMPtoPDF(string[] inputFiles, string outputFile)
        {
            var document = MergeImage(inputFiles);
            document.Save(outputFile);
        }

        public static void MergeCGMtoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new CgmLoadOptions());
        }

        public static void MergeEPStoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new PsLoadOptions());
        }

        public static void MergeEPUBtoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new EpubLoadOptions());
        }

        public static void MergePDF(string[] inputFiles, string outputFile, PdfFormat? pdfFormat = null)
        {
            var outputDoc = new Aspose.Pdf.Document();
            foreach (var inputFile in inputFiles)
            {
                var document = new Aspose.Pdf.Document(inputFile);
                outputDoc.Pages.Add(document.Pages);
            }
            if (pdfFormat.HasValue)
            {
                outputDoc.Convert(outputFile.Replace(".pdf", ".log"), pdfFormat.Value, Aspose.Pdf.ConvertErrorAction.Delete);
            }
            outputDoc.Save(outputFile);
        }

        public static void MergeHTMLtoDOCX(string[] inputFiles, string outputFile)
        {
            MergeFileToFile(
                inputFiles, new HtmlLoadOptions(),
                outputFile, new DocSaveOptions { Format = DocSaveOptions.DocFormat.DocX });
        }

        public static void MergeHTMLtoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new HtmlLoadOptions());
        }

        public static void MergeHTMLtoXPS(string[] inputFiles, string outputFile)
        {
            MergeFileToFile(inputFiles, new HtmlLoadOptions(), outputFile, new XpsSaveOptions());
        }

        public static void MergeJPEGtoDOCX(string[] inputFiles, string outputFile)
        {
            var outputDocument = MergeImage(inputFiles);
            outputDocument.Save(outputFile, new DocSaveOptions { Format = DocSaveOptions.DocFormat.DocX });
        }

        public static void MergeJPEGtoPDF(string[] inputFiles, string outputFile)
        {
            var outputDocument = MergeImage(inputFiles);
            outputDocument.Save(outputFile);
        }

        public static void MergeJPEGtoXPS(string[] inputFiles, string outputFile)
        {
            var outputDocument = MergeImage(inputFiles);
            outputDocument.Save(outputFile, new XpsSaveOptions());
        }

        public static void MergeMDtoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new MdLoadOptions());
        }

        public static void MergeMHTtoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new MhtLoadOptions());
        }

        public static void MergePCLtoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new PclLoadOptions());
        }

        public static void MergePDFtoDOC(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new DocSaveOptions { Format = DocSaveOptions.DocFormat.Doc });
        }

        public static void MergePDFtoDOCX(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new DocSaveOptions { Format = DocSaveOptions.DocFormat.DocX });
        }

        public static void MergePDFtoEPUB(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new EpubSaveOptions());
        }

        public static void MergePDFtoHTML(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new EpubSaveOptions());
        }
        public static void MergePDFtoPDFA(string[] inputFiles, string outputFile, string pdfa)
        {
            PdfFormat pdfFormat;
            if (Enum.TryParse(pdfa, true, out pdfFormat))
            {
                MergePDF(inputFiles, outputFile, pdfFormat);
            }
            else
            {
                MergePDF(inputFiles, outputFile);
            }
        }
        public static void MergePDFtoPPTX(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new PptxSaveOptions());
        }

        public static void MergeSVGtoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new SvgLoadOptions());
        }

        public static void MergePDFtoBMP(string[] inputFiles, string outputFile)
        {
            throw new NotImplementedException();
        }

        public static void MergePDFtoJPEG(string[] inputFiles, string outputFile)
        {
            throw new NotImplementedException();
        }

        public static void MergePDFtoPNG(string[] inputFiles, string outputFile)
        {
            throw new NotImplementedException();
        }

        public static void MergePDFtoSVG(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new SvgSaveOptions());
        }

        public static void MergePDFtoTeX(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new TeXSaveOptions());
        }

        public static void MergePDFtoTXT(string[] inputFiles, string outputFile)
        {
            var document = MergeDocuments(inputFiles);
            TextAbsorber ta = new();
            ta.Visit(document);
            File.WriteAllText(outputFile, ta.Text);
        }

        public static void MergePDFtoTIFF(string[] inputFiles, string outputFile)
        {
            var document = MergeDocuments(inputFiles);
            var device = new TiffDevice(new Resolution(300));
            device.Process(document, outputFile);
        }

        public static void MergePDFtoXLS(string[] inputFiles, string outputFile)
        {
            var options = new ExcelSaveOptions();
            options.Format = ExcelSaveOptions.ExcelFormat.XMLSpreadSheet2003;
            MergePDFtoFile(inputFiles, outputFile, options);
        }

        public static void MergePDFtoXLSX(string[] inputFiles, string outputFile)
        {
            var options = new ExcelSaveOptions();
            options.Format = ExcelSaveOptions.ExcelFormat.XLSX;
            MergePDFtoFile(inputFiles, outputFile, options);
        }

        public static void MergePDFtoXPS(string[] inputFiles, string outputFile)
        {
            MergePDFtoFile(inputFiles, outputFile, new XpsSaveOptions());
        }

        public static void MergePNGtoPDF(string[] inputFiles, string outputFile)
        {
            var document = MergeImage(inputFiles);
            document.Save(outputFile);
        }

        public static void MergePStoPDF(string[] inputFiles, string outputFile)
        {
            MergeFileToPDF(inputFiles, outputFile, new PsLoadOptions());
        }
        public static void MergeTeXtoPDF(string[] inputFiles, string outputFile)
        {
            var options = new Aspose.Pdf.TeXLoadOptions
            {
                NoLigatures = false,
                RasterizeFormulas = true,
                ShowTerminalOutput = true
            };
            MergeFileToPDF(inputFiles, outputFile, options);
        }
        public static void MergeTIFFtoPDF(string[] inputFiles, string outputFile)
        {
            throw new NotImplementedException();
        }
        public static void MergeXMLtoPDF(string[] inputFiles, string outputFile, string xsltFile)
        {
            XslFoLoadOptions options = new XslFoLoadOptions(xsltFile);
            MergeFileToPDF (inputFiles, outputFile, options);
        }
        public static void MergeXPSLtoPDF(string[] inputFiles, string outputFile, string xsltFile)
        {
            XpsLoadOptions options = new();
            MergeFileToPDF (inputFiles, outputFile, options);
        }
    }
}