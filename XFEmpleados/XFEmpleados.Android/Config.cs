﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Interop;
using Xamarin.Forms;
using XFEmpleado;

[assembly: Dependency(typeof(XFEmpleados.Droid.Config))]

namespace XFEmpleados.Droid
{
    public class Config : IConfig
    {
        public string directorioDB;
        public ISQLitePlatform plataforma;


        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    directorioDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return directorioDB;
            }

        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (plataforma == null)
                { 
                plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
            return plataforma;
            }
            
        }
    }
}