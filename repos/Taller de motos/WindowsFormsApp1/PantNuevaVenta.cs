using Logica;
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
    public partial class PantNuevaVenta : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Ventas NuevaVenta = new Ventas();
        public PantNuevaVenta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NuevaVenta = new Ventas();
            NuevaVenta.idComprador = int.Parse(textBoxIDComprador.Text);
            NuevaVenta.ID_Venta = int.Parse(txtBoxIDVenta.Text);
            NuevaVenta.descripcionVenta = textBoxDescrVenta.Text;
            NuevaVenta.fechaVenta = textBoxFechaVenta.Text;
            NuevaVenta.importeVenta = int.Parse(textBoxImporte.Text);

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.Altaventas(NuevaVenta);

            Hide();
            PantVentas NuevaPantalla = new PantVentas();
            NuevaPantalla.Show();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantVentas NuevaVentana = new PantVentas();
            NuevaVentana.Show();

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantVentas NuevaVentana = new PantVentas();
            NuevaVentana.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
