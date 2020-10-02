using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV_Cloud
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void Ocultartodo()
        {
            Btn1.Visible = false;
            Btn2.Visible = false;
            Btn3.Visible = false;
        }
        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil objPerfil = new Perfil();
            objPerfil.Show();
            this.Close();
        }

        private void tiketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MVenta_Click(object sender, EventArgs e)
        {

        }

        private void salidaYEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masEspacioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void servidorPropioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MSalir_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.Show();
            this.Close();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            Ocultartodo();
            Btn1.Text = "Perfil";
            Btn1.Visible = true;
            Btn2.Text = "Tickets";
            Btn2.Visible = true;
            Btn3.Text = "Cajas";
            Btn3.Visible = true;
        }

        private void BtnCatalogos_Click(object sender, EventArgs e)
        {
            Ocultartodo();
            Btn1.Text = "Marcas";
            Btn1.Visible = true;
            Btn2.Text = "Almacen";
            Btn2.Visible = true;
            Btn3.Text = "Inventario";
            Btn3.Visible = true;
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            Ocultartodo();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Ocultartodo();
            Btn1.Text = "Salida y entradas";
            Btn1.Visible = true;
            Btn2.Text = "Ventas";
            Btn2.Visible = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.Show();
            this.Close();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {

        }

        private void Btn3_Click(object sender, EventArgs e)
        {

        }
    }
}
