using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3FNarvaez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrmCalificaciones : ContentPage
    {
        public FrmCalificaciones(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

        private void btnresultado_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtdato1.Text);
                double dato2 = Convert.ToDouble(txtdato2.Text);
                double dato3 = Convert.ToDouble(txtdato3.Text);
                double dato4 = Convert.ToDouble(txtdato4.Text);
                double s1 = dato1 * 0.3;
                double e1 = dato2 * 0.2;
                double Ep1 = s1 + e1;
                double s2 = dato3 * 0.3;
                double e2 = dato4 * 0.2;
                double Ep2 = s2 + e2;
                txtEp1.Text = Ep1.ToString();
                txtEp2.Text = Ep2.ToString();
                double fn = Ep1 + Ep2;
                if (fn >= 7)
                {

                    DisplayAlert("Promedio", fn.ToString(), "Aprobado");
                }
                else
                {
                    DisplayAlert("Promedio", fn.ToString(), "Reprobado");
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "ok");
            }
        }
    }
}