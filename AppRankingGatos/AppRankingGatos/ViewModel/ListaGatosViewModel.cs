using AppRankingGatos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRankingGatos.ViewModel
{
    public class ListaGatosViewModel
    {
        public List <Gato> Gatos{get;set;}
        
        public ListaGatosViewModel()
        {
            //setea coleccion de gatos 
            Gatos = new Gato().GetGatos();
        }
    }
}
