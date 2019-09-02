using AppRankingGatos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AppRankingGatos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void HandlerClickJuego(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JuegoView()); //ABRE LA PAGINA DEL JUEGO
        }

        async void HandlerClickLista(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaGatosView ()); //ABRE LA PAGINA DEL LISTADO DE GATOS
        }
    }
}
