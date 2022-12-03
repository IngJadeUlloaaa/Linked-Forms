using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //enlazamos la tabla
            int table = tablegrid.Rows.Add();

            //ingresamos los datos
            tablegrid.Rows[table].Cells[0].Value = textid.Text;
            tablegrid.Rows[table].Cells[1].Value = textdes.Text;
            tablegrid.Rows[table].Cells[2].Value = textcan.Text;
            tablegrid.Rows[table].Cells[3].Value = textuni.Text;

            //limpieza de datos
            textid.Text = "";
            textdes.Text = "";
            textcan.Text = "";
            textuni.Text = "";
            textid.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tablegrid.Rows.Remove(tablegrid.CurrentRow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcConversionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Form2();
            formulario2.Show();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario4 = new Form4();
            formulario4.Show();

        }

        private void horasTrabajadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form formulario5 = new Form5();
            formulario5.Show();
        }

        private void menuRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario7 = new Form7();
            formulario7.Show();
        }

        private void horasLaboralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario8 = new Form8();
            formulario8.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form formulario6 = new Form6();
            formulario6.Show();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
