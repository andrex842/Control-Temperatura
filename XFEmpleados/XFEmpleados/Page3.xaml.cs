using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFEmpleado;
using Xamarin.Essentials;
using SQLite.Net;

namespace XFEmpleados
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            GuardarBtn2.Clicked += GuardarBtn2_Clicked;
            verBtn2.Clicked += VerBtn2_Clicked;
            ComunicarmeBtn2.Clicked += ComunicarmeBtn2_Clicked;
            checkBox5.CheckedChanged += CheckBox5_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox6_CheckedChanged;
            checkBox7.CheckedChanged += CheckBox7_CheckedChanged;
            checkBox8.CheckedChanged += CheckBox8_CheckedChanged;
            checkBox9.CheckedChanged += CheckBox9_CheckedChanged;
            checkBox0.CheckedChanged += CheckBox0_CheckedChanged;
            
		}

        private void CheckBox0_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox0 != null)
            {
                LabelIngIn.Text = checkBox0.Text;
            }
        }

        private void CheckBox9_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox9 != null)
            {
                LabelIngIn.Text = checkBox9.Text;
            }
        }

        
        private void CheckBox8_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox8 != null)
            {
                Pregunta2Entry.Text = checkBox8.Text;
            }
        }

        private void CheckBox7_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox7 != null)
            {
                Pregunta2Entry.Text = checkBox7.Text;
            }
        }

        private void CheckBox6_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox6 != null)
            {
                Pregunta1Entry.Text = checkBox6.Text;
            }
        }

        private void CheckBox5_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox5 != null)
            {
                Pregunta1Entry.Text = checkBox5.Text;
            }
        }

        private void ComunicarmeBtn2_Clicked(object sender, EventArgs e)
        {
            PhoneDialer.Open("192");
        }

        private void VerBtn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private async void GuardarBtn2_Clicked(object sender, EventArgs e)
        {
            decimal Temperatura = decimal.Parse(TemperaturaEntry.Text);
            int IDEmpleado = int.Parse(IdentificacionEntry.Text);
            Int64 TelContac = Int64.Parse(TelEntry.Text);

            

            if (string.IsNullOrEmpty(IdentificacionEntry.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar su Identificacion", "Aceptar");
                IdentificacionEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(NombresEntry.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar su Nombre", "Aceptar");
                NombresEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TelEntry.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar Numero de contacto", "Aceptar");
                TelEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(AutoEntry.Text))
            {
                await DisplayAlert("Error", "Debe Reportar Quien Autoriza su Ingreso", "Aceptar");
                AutoEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(MotEntry.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar el Motivo de su Ingreso", "Aceptar");
                MotEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Pregunta1Entry.Text))
            {
                await DisplayAlert("Error", "Debe Responder las Preguntas", "Aceptar");
                Pregunta1Entry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Pregunta2Entry.Text))
            {
                await DisplayAlert("Error", "Debe Debe Responder las Preguntas", "Aceptar");
                Pregunta2Entry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TemperaturaEntry.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar su Temperatura", "Aceptar");
                TemperaturaEntry.Focus();
                return;


            }
            if (string.IsNullOrEmpty(ResulF.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar la Fecha", "Aceptar");
                ResulF.Focus();
                return;


            }



            Empleado empleado = new Empleado
            {

                Usuario = "INVITADO",
                IDEmpleado=int.Parse(IdentificacionEntry.Text),
                TelContac = Int64.Parse(TelEntry.Text),
                Nombres = NombresEntry.Text,
                Autoriza = AutoEntry.Text, 
                Motivo = MotEntry.Text,
                FechaDia = ResulF.Text,
                Pregunta1 = Pregunta1Entry.Text,
                Pregunta2 = Pregunta2Entry.Text,
                Temperatura = decimal.Parse(TemperaturaEntry.Text),
                Jornada = LabelIngIn.Text,




            };
            using (var datos = new DataAccess())
            {
                datos.InsertEmpleado(empleado);

            }

            await DisplayAlert("Bienvenido", "INVITADO" +
                    "\n Respuestas Almacenadas Correctamente", "Aceptar");

            IdentificacionEntry.Text = string.Empty;
            NombresEntry.Text = string.Empty;
            AutoEntry.Text = string.Empty;
            MotEntry.Text = string.Empty;
            TelEntry.Text = string.Empty;
            ResulF.Text = string.Empty;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox0.Checked = false;
            checkBox9.Checked = false;
            Pregunta1Entry.Text = string.Empty;
            Pregunta2Entry.Text = string.Empty;
            TemperaturaEntry.Text = string.Empty;

            

            if (Temperatura < 38)
            {
                await DisplayAlert("EnhoraBuena", "Su temperatura es adecuada, Puede Continuar!", "Aceptar");
                TemperaturaEntry.Focus();
                return;

            }
            if (Temperatura > 37)
            {
                await DisplayAlert("Emergencia", "Su temperatura es demasiada alta..." +
                    "\nPasos a seguir: " +
                    "\n" +
                    "\n1. Dirigirse  al area de Salud Ocupacional para ser orientado" +
                    "\n" +
                    "\n2. Seleccione el boton EMERGENCIA para comunicarse con la linea de atencion al COVID-19" +
                    "\n" +
                    "\n3. Comunique y haga saber a su EPS ",
                    "Aceptar");
                TemperaturaEntry.Focus();
                return;
            }
        }

        private void Fecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            ResulF.Text = e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}