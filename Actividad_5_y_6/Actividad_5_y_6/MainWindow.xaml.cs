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

namespace Actividad_5_y_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int fila;
        int columna;
        int cont = 1;

        public MainWindow()
        {
            InitializeComponent();
            int fila = 0;
            int columna = 0;
        }

        private void btnMas_Click(object sender, RoutedEventArgs e)
        {

            if (columna < 4)
            {
                columna++;
            }

            if(columna == 4)
            {
                fila++;
                columna = 0;
            }
            
            cont++;

            if(cont == 17)
            {

                MessageBoxResult result = MessageBox.Show("Quieres crear otro formulario?", "Los botoncitos", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show("Se ha creado un nuevo formulario", "Los botoncitos de los cojone");

                        MainWindow m = new MainWindow();
                        this.Hide();
                        m.Show();
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Que mal payaso con el trabajo que me ha costado poner los botoncitos", "Los botoncitos de los cojone");
                        this.Hide();
                        break;
 
                }

            }

            crearboton();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            

            for (int f = 0; f < 4; f++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int c = 0; c < 4; c++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            crearboton();
            

        }

        private void crearboton()
        {
            Button b = new Button();

            b.Name = "boton";
            b.Content = cont;
            b.Click += btnMas_Click;
            grid.Children.Add(b);
            Grid.SetRow(b, fila);
            Grid.SetColumn(b, columna);


        }
    }
}
