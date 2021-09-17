using System;
using System.IO;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFEmpleado;
using Plugin.Connectivity;
using Xamarin.Essentials;

namespace XFEmpleados
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{


		public Page1 ()
		{
			InitializeComponent ();
            statusInternet.Text = CrossConnectivity.Current.IsConnected ? "Connected" : "Disconnected";

            datosListView.ItemTemplate = new DataTemplate(typeof(EmpleadoCell));
            datosListView.ItemSelected += DatosListView_ItemSelected;
            ActualiBtn.Clicked += ActualiBtn_Clicked;


           

            using (var datos = new DataAccess())
            {
                datosListView.ItemsSource = datos.GetEmpleado();
            }
            

        }


        public static int Inc;

        public void ActualiBtn_Clicked(object sender, EventArgs e)
        {

            

            statusInternet.Text = statusInternet.Text.ToString();
            

            if (statusInternet.Text == "Connected")
            {
                string ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string Nombres = "ACUÑA MANRIQUE LUZ GLADYS";


                Inc++;

                Cont.Text = Inc.ToString();




                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://192.168.0.10/" + Nombres + "-" + Cont.Text + "-" + "Empleado.sqlite");




                request.Method = WebRequestMethods.Ftp.UploadFile;
                // Usuario y contraseña de la ftp
                request.Credentials = new NetworkCredential("AdminS", "Bogota2018**");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;



                // Ruta y nombre del archivo que vamos a enviar

                FileStream stream = File.OpenRead(ruta + "/Empleado.sqlite");

                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                reqStream.Close();



                DisplayAlert("Mensaje", "Datos Enviados Correctamente", "Ok");
                Navigation.PushAsync(new Page2());

            }

            else
            {
                DisplayAlert("Error", "Datos No enviados" + "\nSin Conexion a Internet", "Ok");
            }

            if (statusInternet.Text == null)
            {

                DisplayAlert("Error", "Datos No enviados" + "\nSin Conexion a Internet", "Ok");

            }


            
                       


        }

        private  void DatosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            Navigation.PushAsync(new EditPage((Empleado)e.SelectedItem));
        }

    }
}
    
