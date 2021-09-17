using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;



namespace XFEmpleado
{
    public class Empleado
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        public int IDEmpleado { get; set; }

        public string Usuario { get; set; }

        public string Nombres { get; set; }

        public Int64 TelContac { get; set; }

        public string Autoriza { get; set; }
        public string Motivo { get; set; }


        public String FechaDia { get; set; }
        public string Pregunta1 { get; set; }
        public string Pregunta2 { get; set; }

        public decimal Temperatura { get; set; }
        public String Jornada { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", "{1}", "{2}",ID, IDEmpleado, Usuario, Nombres,TelContac,Autoriza, FechaDia, Pregunta1, Pregunta2, Temperatura, Jornada);
        }


    }
}
