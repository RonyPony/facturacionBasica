using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factora
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Admin" && txtPass.Text == "1111")
            {
                Inicio frm = new Inicio();
                frm.Show();
                this.Hide();
            }
            else if (txtUser.Text != "Admin" && txtPass.Text == "1111")
            {
                MessageBox.Show("Usuario Incorrecto", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtUser.Text == "Admin" && txtPass.Text != "1111")
            {
                MessageBox.Show("Clave Incorrecto", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtUser.Text != "Admin" && txtPass.Text != "1111")
            {
                MessageBox.Show("Usuario y Clave Incorrectos", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Factora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
