using System.Collections.Generic;


namespace PdfController
{
    public class PdfController
    {
        public PdfController()
        {
            
        }

        public void teste()
        {
            throw new System.NotImplementedException();
        }
    }

    public void getListaFicheiros(string ficheiro) // cria lista de ficheiros existentes
    {
        try

        {
            List<string> Ficheiros = new List<string>();
            PdfModel.setListaFicheiros(Ficheiros);

            //atualiza a view

            ViewInput.Atualizar();

        }
        catch (System.Exception erro)
        {
            // Caso ficheiro não exista

            MessageBox.show(erro.Message);
        }
    }

    internal class ViewInput
    {
        public ViewInput()
        {
            throw new System.NotImplementedException();
        }
    }

    public void getListaPastas(string pasta) // cria lista de pastas existentes
    {
        try
        {
            List<string> Pastas = new List<string>();
            PdfModel.setListaPastas(Pastas);
            ViewInput.Atualizar();
        }
        

        catch (System.Exception erro)
        {
            // Caso pasta não exista

            MessageBox.show(erro.Message);
        }
    }

}