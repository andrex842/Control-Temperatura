using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.App;

namespace XFEmpleados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            Pkos.Items.Add("EMPLEADO");
            Pkos.Items.Add("INVITADO");
            StarBtn.Clicked += StarBtn_Clicked;
            Exit.Clicked += Exit_Clicked;
            verBtn1.Clicked += VerBtn1_Clicked;

        }

        private void VerBtn1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            var activity = (Activity)Forms.Context;
            activity.FinishAffinity();
        }

        public void Pkos_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            var Usuario = Pkos.Items[Pkos.SelectedIndex];

            labelTexto2.Text = Usuario;



        }
        public async void StarBtn_Clicked(object sender, EventArgs e)
        {
            var Usuario = Pkos.Items[Pkos.SelectedIndex];
            int IDEmpleado = int.Parse(IdentificacionEntry.Text);
            Usuario = labelTexto2.Text;

            


            
            

            if (string.IsNullOrEmpty(labelTexto2.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar El Usuario", "Aceptar");
                labelTexto2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(IdentificacionEntry.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar Su Identificacion", "Aceptar");
                IdentificacionEntry.Focus();
                return;
            }

            


            if (Usuario == "EMPLEADO")

                
            {
                

                if (IDEmpleado == 39638872)
                {
                    
                    await Navigation.PushAsync(new MainPage());

                }
                if (IDEmpleado != 39638872)
                {
                    await DisplayAlert("Error", "Verifique Su Identificacion", "Aceptar");
                    IdentificacionEntry.Focus();
                    return;
                }

                await DisplayAlert("Bienvenido ACUÑA MANRIQUE LUZ GLADYS", "SERVIASEO S.A." + "\nIngenieria De Limpieza", "Aceptar");

            }
               

            if (Usuario == "INVITADO")
            {
                

                    await Navigation.PushAsync(new Page3());

                if (IDEmpleado == 0 )
                {
                    await DisplayAlert("Error", "Complete el campo Identificacion", "Aceptar");
                    IdentificacionEntry.Focus();
                    return;
                }

                await DisplayAlert("Bienvenido INVITADO", "SERVIASEO S.A." + "\nIngenieria De Limpieza", "Aceptar");
            }

            labelTexto2.Text = string.Empty;
            IdentificacionEntry.Text = string.Empty;
            Pkos.SelectedIndex = -0;

            


            


        }
    }
}