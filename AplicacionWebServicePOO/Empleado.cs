using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionWebServicePOO
{
   public class Empleado
    {
        

        public int IDEmpleado { get; set; }

        public string Usuario { get; set; }

        public string Nombres { get; set; }

        public long TelContac { get; set; }

        public string Autoriza { get; set; }
        public string Motivo { get; set; }


        public string FechaDia { get; set; }
        public string Pregunta1 { get; set; }
        public string Pregunta2 { get; set; }

        public decimal Temperatura { get; set; }
        public string Jornada { get; set; }
    }
}
