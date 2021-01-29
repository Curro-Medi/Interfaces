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

namespace Examen29_01_2021
{
    public partial class Form1 : Form
    {

        List<Videojuego> videojuegos = new List<Videojuego>();
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {

            String Directorio = Directory.GetCurrentDirectory();
            
            HelpProvider ayuda = new HelpProvider();
            //ayuda.HelpNamespace = @"C:/Users/Curro/source/repos/Examen29-01-2021/ayuda/Examen.chm";
            ayuda.HelpNamespace = @Directorio+"/Examen.chm";
            ayuda.SetShowHelp(this, true);

            InitializeComponent();
            videojuegos.Add(new Videojuego(1, "Assassins creed Valhala", "Accion"));
            videojuegos.Add(new Videojuego(2, "Zelda Breath of the Wild", "Aventura"));
            videojuegos.Add(new Videojuego(3, "Spiderman", "Accion"));
            videojuegos.Add(new Videojuego(4, "The forest", "Terror"));
            videojuegos.Add(new Videojuego(5, "Fifa 21", "Simulacion"));
            videojuegos.Add(new Videojuego(6, "Pokemon oro", "Simulacion"));

        }

        private void alquilar_Click(object sender, EventArgs e)
        {
            Alquilar alquilar = new Alquilar(clientes, videojuegos, this);
            this.Hide();
            alquilar.Show();
        }

        private void alta_Click(object sender, EventArgs e)
        {
            AltaCliente AC = new AltaCliente(clientes, this);
            this.Hide();
            AC.Show();

        }

        private void devolver_Click(object sender, EventArgs e)
        {
            Devolver devolver = new Devolver(clientes,videojuegos, this);
            this.Hide();
            devolver.Show();
        }
    }
}
