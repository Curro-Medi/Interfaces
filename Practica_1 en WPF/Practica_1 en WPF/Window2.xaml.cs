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

namespace Practica_1_en_WPF
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<Persona> referenciaAListaPersonas;
        MainWindow mainWindow;

        public Window2()
        {
            InitializeComponent();
        }

        public Window2(List<Persona> lp, MainWindow mainWindow)
        {
            InitializeComponent();
            this.referenciaAListaPersonas = lp;
            this.mainWindow = mainWindow;

            dataGridView1.ItemsSource = referenciaAListaPersonas;
            textBox1.Text = "" + referenciaAListaPersonas.Count();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            mainWindow.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
