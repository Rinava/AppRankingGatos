using AppRankingGatos.Model;
using AppRankingGatos.ViewModel;
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
	public partial class ListaGatosView : ContentPage
	{
        
        ListaGatosViewModel vm;
		public ListaGatosView ()
		{    
			InitializeComponent ();
            vm = new ListaGatosViewModel();
            BindingContext = vm;

		}
        
        void HandlerGatoSelecto(object sender, SelectedItemChangedEventArgs e)
        {
            Gato selectedItem = e.SelectedItem as Gato;
            ImgGatoSelecto.Source = selectedItem.UrlImagen;
            LblGatoSelecto.Text = selectedItem.Personalidad;
        }

        void HandlerClickImagen(object sender, EventArgs e)
        {
            ImgGatoSelecto.Source ="";
            LblGatoSelecto.Text ="";
        }
    }
}