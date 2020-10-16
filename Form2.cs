using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
   
    public partial class Form2 : Form
    {
        Form1 f1;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void tareaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tareaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet.tarea);

        }
        public Form2()
        {
            InitializeComponent();
        }



        private void agendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void agendaDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
