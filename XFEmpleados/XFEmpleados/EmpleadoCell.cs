using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFEmpleado;

namespace XFEmpleados
{
    class EmpleadoCell : ViewCell
    {
        public EmpleadoCell()
                        
            {




            var UsuarioLabel = new Label
            {
                
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            UsuarioLabel.SetBinding(Label.TextProperty, new Binding("Usuario"));

            var NombresLabel = new Label
            {
                Text = "Nombres: ",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            NombresLabel.SetBinding(Label.TextProperty, new Binding("Nombres"));

            var TelContacLabel = new Label
            {
                Text = "Contacto: ",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            TelContacLabel.SetBinding(Label.TextProperty, new Binding("TelContac"));

            var AutorizaLabel = new Label
            {
                Text = "Autoriza: ",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            AutorizaLabel.SetBinding(Label.TextProperty, new Binding("Autoriza"));



            var FechaDiaLabel = new Label
            {
                Text = "Fecha: ",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            FechaDiaLabel.SetBinding(Label.TextProperty, new Binding("FechaDia"));

            var Pregunta1Label = new Label
            {
                Text = "Respuesta: ",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            Pregunta1Label.SetBinding(Label.TextProperty, new Binding("Pregunta1"));

            var Pregunta2Label = new Label
            {
                Text = "Respuesta: ",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            Pregunta2Label.SetBinding(Label.TextProperty, new Binding("Pregunta2"));

            var TemperaturaLabel = new Label
            {
                Text = "Temperatura: ",
                TextColor = Color.Red,
                Font = Font.SystemFontOfSize(NamedSize.Medium),

                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            TemperaturaLabel.SetBinding(Label.TextProperty, new Binding("Temperatura"));

            var JornadaLabel = new Label
            {
                Text = "Jornada: ",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            JornadaLabel.SetBinding(Label.TextProperty, new Binding("Jornada")); ;

            

            var panel1 = new StackLayout
            {
                Children = { UsuarioLabel,NombresLabel, AutorizaLabel,TelContacLabel },
               
                Orientation = StackOrientation.Horizontal

                
            };

            var panel2 = new StackLayout
            {
                Children = { FechaDiaLabel, Pregunta1Label, Pregunta2Label, TemperaturaLabel, JornadaLabel },
                Orientation = StackOrientation.Horizontal,
                
                
                
            };
            

            View = new StackLayout
            {
                
                Children = { panel1,panel2},
                Orientation=StackOrientation.Vertical,
                BackgroundColor= Color.Transparent,
                VerticalOptions = LayoutOptions.FillAndExpand
   
            };


            

            
        }
    }
}
