using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RefuerzoWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static bool sarandonga = true;
        List<String> versosperversos = new List<string>();
        List<String> listaperversa = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(List<String> listaperversa, List<String> versosperversos)
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
        private void btnWPF2_Click(object sender, RoutedEventArgs e)
        {
            WPF2 f2 = new WPF2(listaperversa, versosperversos);
            f2.Show();
            this.Hide();
        }

        private void Textbo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
