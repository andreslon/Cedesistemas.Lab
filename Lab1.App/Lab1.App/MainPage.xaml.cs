using Plugin.TextToSpeech;
using System;
using Xamarin.Forms;

namespace Lab1.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


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
