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
    public partial class Form3 : Form
    {
        Form1 f1;
        int iragenda;
        public Form3(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);
           
        }


        public Form3()
        {
            InitializeComponent();
            
            this.iragenda = iragenda;

        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet);

        }

        private void agendaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            iragenda = (int)agendaDataGridView.Rows[e.RowIndex].Cells[0].Value;
            Form4 f4 = new Form4(iragenda);
            this.Hide();
            f4.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
