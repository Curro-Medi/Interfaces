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
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private List<Persona> listapersonas;
        private MainWindow mainWindow;

        public Window4()
        {
            InitializeComponent();
        }

        public Window4(List<Persona> listapersonas, MainWindow mainWindow)
        {
            InitializeComponent();
            this.listapersonas = listapersonas;
            this.mainWindow = mainWindow;

            Boolean salir = false;
            int cont = 0; //para controlar que si hay mas de 3 con la misma longitud del nombre se acabe 
            int cont1 = 0; //controla el paso en el primer if del nombre mas largo
            int cont2 = 0;  //controla el segundo npmbre mas largo
            int cont3 = 0;  //controla el tercer nombre mas largo

            List<string> personas = new List<string>();

            foreach (Persona person in listapersonas)
            {

                if (person.Nombre.Length >= cont1)
                {
                    cont1 = person.Nombre.Length;

                    personas.Add(person.Nombre);
                    cont = cont + 1;
                }

                if (cont == 3)
                {

                    salir = true;
                }
                if (salir == true)
                {

                }else{

                    if (person.Nombre.Length >= cont2 && person.Nombre.Length != cont1)
                    {
                        cont2 = person.Nombre.Length;

                        personas.Add(person.Nombre);

                        cont = cont + 1;
                    }

                    if (cont == 3)
                    {

                        break;
                    }

                    else
                    {

                        if (person.Nombre.Length >= cont3 && person.Nombre.Length != cont1 && person.Nombre.Length != cont2)
                        {
                            cont3 = person.Nombre.Length;

                            personas.Add(person.Nombre);
                        }
                    }

                }

            }

            lista.Items.Add(personas);

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
