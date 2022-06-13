using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace appPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labCont.Visible = false;
            comboCont.Visible = false;
            labCat.Visible = false;
            comboCat.Visible = false;
            butGuardar.Visible = false;
            dataGridDatos.Visible = false;
            dataGridDatos2.Visible = false;

            dataGridDatos.ColumnCount = 8;

            dataGridDatos.Columns[0].Name = "Tipo";
            dataGridDatos.Columns[1].Name = "Apellidos";
            dataGridDatos.Columns[2].Name = "Nombres";
            dataGridDatos.Columns[3].Name = "Documento";
            dataGridDatos.Columns[4].Name = "Categoria";
            dataGridDatos.Columns[5].Name = "Codigo";
            dataGridDatos.Columns[6].Name = "Descuento";
            dataGridDatos.Columns[7].Name = "Accion";

            dataGridDatos2.ColumnCount = 7;

            dataGridDatos2.Columns[0].Name = "Tipo";
            dataGridDatos2.Columns[1].Name = "Apellidos";
            dataGridDatos2.Columns[2].Name = "Nombres";
            dataGridDatos2.Columns[3].Name = "Documento";
            dataGridDatos2.Columns[4].Name = "Contrato";
            dataGridDatos2.Columns[5].Name = "Sueldo";
            dataGridDatos2.Columns[6].Name = "Accion";
        }
    private void butGuardar_Click(object sender, EventArgs e)
        {
            Persona rol = new Persona();
            Empleado rol2 = new Empleado();
            Cliente rol3 = new Cliente();
            rol.Tipo = comboTip.Text;
            rol.Apellidos = textApe.Text;
            rol.Nombres = textNom.Text;
            rol.Documento = textDoc.Text;
            rol2.TipoContrato = comboCont.Text;
            rol3.Categoria = comboCat.Text;

            if (comboTip.Text == "Cliente" && comboCat.Text != "")
            {
                Cliente polimorfismo = new Cliente();
                rol3.calcularDescuento(comboCat.Text);
                rol3.generarCodigo(textApe.Text, textNom.Text);
                polimorfismo.accionPersona();
                dataGridDatos.Rows.Insert(0, rol.Tipo, rol.Apellidos, rol.Nombres, rol.Documento, rol3.Categoria, rol3.Codigo, rol3.Descuento+"%", polimorfismo.Accion);
            }
            else if (comboTip.Text == "Empleado" && comboCont.Text != "")
            {
                Empleado polimorfismo = new Empleado();
                rol2.calcularSueldo(7000);
                polimorfismo.accionPersona();
                dataGridDatos2.Rows.Insert(0, rol.Tipo, rol.Apellidos, rol.Nombres, rol.Documento, rol2.TipoContrato, rol2.Sueldo,polimorfismo.Accion);

            }else{
                MessageBox.Show("Elija bien las opciones de los combo box");
            }

        }
        private void comboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTip.Text == "Empleado")
            {
                labCont.Visible = true;
                comboCont.Visible = true;
                labCat.Visible = false;
                comboCat.Visible = false;
                dataGridDatos2.Visible = true;
                dataGridDatos.Visible = false;
            }
            if (comboTip.Text == "Cliente")
            {
                labCat.Visible = true;
                comboCat.Visible = true;
                labCont.Visible = false;
                comboCont.Visible = false;
                dataGridDatos2.Visible = false;
                dataGridDatos.Visible = true;
            }
        }
        private void butLimpiar_Click(object sender, EventArgs e)
        {
            textApe.Text = "";
            textNom.Text = "";
            textDoc.Text = "";
            comboCat.Text = "";
            comboCont.Text = "";
            comboTip.Text = "";
        }
        private void textNom_TextChanged(object sender, EventArgs e) 
        {
            if(textNom.Text.Length < 3)
            {
                butGuardar.Visible = false;
                textNom.BackColor = Color.Red;
            }else{
                textNom.BackColor = Color.White;
            }
            if (textApe.Text.Length >= 3 && textNom.Text.Length >= 3)
            {
                butGuardar.Visible = true;
            }
        }
        private void textApe_TextChanged(object sender, EventArgs e)
        {
            if (textApe.Text.Length < 3)
            {
                butGuardar.Visible = false;
                textApe.BackColor = Color.Red;
            }
            else
            {
                textApe.BackColor = Color.White;
            }
            if(textApe.Text.Length >= 3 && textNom.Text.Length >= 3)
            {
                butGuardar.Visible = true;
            }
        }
    }
}