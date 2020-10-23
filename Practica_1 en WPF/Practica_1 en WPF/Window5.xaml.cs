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
    /// Lógica de interacción para Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private List<Persona> listapersonas;
        private MainWindow mainWindow;

        public Window5()
        {
            InitializeComponent();
        }

        public Window5(List<Persona> listapersonas, MainWindow mainWindow)
        {
            InitializeComponent();
            this.listapersonas = listapersonas;
            this.mainWindow = mainWindow;

            int cont = 0;


            for (int i = 0; i < listapersonas.Count(); i++)
            {
                if (listapersonas[i].Apellidos.Equals("") || listapersonas[i].Nombre.Equals("") ||
                    listapersonas[i].DNI1.Equals("") || listapersonas[i].Fecha_nac.Equals(""))
                {
                    cont = cont + 1;
                    lista.Items.Add(cont + ")  " + listapersonas[i]);
                }
            }

        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            mainWindow.Show();
        }
    }
}
