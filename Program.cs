namespace PdfController
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfModel Model= new PdfModel();
            PdfView ViewInput = new PdfView();
            PdfView ViewIntfr = new PdfView();

            PdfController controller = new PdfController(Model,ViewInput,ViewIntfr);



           
        }
    }
}
