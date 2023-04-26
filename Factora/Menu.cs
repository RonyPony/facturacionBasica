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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto frm = new Producto();
            frm.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesVer frm = new ClientesVer();
            frm.Show();
            this.Hide();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devoluciones frm = new Devoluciones();
            frm.Show();
            this.Hide();
        }

        private void gestionDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Factora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras frm = new Compras();
            frm.Show();
            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerVentas frm = new VerVentas();
            frm.Show();
            this.Hide();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario frm = new Inventario();
            frm.Show();
            this.Hide();
        }
    }
}
