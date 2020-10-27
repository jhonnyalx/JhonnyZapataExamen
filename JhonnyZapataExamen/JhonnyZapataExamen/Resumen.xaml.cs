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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, double montoI)
        {

            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombreR.Text = nombre;
            txtMontoI.Text = montoI.ToString();

            if (montoI != 1800)
            {   
                var pagoM = 1800 - montoI;

                txtPagoM.Text=(((pagoM / 3) * 0.05) + (pagoM / 3)).ToString();
            }
            else {
                txtPagoM.Text = "0";
            
            }

            
        }
    }
}