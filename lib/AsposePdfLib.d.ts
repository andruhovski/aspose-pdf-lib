// Generated for: AsposePdfLib 1.0.0.0
// Generated by: Microsoft.JavaScript.NodeApi.Generator 0.4.0.0
/* eslint-disable */


import './Aspose.PDF';

declare module 'node-api-dotnet' {

	export namespace ProtectPDF {
		export function encrypt(
			inputFile: string,
			outPutFile: string,
			userPassword: string,
			ownerPassword: string,
		): void;

		export function decrypt(
			inputFile: string,
			outPutFile: string,
			password: string,
		): void;
	}

	export namespace SplitterPDF {
		export function eachPages(
			inFile: string,
			template: string,
		): void;
	}

	export namespace AcroFormsPDF {
		export function createTextBoxField(
			infile: string,
			options: string,
		): void;

		export function extract(infile: string): Map<string, string>;

		export function fillTextBoxFields(
			infile: string,
			outfile: string,
			fields: string[],
			values: string[],
		): void;
	}

	export namespace ConvertCGM {
		export function toBMP(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toDOC(
			inputFile: string,
			outputFile: string,
		): void;

		export function toDOCX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toEMF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toEPUB(
			inputFile: string,
			outputFile: string,
		): void;

		export function toGIF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toHTML(
			inputFile: string,
			outputFile: string,
		): void;

		export function toJPEG(
			inputFile: string,
			outputFile: string,
			resolution: number,
			quality: number,
		): void;

		export function toPDFA(
			inputFile: string,
			outputFile: string,
			logFile: string,
		): void;

		export function toPNG(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toPPTX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toSVG(
			inputFile: string,
			outputFile: string,
		): void;

		export function toTEX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toTIFF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toTXT(
			inputFile: string,
			outputFile: string,
		): void;

		export function toXPS(
			inputFile: string,
			outputFile: string,
		): void;
	}

	export namespace ConvertDICOM {
		export function toPDF(
			inputFile: string,
			outputFile: string,
		): void;
	}

	export namespace ConvertEMF {
		export function toPDF(
			inputFile: string,
			outputFile: string,
		): void;
	}

	export namespace ConvertHTML {
		export function toBMP(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toDOC(
			inputFile: string,
			outputFile: string,
		): void;

		export function toDOCX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toEMF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toEPUB(
			inputFile: string,
			outputFile: string,
		): void;

		export function toGIF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toJPEG(
			inputFile: string,
			outputFile: string,
			resolution: number,
			quality: number,
		): void;

		export function toPDFA(
			inputFile: string,
			outputFile: string,
			logFile: string,
		): void;

		export function toPNG(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toPPTX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toSVG(
			inputFile: string,
			outputFile: string,
		): void;

		export function toTEX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toTIFF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toTXT(
			inputFile: string,
			outputFile: string,
		): void;

		export function toXPS(
			inputFile: string,
			outputFile: string,
		): void;
	}

	export namespace ConvertImage {
		export function toPDF(
			inputFile: string,
			outputFile: string,
		): void;

		export function toXPS(
			inputFile: string,
			outputFile: string,
		): void;

		export function toDOCX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toPPTX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toTEX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toEPUB(
			inputFile: string,
			outputFile: string,
		): void;
	}

	export namespace ConvertPDF {
		export function toBMP(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toDOC(
			inputFile: string,
			outputFile: string,
		): void;

		export function toDOCX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toEMF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toEPUB(
			inputFile: string,
			outputFile: string,
		): void;

		export function toEXCEL(
			inputFile: string,
			outputFile: string,
		): void;

		export function toGIF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toHTML(
			inputFile: string,
			outputFile: string,
		): void;

		export function toJPEG(
			inputFile: string,
			outputFile: string,
			resolution: number,
			quality: number,
		): void;

		export function toPDFA(
			inputFile: string,
			outputFile: string,
			logFile: string,
		): void;

		export function toPNG(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toPPTX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toSVG(
			inputFile: string,
			outputFile: string,
		): void;

		export function toTEX(
			inputFile: string,
			outputFile: string,
		): void;

		export function toTIFF(
			inputFile: string,
			outputFile: string,
			resolution: number,
		): void;

		export function toTXT(
			inputFile: string,
			outputFile: string,
		): void;

		export function toXPS(
			inputFile: string,
			outputFile: string,
		): void;
	}

	export namespace MergerPDF {
		export function mergeBMPtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeCGMtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeEPStoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeEPUBtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDF(
			inputFiles: string[],
			outputFile: string,
			pdfFormat?: Aspose.Pdf.PdfFormat,
		): void;

		export function mergeHTMLtoDOCX(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeHTMLtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeHTMLtoXPS(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeJPEGtoDOCX(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeJPEGtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeJPEGtoXPS(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeMDtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeMHTtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePCLtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoDOC(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoDOCX(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoEPUB(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoHTML(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoPDFA(
			inputFiles: string[],
			outputFile: string,
			pdfa: string,
		): void;

		export function mergePDFtoPPTX(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeSVGtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoBMP(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoJPEG(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoPNG(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoSVG(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoTeX(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoTXT(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoTIFF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoXLS(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoXLSX(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePDFtoXPS(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePNGtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergePStoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeTeXtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeTIFFtoPDF(
			inputFiles: string[],
			outputFile: string,
		): void;

		export function mergeXMLtoPDF(
			inputFiles: string[],
			outputFile: string,
			xsltFile: string,
		): void;

		export function mergeXPSLtoPDF(
			inputFiles: string[],
			outputFile: string,
			xsltFile: string,
		): void;
	}

	export namespace MetadataPDF {
		export function getInfo(inputFile: string): string;

		export function getAuthor(inputFile: string): string;

		export function getCreator(inputFile: string): string;

		export function getModDate(inputFile: string): string;
	}

	export namespace PagesPDF {
		export function addEmpty(
			inputFile: string,
			index: number,
		): void;

		export function deletePage(
			inputFile: string,
			index: number,
		): void;

		export function copyPage(
			srcFileName: string,
			source: number,
			dstFileName: string,
			destination: number,
		): void;

		export function movePage(
			srcFileName: string,
			source: number,
			dstFileName: string,
			destination: number,
		): void;
	}

	export namespace ParserPDF {
		export function extractText(
			inputFile: string,
			outputFile: string,
		): void;

		export function extractImages(
			inputFile: string,
			outputFile: string,
		): void;
	}

	export namespace Setup {
		export function init(path: string): void;
	}

	export class TextBoxFieldOptions {
		constructor();

		x: number;

		y: number;

		width: number;

		height: number;

		name: string;

		value: string;

		pageIndex: number;

		border?: AsposePdfLib.Border;
	}

	export class Border {
		constructor();

		gap: number;

		dash: number;

		width: number;

		color: string;
	}
}
