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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer01.Text = DateTime.Now.ToString("F");

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Inicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
        }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                cliente frm = new cliente();
                frm.MdiParent = this;
                frm.Show();
                
            }
        }
        }
    
           }
