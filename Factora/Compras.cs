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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
