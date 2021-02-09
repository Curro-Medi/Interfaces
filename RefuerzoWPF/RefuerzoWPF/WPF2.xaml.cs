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
using System.Windows.Shapes;

namespace RefuerzoWPF
{
    /// <summary>
    /// Lógica de interacción para WPF2.xaml
    /// </summary>
    public partial class WPF2 : Window
    {
        List<String> listaperversa;
        List<String> comboperverso;
        static bool sarandonga = true;

        public WPF2()
        {
            InitializeComponent();
        }

        public WPF2(List<String> listaperversa, List<String> comboperverso)
        {
            InitializeComponent();

            this.listaperversa = listaperversa;
            this.comboperverso = comboperverso;

            foreach (String g in listaperversa)
            {
                Lista2.Items.Add(g);

            }

            foreach (String g in comboperverso)
            {
                Combobo2.Items.Add(g);

            }
        }

        private void btnWPF1_Click(object sender, RoutedEventArgs e)
        {

            MainWindow f1 = new MainWindow(listaperversa, comboperverso);
            this.Hide();
            f1.Show();

        }

        private void btnAgregar2_Click(object sender, RoutedEventArgs e)
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

        private void btnConmutar2_Click(object sender, RoutedEventArgs e)
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
    }
}
