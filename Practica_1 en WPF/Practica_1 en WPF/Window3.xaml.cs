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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private List<Persona> listapersonas;
        private MainWindow mainWindow;

        public Window3()
        {
            InitializeComponent();
        }

        public Window3(List<Persona> listapersonas, MainWindow mainWindow)
        {
            InitializeComponent();
            this.listapersonas = listapersonas;
            this.mainWindow = mainWindow;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Boolean encontrado = false;

            for (int i = 0; i < listapersonas.Count(); i++)
            {


                if (listapersonas[i].DNI1 == textbox1.Text)
                {
                    lista.Items.Add(listapersonas[i].ToString());
                    encontrado = true;
                }


            }
            if (encontrado == false)
            {
                MessageBox.Show("Persona no encontrada");
            }
            encontrado = false;
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            mainWindow.Show();
        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
