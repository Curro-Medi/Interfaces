using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refuerzo
{
    public partial class Form1 : Form
    {

        static bool sarandonga = true;
        List<String> versosperversos = new List<string>();
        List<String> listaperversa = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<String> listaperversa, List<String> versosperversos)
        {
            InitializeComponent();
            this.listaperversa = listaperversa;
            this.versosperversos = versosperversos;

            foreach (String g in listaperversa)
            {
                Lista.Items.Add(g);

            }

            foreach (String g in versosperversos)
            {
                Combobo.Items.Add(g);

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (sarandonga)
            {
                Lista.Items.Add(Textbo.Text);
                listaperversa.Add(Textbo.Text);
                Textbo.Clear();
                
            }
            else
            {
                Combobo.Items.Add(Textbo.Text);
                versosperversos.Add(Textbo.Text);
                Textbo.Clear();
                
            }

        }

        private void btnConmutar_Click(object sender, EventArgs e)
        {
            if (sarandonga)
            {
                sarandonga = false;
            }
            else
            {
                sarandonga = true;
            }

        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(listaperversa, versosperversos);
            f2.Show();
            this.Hide();
        }
    }
}
