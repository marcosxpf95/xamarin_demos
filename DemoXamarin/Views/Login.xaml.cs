using System;
using System.Collections.Generic;
using DemoXamarin.Models;
using Xamarin.Forms;

namespace DemoXamarin.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        void Logar(object sender, EventArgs e)
        {
            Usuario user = new Usuario(Entry_Usuario.Text, Entry_RespostaSecreta.Text);

            if(user.ValidarLogin(user.respostaSecreta))
            {
                DisplayAlert("Parabéns","Parabéns, você entende sobre futebol. Resposta secreta está correta!","Ok");
            }
            else
            {
                DisplayAlert("Falha", "Você não entende sobre futebol ou todos os dados não foram preenchidos.", "Ok");
            }
        
        }
    }
}
