"use strict";
const asposePdfLib = require('./aspose-pdf-lib');
const converter = asposePdfLib.converter;
const merger = asposePdfLib.merger;
const pageManager = asposePdfLib.page
converter.PDFtoJPEG("sample.pdf","image");
merger.BMPtoPDF(["sample1.bmp","sample2.bmp"],"sample.pdf");
