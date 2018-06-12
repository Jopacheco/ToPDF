using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfViewerNet;
using PdfPrintingNet;

namespace Controllers
{
        public class PdfImprimir
    {
        /*** Abertura de ficheiro e operações de impressão do mesmo ***/

        var pdfViewer = new PdfViewer();
        pdfViewer.OpenDocument(@"c:\test\test.pdf");
        pdfViewer.DocumentPrintBegin += PdfViewer_DocumentPrintBegin;
        pdfViewer.DocumentPrintEnd += PdfViewer_DocumentPrintEnd;
        pdfViewer.DocumentPrintPageBegin += PdfViewer_DocumentPrintPageBegin;
        pdfViewer.DocumentPrintPageEnd += PdfViewer_DocumentPrintPageEnd;
        PdfPrint.Status status = pdfViewer.Print();


        private void PdfViewer_DocumentPrintPageBegin(object sender, PdfPrint.DocumentPrintPageEventArgs e)
        {
            string msg = "Print page begin. CurrentPageIndex=" + e.CurrentPageIndex + " Page Number=" +
            e.PageNumber + " Total Pages to Print=" + e.TotalNumberOfPagesToPrint;
        }

        private void PdfViewer_DocumentPrintPageEnd(object sender, PdfPrint.DocumentPrintPageEventArgs e)
        {
            string msg = "Print page end. CurrentPageIndex=" + e.CurrentPageIndex + " Page Number=" +
            e.PageNumber + " Total Pages to Print=" + e.TotalNumberOfPagesToPrint;
        }

        private void PdfViewer_DocumentPrintBegin(object sender, PdfPrint.DocumentPrintBeginEventArgs e)
        {
            string msg = "Print document end. Document = " + e.FileName +
            " Number of pages in document=" + e.NumberOfPagesInDocument +
            " Number of pages to print=" + e.NumberOfPagesToPrint;
        }

        private void PdfViewer_DocumentPrintEnd(object sender, PdfPrint.DocumentPrintEndEventArgs e)
        {
            string msg = "Print document end. Document = " + e.FileName + "Status=" + e.Status +
            " Number of pages in document=" + e.NumberOfPagesInDocument +
            " Number of pages printed:" + e.NumberOfPagesPrinted;
        }
        // GET: Imprimir e retorna a View

        public ActionResult Index()
        {
            return View();
        }
    }
    }
