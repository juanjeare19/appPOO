using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente:Persona
    {
        //Atributos cliente
        private string categoria;
        private string codigo;
        private int descuento;

        //Propiedades
        public string Categoria { get => categoria; set => categoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Descuento { get => descuento; set => descuento = value; }

        //Metodos
        public void generarCodigo(string ape, string nom)
    {
            Codigo = "Cl" + ape.Substring(0,3) + nom.Substring(0,2) + "22";
        }
        public void calcularDescuento(string catCliente)
        {
            if (catCliente == "Normal")
            {
                Descuento = 0;
            }
            else if (catCliente == "Premium")
            {
                Descuento = 15;
            }
            else if (catCliente == "Premium VIP")
            {
                Descuento = 30;
            }

        }
        public override void accionPersona()
        {
            Accion = "Comprar";
        }
    }
}


