using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();

            var Empleado = servicio.GetEmpleado(12345679, 3112000000, 35, "Ingreso", "Empleado", "ANDRES AMADO REYES", null, null, "20/05/2000", "NO", "NO");

            lblIDEmpleado.Text = Empleado.IDEmpleado.ToString();
            lblTelContac.Text = Empleado.TelContac.ToString();
            lblTemperatura.Text = Empleado.Temperatura.ToString();
            lblJornada.Text = Empleado.Jornada;
            lblUsuario.Text = Empleado.Usuario;
            lblNombres.Text = Empleado.Nombres;
            lblAutoriza.Text = Empleado.Autoriza;
            lblMotivo.Text = Empleado.Autoriza;
            lblFechaDia.Text = Empleado.FechaDia;
            lblPregunta1.Text = Empleado.Pregunta1;
            lblPregunta2.Text = Empleado.Pregunta2;



        }
    }
}