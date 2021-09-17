using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using XFEmpleado;
using System.IO;
using Android.Database.Sqlite;

namespace XFEmpleados
{
    class DataAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB, "Empleado.sqlite"));
            connection.CreateTable<Empleado>();
            
        }
        public void InsertEmpleado(Empleado empleado)
        {
            connection.Insert(empleado);

        }
        public void UpdateEmpleado(Empleado empleado)
        {
            connection.Update(empleado);
        }
        public void DeleteEmpleado(Empleado empleado)
        {
            connection.Delete(empleado);
        }
             

        public Empleado GetEmpleado(int IDEmpleado)
        {
            return connection.Table<Empleado>().FirstOrDefault();
        }

        public List<Empleado> GetEmpleado()
        {
            return connection.Table<Empleado>().OrderBy(c => c.FechaDia).ToList();
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
