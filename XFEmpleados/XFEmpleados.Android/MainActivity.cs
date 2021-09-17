
using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.LocalNotifications;


namespace XFEmpleados.Droid
{
    
    [Activity(Label = "Control de Temperatura Serviaseo s.a.", Icon = "@drawable/ImagenSErv", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            LocalNotificationsImplementation.NotificationIconId = Resource.Drawable.ImagenSer;
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

        }


    }
}