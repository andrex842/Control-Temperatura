using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFEmpleado;

namespace XFEmpleados
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPage : ContentPage
	{
        private Empleado empleado;
        
		public EditPage (Empleado empleado)
		{
			InitializeComponent ();
            this.empleado = empleado;
            BorrarBtn.Clicked += BorrarBtn_Clicked;
            

		}

        public async void BorrarBtn_Clicked(object sender, EventArgs e)
        {
            var rta = await DisplayAlert("Confirmación", "¿Desea borrar el Registro?", "Si", "No");

            if (!rta) return;

            using (var datos = new DataAccess())
            {
                datos.DeleteEmpleado(empleado);
                await Navigation.PushAsync(new Page1());
            }

            await DisplayAlert("Confirmación", "Registro Borrado Correctamente", "Aceptar");

            


        }

        
    }
}