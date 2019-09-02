using System;
using System.Collections.Generic;
using System.Text;

namespace AppRankingGatos.Model
{
    public class Gato
    {
        //Declaracion de clase Gato
        public string Nombre { get; set; }
        public string Duenio { get; set; }
        public string UrlImagen { get; set; }
        public string Personalidad { get; set; }

        public  List<Gato> GetGatos()
        {
            List<Gato> gatos = new List<Gato>()
            {   //Creacion Lista de gatos
                new Gato()
                {
                    Nombre="Olivia",
                    Duenio="Lara",
                    UrlImagen="olivia.png",
                    Personalidad="Seria, calculadora, egocéntrica"
            
                },
                new Gato()
                {
                    Nombre="Galileo",
                    Duenio="Lara",
                    UrlImagen="galileo.png",
                    Personalidad="Juguetón, amigable, perruno"

                },
                new Gato()
                {
                    Nombre="Confianza",
                    Duenio="Nicolás",
                    UrlImagen="confianza.png",
                    Personalidad="Vaga, hiperactiva, confianzuda"
                },
                new Gato()
                {
                    Nombre="Gatto",
                    Duenio="Vittorio",
                    UrlImagen="gatto.png",
                    Personalidad="Mimoso, refinado, tímido"
                },
                new Gato()
                {
                    Nombre="?????????",
                    Duenio="Vecina de Lara",
                    UrlImagen="gatovecino.png",
                    Personalidad="Observador, miedoso, desafiante"
                }

            };
            return gatos;
        }
    }
}
