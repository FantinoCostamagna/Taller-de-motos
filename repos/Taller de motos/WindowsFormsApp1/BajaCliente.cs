using System;
using Logica;
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
    public partial class BajaCliente : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        int cliente;

        public BajaCliente()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cliente = int.Parse(textBoxIDCliente.Text);
            principal.BajaCliente(cliente);

            PantClientes NuevaVentana = new PantClientes();
            NuevaVentana.Show();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            PantClientes NuevaVentana = new PantClientes();
            NuevaVentana.Show();
        }

        private void textBoxIDCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            PantClientes NuevaVentana = new PantClientes();
            NuevaVentana.Show();
        }
    }
}
