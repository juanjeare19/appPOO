using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado:Persona
    {
        //Atributos Empleado
        private string tipoContrato;
        private double sueldo;

        //Propiedades
        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        //Metodos
        public void calcularSueldo(double sueldoBase)
        {
            if(TipoContrato == "Junior")
            {
                Sueldo = sueldoBase + 3000;
            }
            else if (TipoContrato == "Medium")
            {
                Sueldo = sueldoBase + 13000;
            }
            else if (TipoContrato == "Senior")
            {
                Sueldo = sueldoBase + 23000;
            }
        }
        public override void accionPersona()
        {
            Accion = "Vender";
        }
    }
}
