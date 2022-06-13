using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        //Atributos
        private string nombres;
        private string apellidos;
        private string documento;
        private string tipo;
        protected string accion;

        //Propiedades
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Accion { get => accion; set => accion = value; }

        public virtual void accionPersona()
        {
            Accion = "Accion";
        }
    }
}
