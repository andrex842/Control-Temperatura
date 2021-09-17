using Plugin.LocalNotifications;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFEmpleados
{
    public partial class App : Application
    {
        public App()
        {
            

            MainPage = new NavigationPage (new Page2());

            CrossLocalNotifications.Current.Show("Serviaseo S.A.",
                    "\nTe recuerda Conservar la distancia de dos Metros", +1, DateTime.Now.AddSeconds(0));

            CrossLocalNotifications.Current.Show("Serviaseo S.A.",
                "\nTe Recuerda Incluir la Temperatura ", 0, DateTime.Now.AddMinutes(480));
            CrossLocalNotifications.Current.Show("Serviaseo S.A.",
                "\nEs hora de Lavarte las Manos ", +2, DateTime.Now.AddMinutes(120));
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
