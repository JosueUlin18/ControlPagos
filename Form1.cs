using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPagos
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Propiedad> prop = new List<Propiedad>();
        List<PropiedadesClientes> PropiedadesToteles = new List<PropiedadesClientes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void btn_propetarioDatos_Click(object sender, EventArgs e)
        {
            Cliente clienteTemp = new Cliente();
            clienteTemp.Dpi = txt_dpi.Text;
            clienteTemp.Nombre = txt_nombre.Text;
            clienteTemp.Apellido = txt_apellido.Text;
            clientes.Add(clienteTemp);
            FileStream stream = new FileStream("personas.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var p in clientes)
            {
                writer.WriteLine(p.Dpi);
                writer.WriteLine(p.Nombre);
                writer.WriteLine(p.Apellido);
            }
            writer.Close();
            MessageBox.Show("Agregado correctamente"); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void controlPropiedades()
        {
            foreach(var x in prop)
            {
                foreach(var y in clientes)
                {
                    if(x.Dpi == y.Dpi)
                    {
                        PropiedadesClientes temp = new PropiedadesClientes();
                        temp.Dpi = txt_dpi.Text;
                        temp.Nombre = txt_nombre.Text;
                        temp.Apellido = txt_apellido.Text;
                        temp.Numero_casa = Convert.ToInt32(txt_numCasa.Text);
                        temp.Cuota = Convert.ToInt32(txt_cuota.Text);
                        PropiedadesToteles.Add(temp);
                    }
                }
            }
        }
        private void ingresarPropiedad()
        {
            Propiedad PropiedadTemp = new Propiedad();
            PropiedadTemp.Dpi = txt_dpiDue.Text;
            PropiedadTemp.Numero_casa = Convert.ToInt32(txt_numCasa.Text);
            PropiedadTemp.Cuota = Convert.ToInt32(txt_cuota.Text);
            prop.Add(PropiedadTemp);
            FileStream stream = new FileStream("Propiedades.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var p in prop)
            {
                writer.WriteLine(p.Dpi);
                writer.WriteLine(p.Cuota);
                writer.WriteLine(p.Numero_casa);
            }
            writer.Close();
            MessageBox.Show("Agregado correctamente");
        }
        private void btn_ingresarPropiedad_Click(object sender, EventArgs e)
        {
            ingresarPropiedad();
            controlPropiedades();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PropiedadesToteles;
            dataGridView1.Refresh();

        }
    }
}
