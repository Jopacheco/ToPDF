using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfEdit.Pdf;
using PdfEdit.Pdf.IO;

namespace Controllers
{
    public class PdfExtrair
    {
               
            PdfDocument pdfDocument = PdfReader.Open(@"c:\test\test.pdf", PdfDocumentOpenMode.Import);
            PdfDocument newPdfDocument = new PdfDocument();
            for (int i = 0; i < pdfDocument.Pages.Count; i++)
                if ((i + 1) % 2 == 0)
                    newPdfDocument.AddPage(pdfDocument.Pages[i]);

            newPdfDocument.SetLicenseInfo("companyName", "licenseKey");
            newPdfDocument.Save(@"c:\test\test2.pdf");
        

    }        
    }

   internal class ViewInput
    {
        public ViewInput()
        {
            throw new System.NotImplementedException();
        }
    }

   