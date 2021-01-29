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
    public partial class Devolver : Form
    {

        List<Cliente> Losclientes;
        List<Videojuego> Losvideojuegos;
        Form1 f1;
        Cliente clienteseleccionado;


        public Devolver(List<Cliente> clientes,List<Videojuego> videojuegos, Form1 f1)
        {
            InitializeComponent();
            Losclientes = clientes;
            Losvideojuegos = videojuegos;
            this.f1 = f1;
        }

        private void Devolver_Load(object sender, EventArgs e)
        {
            foreach (Cliente c in Losclientes)
            {
                ListaClientes.Items.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            clienteseleccionado = (Cliente)ListaClientes.SelectedItem;

            //Losvideojuegos.Add(clienteseleccionado.vid);


            clienteseleccionado.eliminarvideojuego();
            this.Hide();
            f1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
