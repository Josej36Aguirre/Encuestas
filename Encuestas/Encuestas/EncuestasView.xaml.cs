using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Encuestas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EncuestasView : ContentPage
	{
		public EncuestasView ()
		{
			InitializeComponent ();

            btnMas.Clicked += BtnMas_Clicked;
            //aqui se crea un metod anonimo y se crea con lamda 
            MessagingCenter.Subscribe<ContentPage, Encuesta>(this, Mensajes.EncuestaCompleta, (sender, args) 
                => {
                    Panel.Children.Add(new Label()
                    {
                        Text = args.ToString()
                    });
                });
         }

        private async void BtnMas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetallesEncuestasView());
        }
    }
}