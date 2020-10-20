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

namespace Practica_1_en_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Persona> listapersonas = new List<Persona>();
        public MainWindow()
        {
            InitializeComponent();
            listapersonas.Add(new Persona("26366378E", "Pedro", "Ramirez", 150, 60, 15, "20/03/2019"));
            listapersonas.Add(new Persona("26364478S", "Roger", "Marti", 169, 140, 19, "10/11/2001"));
            listapersonas.Add(new Persona("", "Wissam", "Ben Yedder", 172, 70, 31, "10/11/1987"));
            listapersonas.Add(new Persona("98271939P", "Ansu", "Fati", 175, 50, 17, "10/11/2003"));
            listapersonas.Add(new Persona("82937467M", "", "Rakitic", 181, 80, 32, "10/11/1970"));
            listapersonas.Add(new Persona("88292287F", "Jules", "Kounde", 180, 80, 21, "10/11/1998"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Window1 w1 = new Window1(listapersonas, this);
            this.Hide();
            w1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2(listapersonas, this);
            this.Hide();
            w2.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3(listapersonas, this);
            this.Hide();
            w3.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4(listapersonas, this);
            this.Hide();
            w4.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window5 w5 = new Window5(listapersonas, this);
            this.Hide();
            w5.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
