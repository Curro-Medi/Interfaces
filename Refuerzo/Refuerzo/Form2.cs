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
    public partial class Form2 : Form
    {
        List<String> listaperversa;
        List<String> comboperverso;
        static bool sarandonga = true;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<String> listaperversa, List<String> comboperverso)
        {
            InitializeComponent();

            this.listaperversa = listaperversa;
            this.comboperverso = comboperverso;

            foreach(String g in listaperversa)
            {
                Lista2.Items.Add(g);

            }

            foreach (String g in comboperverso)
            {
                Combobo2.Items.Add(g);

            }
        }

        private void btnAgregar2_Click_1(object sender, EventArgs e)
        {
            if (sarandonga)
            {
                Lista2.Items.Add(Textbo2.Text);
                listaperversa.Add(Textbo2.Text);
                Textbo2.Clear();
            }
            else
            {
                Combobo2.Items.Add(Textbo2.Text);
                comboperverso.Add(Textbo2.Text);
                Textbo2.Clear();
            }
        }

        private void btnConmutar2_Click_1(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1(listaperversa, comboperverso);
            this.Hide();
            f1.Show();

        }
    }
}
