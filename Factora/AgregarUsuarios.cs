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
    public partial class AgregarUsuarios : Form
    {
        public AgregarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
            this.Hide();
        }
    }
}
