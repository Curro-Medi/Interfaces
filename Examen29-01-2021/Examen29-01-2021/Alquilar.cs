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
    public partial class Alquilar : Form
    {

        List<Cliente> Losclientes;
        List<Videojuego> Losvideojuegos;
        Form1 f1;


        public Alquilar(List<Cliente> clientes, List<Videojuego> videojuegos, Form1 f1)
        {
            InitializeComponent();
            Losclientes = clientes;
            Losvideojuegos = videojuegos;
            this.f1 = f1;

        }

        private void Alquilar_Load(object sender, EventArgs e)
        {
            foreach (Videojuego v in Losvideojuegos)
            {
                ListaVideojuegos.Items.Add(v);
            }

            foreach(Cliente c in Losclientes)
            {
                ListaClientes.Items.Add(c);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach(Cliente c in Losclientes)
            {
                if(c == ListaClientes.SelectedItem)
                {
                    Videojuego vid = new Videojuego((Videojuego)ListaVideojuegos.SelectedItem);
                    c.addvideojuego(vid);
                }
            }

            Losvideojuegos.Remove((Videojuego) ListaVideojuegos.SelectedItem);

            ListaClientes.Refresh();
            ListaVideojuegos.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
