'use strict';
const dotnet = require('node-api-dotnet');
const path = require('node:path');

const assemblyFilePath1 = path.join(__dirname, "../bin", "Aspose.Drawing" + '.dll');
dotnet.load(assemblyFilePath1);
const assemblyFilePath2 = path.join(__dirname, "../bin", "Aspose.PDF" + '.dll');
dotnet.load(assemblyFilePath2);
const asposePdfNodeLib = dotnet.require("./bin/AsposePdfNodeLib");
const convertPdf = asposePdfNodeLib.ConvertPDF;
const convertImage = asposePdfNodeLib.ConvertImage;
const mergerPDF = asposePdfNodeLib.MergerPDF;
const metadataPDF = asposePdfNodeLib.MetadataPDF;
module.exports = {
    converter : {
        PDFtoJPEG : function(infile,outfile){
            convertPdf.toJPEG(infile,outfile,300,90);
        },
        PDFtoPNG : function(infile,outfile){
            convertPdf.toPNG(infile,outfile,300);
        },
        PDFtoBMP: function (infile, outfile) {
            convertPdf.toBMP(infile, outfile, 300, 90);
        },
        PDFtoDOC: function (infile, outfile) {
            convertPdf.toDOC(infile, outfile);
        },
        PDFtoDOCX: function (infile, outfile) {
            convertPdf.toDOCX(infile, outfile);
        },
        PDFtoEMF: function (infile, outfile) {
            convertPdf.toEMF(infile, outfile);
        },
        PDFtoEPUB: function (infile, outfile) {
            convertPdf.toEPUB(infile, outfile);
        },
        PDFtoEXCEL: function (infile, outfile) {
            convertPdf.toEXCEL(infile, outfile);
        },
        PDFtoGIF: function (infile, outfile) {
            convertPdf.toGIF(infile,outfile,300);
        },
        PDFtoHTML: function (infile, outfile) {
            convertPdf.toHTML(infile, outfile)
        },
        PDFtoJPEG: function (infile, outfile) {
            convertPdf.toJPEG(infile, outfile,300,95)
        },
        PDFtoPDFA: function (infile, outfile, logfile) {
            convertPdf.toPDFA(infile, outfile, logfile)
        },
        PDFtoPNG: function (infile, outfile) {
            convertPdf.toPNG(infile, outfile, 300);
        },
        PDFtoPPTX: function (infile, outfile) {
            convertPdf.toPPTX(infile, outfile);
        },
        PDFtoSVG: function (infile, outfile) {
            convertPdf.toSVG(infile, outfile);
        },
        PDFtoTEX: function (infile, outfile) {
            convertPdf.toTEX(infile, outfile);
        },
        PDFtoTIFF: function (infile, outfile) {
            convertPdf.toTIFF(infile, outfile);
        },
        PDFtoTXT: function (infile, outfile) {
            convertPdf.toTXT(infile, outfile);
        },
        PDFtoXPS: function (infile, outfile) {
            convertPdf.toXPS(infile, outfile);
        },
        BMPtoPDF: function (infile, outfile) {
            convertImage.toPDF(infile,outfile);
        },
        BMPtoXPS: function (infile, outfile) {
            convertImage.toXPS(infile,outfile);
        },
        CGMtoBMP: function (infile, outfile) {
            convertCGM.toBMP(infile,outfile);
        },
        CGMtoDOC: function (infile, outfile) {
            convertImage.toDOC(infile,outfile);
        },
        CGMtoDOCX: function (infile, outfile) {
            convertImage.toDOCX(infile,outfile);
        },
        CGMtoEMF: function (infile, outfile) {
            convertImage.toEMF(infile,outfile);
        },
        CGMtoEPUB: function (infile, outfile) {
            convertImage.toEPUB(infile,outfile);
        },
        CGMtoGIF: function (infile, outfile) {
            convertImage.toGIF(infile,outfile);
        },
        CGMtoHTML: function (infile, outfile) {
            convertImage.toHTML(infile,outfile);
        },
        CGMtoSVG: function (infile, outfile) {
            convertImage.toSVG(infile,outfile);
        },
        CGMtoTEX: function (infile, outfile) {
            convertImage.toTEX(infile,outfile);
        },
        CGMtoTIFF: function (infile, outfile) {
            convertImage.toTIFF(infile,outfile);
        },
        CGMtoXPS: function (infile, outfile) {
            convertImage.toXPS(infile,outfile);
        },
    },
    merger : {
        BMPtoPDF : function(infiles,outfile){
            mergerPDF.mergeBMPtoPDF(infiles,outfile);               
        }
    },
    metadata: {
        getData : function(infile){
            let data = metadataPDF.getInfo(infile);
            return JSON.parse(data);
        }
    },
    pageManager: {
        deletePage: function(infile,index){
            pageManager.deletePage(infile,index);
        }
    }
}