using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfEdit.Pdf;
using PdfEdit.Pdf.IO;

namespace Controllers
{
    class PdfRemover
    {
        /*** Abertura de ficheiro, modificação com remoção de página para novo ficheiro Pdf ***/

        PdfDocument pdfDocument = PdfReader.Open(@"c:\test\test.pdf", PdfDocumentOpenMode.Modify);
        if (pdfDocument.Pages.Count > 1)
	    pdfDocument.Pages.RemoveAt(1); // remove second page
        pdfDocument.SetLicenseInfo("companyName", "licenseKey");
        pdfDocument.Save(@"c:\test\test.pdf");
           
        // GET: Remover e retorna a View

        public ActionResult Index()
    {
        return View();
    }
    }
}
