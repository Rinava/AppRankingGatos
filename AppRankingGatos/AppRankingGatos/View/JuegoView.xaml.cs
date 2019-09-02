using AppRankingGatos.ViewModel;
using AppRankingGatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRankingGatos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JuegoView : ContentPage
    {
        public JuegoView()
        {
            InitializeComponent();
            CargaRandom();
        }
         public void  CargaRandom()
        {
            int random1, random2 = 1;
            do
            {
                Random random = new Random();
                random1 = random.Next(0, 5);
                random2 = random.Next(0, 5);
            } while (random1 == random2);
            Gato gato1 = new Gato().GetGatos().ElementAt(random1);
            Gato gato2 = new Gato().GetGatos().ElementAt(random2);
            btngato1.Source = gato1.UrlImagen;
            gato1Nombre.Text = "Nombre: "+gato1.Nombre;
            gato1Duenio.Text = "Dueño: " + gato1.Duenio;
            gato1Personalidad.Text = "Personalidad: " + gato1.Personalidad;
            btngato2.Source = gato2.UrlImagen;
            gato2Nombre.Text ="Nombre: "+ gato2.Nombre;
            gato2Duenio.Text = "Dueño: "+gato2.Duenio;
            gato2Personalidad.Text ="Personalidad: "+ gato2.Personalidad;
        } 
       async void Handlerbtn(object sender, EventArgs e)
        {
            txtPorBoton2.IsVisible=true;
            txtPorBoton1.IsVisible=true;
            await txtPorBoton2.ScaleTo(5, 500);
            await txtPorBoton2.ScaleTo(0.1, 200, Easing.CubicInOut);
            await txtPorBoton2.ScaleTo(1, 200, Easing.CubicInOut);
        }
        async void HandlerReiniciar(object sender, EventArgs e)
        {
            var PagReiniciar = new JuegoView();
            Navigation.InsertPageBefore(PagReiniciar, this);
            await  Navigation.PopAsync();
        }
    }
}