using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhonnyZapataExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogear_Clicked(object sender, EventArgs e)
        {
            var usuario = "estudiante2020";
            var password = "uisrael2020";

            if (txtUsuario.Text == usuario & txtPassword.Text == password)
            {
                await Navigation.PushAsync(new Registro(txtUsuario.Text));
            }
            else {
                await DisplayAlert("Advertencia", "Usuario o contraseña invalidos", "ok");
            }

        }
    }
}