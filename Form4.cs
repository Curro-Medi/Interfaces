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
    public partial class Form4 : Form
    {
        Form1 f1;
        int iragenda;
        

       /* SELECT tarea.id_agenda, tarea.dia, tarea.mes, tarea.hora, tarea.Descripcion, tarea.Lugar
FROM     tarea INNER JOIN
                  agenda ON agenda.id = tarea.id_agenda
WHERE  (agenda.id = @iragenda)
       */
        public Form4(int iragenda) 
        {
            InitializeComponent();
            this.iragenda = iragenda;

        }

        private void tareaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tareaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            try
            {
                this.tareaTableAdapter.TareasdeAgenda(this.miagendaDataSet.tarea, ((int)(System.Convert.ChangeType(iragenda, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tareaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tareaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void iragendaToolStripTextBox_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if(textBox1.Text != "" )
            {
                int diafiltrado = int.Parse(textBox1.Text);
                this.tareaTableAdapter.FillBy2(this.miagendaDataSet.tarea, iragenda, diafiltrado);
            }      

        }

    }
}
