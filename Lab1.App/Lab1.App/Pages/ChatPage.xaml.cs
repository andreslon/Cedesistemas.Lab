using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab1.App.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatPage : ContentPage
	{
		public ChatPage ()
		{
			InitializeComponent ();
		}
        async private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            await CrossTextToSpeech
                .Current.Speak(
                txtMensaje.Text
                + ". Atentamente:"
                + txtUsuario.Text);
        }
    }
}