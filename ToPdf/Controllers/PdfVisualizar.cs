using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfViewerNet;

namespace ToPdf.Controllers
{
    class PdfVisualizar
    {
        /* Para Abrir documento Pdf */

        var pdfViewer = new PdfVisualizar();
        pdfViewer.DocumentLoaded += PdfViewer_DocumentLoaded;
        PdfOpenFileStatus status = pdfViewer.OpenDocument(@"c:\test\test.pdf");
        string msg = "";
        if (status.Result == PdfOpenFileStatus.PdfOpenFileResult.OK)
        msg = string.Format("Document has {0} pages. Current page is {1}. ",
        pdfViewer.NumberOfPages, pdfViewer1.CurrentPageNumber);
        else
               msg = "There was a problem loading document. Status = " + status.Result.ToString() + "
                   Additional information = " + status.Status;
        MessageBox.Show(msg);

p       private void PdfViewer_DocumentLoaded(object sender, DocumentLoadedEventArgs e)
        {
            MessageBox.Show("Document " + e.FileName + " was loaded");
        }
    }
}
