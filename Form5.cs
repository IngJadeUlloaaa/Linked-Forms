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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we declare variables
            int dias, pagos, salario_bruto;
            double bonificacion, salario_neto;
            bool hijos;
            //read data
            dias = Convert.ToInt32(textday.Text);
            pagos = Convert.ToInt32(textdaysalary.Text);
            hijos = Convert.ToBoolean(checkson.Checked);

            salario_bruto = dias * pagos;

            //condictionals
            if (salario_bruto < 1000)
            {

                bonificacion = Convert.ToDouble(salario_bruto * 0.1);
            }
            else
            {

                if (salario_bruto >= 1000 && salario_bruto <= 2500)
                {

                    bonificacion = Convert.ToDouble(salario_bruto * 0.2);
                }
                else
                {

                    bonificacion = Convert.ToDouble(salario_bruto * 0.25);
                }
            }

            //second condictional
            if (hijos == true)
            {

                bonificacion = bonificacion * 2;
            }

            salario_neto = Convert.ToDouble(salario_bruto + bonificacion);

            textgrosssalary.Text = Convert.ToString(salario_bruto);
            textbonus.Text = Convert.ToString(bonificacion);
            textnetsalary.Text = Convert.ToString(salario_neto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear
            textdaysalary.Clear();
            textday.Clear();
            textgrosssalary.Clear();
            textbonus.Clear();
            textnetsalary.Clear();

            //focus
            textday.Focus();
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
