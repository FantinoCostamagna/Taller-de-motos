using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //btnMaximizar
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
       
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e) //BOTON INFORMES REPARACIONES
        {
            PantInformeRep NuevaVentana = new PantInformeRep();
            NuevaVentana.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            PantClientes NuevaVentana = new PantClientes();
            NuevaVentana.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            PantStock NuevaVentana = new PantStock();
            NuevaVentana.Show();
        }


        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            PantVentas NuevaVentana = new PantVentas();
            NuevaVentana.Show();

        }

    }
}
