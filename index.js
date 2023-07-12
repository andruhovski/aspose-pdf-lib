'use strict';
const dotnet = require('node-api-dotnet');
const path = require('node:path');

const assemblyFilePath = path.join(__dirname, "lib", "Aspose.PDF.dll");
dotnet.load(assemblyFilePath);
const asposePdfNodeLib = dotnet.require(path.join(__dirname, "lib", "AsposePdfLib"));
// Destructure the methods from the library
const { ConvertPDF, ConvertCGM, ConvertImage, MergerPDF, MetadataPDF, PageManager, ParserPDF } = asposePdfNodeLib;
module.exports = {
    converter: {
        PDFtoJPEG: (infile, outfile) => ConvertPDF.toJPEG(infile, outfile, 300, 90),
        PDFtoPNG: (infile, outfile) => ConvertPDF.toPNG(infile, outfile, 300),
        PDFtoBMP: (infile, outfile) => ConvertPDF.toBMP(infile, outfile, 300),
        PDFtoDOC: (infile, outfile) => ConvertPDF.toDOC(infile, outfile),
        PDFtoDOCX: (infile, outfile) => ConvertPDF.toDOCX(infile, outfile),
        PDFtoEMF: (infile, outfile) => ConvertPDF.toEMF(infile, outfile),
        PDFtoEPUB: (infile, outfile) => ConvertPDF.toEPUB(infile, outfile),
        PDFtoEXCEL: (infile, outfile) => ConvertPDF.toEXCEL(infile, outfile),
        PDFtoGIF: (infile, outfile) => ConvertPDF.toGIF(infile, outfile, 300),
        PDFtoHTML: (infile, outfile) => ConvertPDF.toHTML(infile, outfile),
        PDFtoPDFA: (infile, outfile, logfile) => ConvertPDF.toPDFA(infile, outfile, logfile),
        PDFtoPNG: (infile, outfile) => ConvertPDF.toPNG(infile, outfile, 300),
        PDFtoPPTX: (infile, outfile) => ConvertPDF.toPPTX(infile, outfile),
        PDFtoSVG: (infile, outfile) => ConvertPDF.toSVG(infile, outfile),
        PDFtoTEX: (infile, outfile) => ConvertPDF.toTEX(infile, outfile),
        PDFtoTIFF: (infile, outfile) => ConvertPDF.toTIFF(infile, outfile),
        PDFtoTXT: (infile, outfile) => ConvertPDF.toTXT(infile, outfile),
        PDFtoXPS: (infile, outfile) => ConvertPDF.toXPS(infile, outfile),
        BMPtoPDF: (infile, outfile) => ConvertImage.toPDF(infile, outfile),
        BMPtoXPS: (infile, outfile) => ConvertImage.toXPS(infile, outfile),
        CGMtoBMP: (infile, outfile) => ConvertCGM.toBMP(infile, outfile),
        CGMtoDOC: (infile, outfile) => ConvertCGM.toDOC(infile, outfile),
        CGMtoDOCX: (infile, outfile) => ConvertCGM.toDOCX(infile, outfile),
        CGMtoEMF: (infile, outfile) => ConvertCGM.toEMF(infile, outfile),
        CGMtoEPUB: (infile, outfile) => ConvertCGM.toEPUB(infile, outfile),
        CGMtoGIF: (infile, outfile) => ConvertCGM.toGIF(infile, outfile),
        CGMtoHTML: (infile, outfile) => ConvertCGM.toHTML(infile, outfile),
        CGMtoSVG: (infile, outfile) => ConvertCGM.toSVG(infile, outfile),
        CGMtoTEX: (infile, outfile) => ConvertCGM.toTEX(infile, outfile),
        CGMtoTIFF: (infile, outfile) => ConvertCGM.toTIFF(infile, outfile),
        CGMtoXPS: (infile, outfile) => ConvertCGM.toXPS(infile, outfile)
        DICOM
    },
    merger: {
        BMPtoPDF: (infiles, outfile) => MergerPDF.mergeBMPtoPDF(infiles, outfile)
    },
    metadata: {
        getData: (infile) => {
            let data = MetadataPDF.getInfo(infile);
            return JSON.parse(data);
        }
    },
    pageManager: {
        deletePage: (infile, index) => PageManager.deletePage(infile, index)
    },
    parserPDF: {
        extractText: (infile, outfile) => ParserPDF.extractText(infile, outfile),
        extractImages: (infile, outfile) => ParserPDF.extractImages(infile, outfile)
    }
}