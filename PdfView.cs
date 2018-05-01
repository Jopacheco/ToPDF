using System.IO;
using System.Linq;

namespace PdfView
{
    public class PdfView
    {
        public PdfView()
        {
        }
    }

    public void OnDadosAlterados(object origem, DadosAlteradosEvent e) //método subscritor do delegado. Atualiza variáveis da View com dados do modelo
    {
        //Aqui vai estar o codigo deste metodo
    }


    public void getListaFicheiros(string ficheiro)
    {
        ficheiro = Directory.GetFiles(ficheiro).ToList();
            PdfController.getListaFicheiros(Ficheiros);
     }

        
    public void getListaPastas(string pasta)

        {
            //apresenta janela com lista de pastas conforme input do utilizador

            Pastas = Directory.GetDirectories(pasta).ToList();
            PdfController.getListaPastas(Pastas);

       }
        
    }
