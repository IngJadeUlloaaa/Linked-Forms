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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float diurno = 8, nocturno = 15;

            double noc, diu, pagodiu, pagonoc, pagottl, desc;

            diu = Convert.ToInt32(textdiur.Text);
            noc = Convert.ToInt32(textnoct.Text);

            pagodiu = diu * diurno;
            pagonoc = noc * nocturno;
            pagottl = pagodiu + pagonoc;

            if(pagottl > 50) {
                desc = pagottl * 0.01;
                pagottl = pagottl - desc;
            }

            textpagodiur.Text = Convert.ToString(pagodiu);
            textpagonoct.Text = Convert.ToString(pagonoc);
            texttotal.Text = Convert.ToString(pagottl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textdiur.Clear();
            textnoct.Clear();
            textpagodiur.Clear();
            textpagonoct.Clear();
            texttotal.Clear();
            textdiur.Focus();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

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
