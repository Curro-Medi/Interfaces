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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Persona> listapersonas;
        MainWindow mainWindow;
       

        public Window1(List<Persona> lp, Window1 w1)
        {
            InitializeComponent();
            listapersonas = lp;
            this.mainWindow = mainWindow;

        }

        public Window1(List<Persona> listapersonas, MainWindow mainWindow)
        {
            InitializeComponent();
            this.listapersonas = listapersonas;
            this.mainWindow = mainWindow;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean encontrado = false;
            int altura;
            int peso;
            int edad;

            for (int i = 0; i < listapersonas.Count(); i++)
            {

                if (textbox1.Text == listapersonas[i].DNI1)
                {
                    MessageBox.Show("ERROR, DNI REPETIDO");
                    mainWindow.Show();
                    this.Hide();
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                altura = int.Parse(textBox4.Text);
                peso = int.Parse(textBox5.Text);
                edad = int.Parse(textBox6.Text);

                listapersonas.Add(new Persona(textbox1.Text, textBox2.Text, textBox3.Text, altura, peso, edad, textBox7.Text));

                mainWindow.Show();
                this.Hide();
            }
        }
    }
}
