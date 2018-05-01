using System;
using System.Collections.Generic;


namespace PdfModel
{
    public class PdfModel
    {
        public PdfModel()
        {
            
        }
    }

    List<string> Pastas;
    List<string> Ficheiros;

    public void setListaFicheiros(System.Collections.Generic.List Ficheiros) //método que lista ficheiros existentes no suporte armazenamento
    {
        this.setListaFicheiros = setListaFicheiros;
    }

    public void setListaPastas(List Pastas) //método que lista pastas existentes no suporte armazenamento
    {
        this.setListaPastas = setListaPastas;
    }

    public class DadosAlteradosEvent : EventArgs //classe para eventos personalizada
    {
        //Aqui vai estar o codigo deste metodo
    }
    protected virtual void OnDadosAlterados() //método que lança os eventos
    {
        //Aqui vai estar o codigo deste metodo
    }
}