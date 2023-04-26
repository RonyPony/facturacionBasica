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
    public partial class ClientesVer : Form
    {
        public ClientesVer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente frm = new cliente();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }
    }
}
