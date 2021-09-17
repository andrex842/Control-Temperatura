using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AplicacionWebServicePOO
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        

        public Empleado GetEmpleado(int IDEmpleado, long TelContac, decimal Temperatura, string Jornada, string Usuario, string Nombres, string Autoriza, string Motivo, string FechaDia, string Pregunta1, string Pregunta2)
        {
            Empleado Empleado1 = new Empleado();
            Empleado1.IDEmpleado = IDEmpleado;
            Empleado1.Usuario = Usuario;
            Empleado1.Nombres = Nombres;
            Empleado1.TelContac = TelContac;
            Empleado1.Autoriza = Autoriza;
            Empleado1.Motivo = Motivo;
            Empleado1.FechaDia = FechaDia;
            Empleado1.Pregunta1 = Pregunta1;
            Empleado1.Pregunta2 = Pregunta2;
            Empleado1.Temperatura = Temperatura;
            Empleado1.Jornada = Jornada;

            return Empleado1;
        }
    }
}
