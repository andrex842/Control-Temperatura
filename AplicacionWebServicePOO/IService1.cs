using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AplicacionWebServicePOO
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        Empleado GetEmpleado(int IDEmpleado, long TelContac, decimal Temperatura, string Jornada, string Usuario, string Nombres, string Autoriza, string Motivo, string FechaDia, string Pregunta1, string Pregunta2);


    }

    
    
}
