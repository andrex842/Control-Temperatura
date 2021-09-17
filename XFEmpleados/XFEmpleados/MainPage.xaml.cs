using System;
using Xamarin.Forms;
using XFEmpleado;
using Xamarin.Essentials;

namespace XFEmpleados
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GuardarBtn.Clicked += GuardarBtn_Clicked;
            verBtn.Clicked += VerBtn_Clicked;
            ComunicarmeBtn.Clicked += ComunicarmeBtn_Clicked;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox4_CheckedChanged;
            checkBox5.CheckedChanged += CheckBox5_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox6_CheckedChanged;
           
            
           

        }

        

        private void CheckBox6_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox6 != null)
            {
                LabelIng.Text = checkBox6.Text;
            }
        }

        private void CheckBox5_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox5 != null)
            {
                LabelIng.Text = checkBox5.Text;
            }
        }

        

        private void CheckBox4_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox4 != null)
            {
                Pregunta2Entry.Text = checkBox4.Text;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            if (checkBox3 != null)
            {
                Pregunta2Entry.Text = checkBox3.Text;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            

            if (checkBox2 != null)
            {
                Pregunta1Entry.Text = checkBox2.Text;
            }
            

        }

        private void CheckBox1_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {
            

            if (checkBox1 !=null)
            {
                Pregunta1Entry.Text = checkBox1.Text; 
            }
           

        }

        private void ComunicarmeBtn_Clicked(object sender, EventArgs e)
        {
            
            PhoneDialer.Open("192");
        }

        private void VerBtn_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Page1());

        }

        public async void GuardarBtn_Clicked(object sender, EventArgs e)
        {
            
            decimal Temperatura = decimal.Parse(TemperaturaEntry.Text);

            

            if (string.IsNullOrEmpty(Pregunta1Entry.Text))
            {
                await DisplayAlert("Error", "Debe Responder las Preguntas", "Aceptar");
                Pregunta1Entry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Pregunta2Entry.Text))
            {
                await DisplayAlert("Error", "Debe Responder las Preguntas", "Aceptar");
                Pregunta2Entry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(LabelIng.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar la Fecha", "Aceptar");
                LabelIng.Focus();
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

                    Usuario = "EMPLEADO",
                    IDEmpleado =39638872,
                    Nombres = "ACUÑA MANRIQUE LUZ GLADYS",
                    TelContac =3017384907,
                    FechaDia = ResulF.Text,
                    Pregunta1 = Pregunta1Entry.Text,
                    Pregunta2 = Pregunta2Entry.Text,
                    Temperatura = decimal.Parse(TemperaturaEntry.Text),
                    Jornada = LabelIng.Text,

                };

            
            using (var datos = new DataAccess())
            {
                datos.InsertEmpleado(empleado);

            }



                await DisplayAlert("ACUÑA MANRIQUE LUZ GLADYS", "Respuestas Almacenadas Correctamente", "Aceptar");

            ResulF.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            Pregunta1Entry.Text = string.Empty;
            Pregunta2Entry.Text = string.Empty;
            LabelIng.Text = string.Empty;
            TemperaturaEntry.Text = string.Empty;

            await Navigation.PushAsync(new Page2());

            if (Temperatura < 37)
            {
                await DisplayAlert("EnhoraBuena", "Su temperatura es adecuada, Puede Continuar!", "Aceptar");
                TemperaturaEntry.Focus();
                

            }
            if (Temperatura >= 37)
            {
                await DisplayAlert("Emergencia", "Su temperatura es demasiada alta..."+
                    "\nPasos a seguir: " +
                    "\n" +
                    "\n1. Dirigirse  al area de Salud Ocupacional para ser orientado" +
                    "\n"+
                    "\n2. Seleccione el boton EMERGENCIA para comunicarse con la linea de atencion al COVID-19" +
                    "\n" +
                    "\n3. Comunique y haga saber a su EPS ",
                    "Aceptar");
                TemperaturaEntry.Focus();
                
            }

            

        }

        private void CheckBox_CheckedChanged(object sender, XLabs.EventArgs<bool> e)
        {

        }

        private void CheckBox_CheckedChanged_1(object sender, XLabs.EventArgs<bool> e)
        {

        }
        private void Fecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            ResulF.Text = e.NewDate.ToString("dd/MM/yyyy");
        }
       
    }
}
