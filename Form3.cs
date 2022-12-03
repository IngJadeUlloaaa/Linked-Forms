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
    public partial class Formlogin : Form
    {
        String Usuario = "Admin";
        String Contraseña = "Admin12345";
        public Formlogin()
        {
            InitializeComponent();
        }
        int intento = 1;

        private void Sesion_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == Usuario && txtcontra.Text == Contraseña)
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                //mandaremos un mensaje 
                MessageBox.Show("usuario incorrecto " + intento + "sale al 3er intento");
                intento++;
                txtusuario.Clear();
                txtcontra.Clear();
            }
            if (intento == 4)
            {
                MessageBox.Show(" Usted ya realizo el maximo numero de intento");
                Application.Exit();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    
    }
}
