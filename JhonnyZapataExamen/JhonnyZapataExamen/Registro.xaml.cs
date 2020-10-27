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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = " Usuario conectado: " + usuario;

        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            var montoI = Convert.ToDouble(txtMontoI.Text);
            if (txtNombre.Text != "" )
            {
                if (montoI > 0 & montoI <= 1800)
                {
                    await Navigation.PushAsync(new Resumen(lblUsuario.Text,txtNombre.Text,montoI));
                }
                else {
                    await DisplayAlert("Advertencia", "Por favor ingrese un valor menor a 1800", "ok");
                }
            }
            else {
                await DisplayAlert("Advertencia","Por favor ingrese un nombre","ok");
            }
            
            

        }
    }
}