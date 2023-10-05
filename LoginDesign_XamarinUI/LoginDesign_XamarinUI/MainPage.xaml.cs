using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginDesign_XamarinUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if(txtUsername.Text == "admin" && txtPassword.Text == "123")
            {

                Navigation.PushAsync(new HomePage());

            }
            else
            {
                DisplayAlert("Ops..", "Nome do usuário ou senha incorretos!", "Ok");
            }

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            Navigation.PushAsync(new RegisterPage());

        }
    }
}
