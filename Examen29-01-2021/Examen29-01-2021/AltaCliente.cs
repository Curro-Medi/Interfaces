using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen29_01_2021
{
    public partial class AltaCliente : Form
    {

        List<Cliente> Losclientes;
        Form1 f1;

        private String nombre;
        private String apellidos;
        private String dni;

        public AltaCliente(List<Cliente> clientes, Form1 f1)
        {
            InitializeComponent();

            Losclientes = clientes;
            this.f1 = f1;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Boolean encontrado = false;

            for (int i = 0; i < Losclientes.Count(); i++)
            {

                if (textBox3.Text == Losclientes[i].Dni)
                {
                    MessageBox.Show("ERROR, DNI REPETIDO");
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {

                Losclientes.Add(new Cliente(textBox1.Text, textBox2.Text, textBox3.Text, new List<Videojuego>()));
                f1.Show();
                this.Hide();
            }

        }
    }
}
