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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            gbCalculo.Visible = false;
            Num1.Clear();
            Num2.Clear();
            Num1.Focus();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            double L = double.Parse(Num1.Text);
            double M = double.Parse(Num2.Text);

            double DT = L / M;

            if (DT < 1 && DT > 0)
            {
                gbCalculo.Visible = true;
                EficienciaDelsistema.Visible = true;
            }
            else
            {
                MessageBox.Show("Este Calculo esta saturando el programa");
            }
            double po = 1 - DT;
            double E = DT * 1;
            double L1 = DT / 1;
            double Pn = Math.Pow(DT, 2) * po;
            double Lq = Math.Pow(DT, 2) / (1 - DT);
            double Wq = DT / M * (1 - DT);
            double W = 1 / M * (1 - DT);

            txtE.Text = Convert.ToString(E);
            txtPn.Text = Convert.ToString(Pn);
            txtWq.Text = Convert.ToString(Wq);
            txtW.Text = Convert.ToString(W);
            txtLq.Text = Convert.ToString(Lq);
            txtPo.Text = Convert.ToString(po);
            txtL.Text = Convert.ToString(L1);
            txtE.Text = Convert.ToString(E);
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
