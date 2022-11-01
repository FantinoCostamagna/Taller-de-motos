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
    public partial class ModificarVenta : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Ventas Modificacionventa = new Ventas();
        int idVenta;
        public ModificarVenta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            idVenta = int.Parse(txtBoxIDVenta.Text);

            Modificacionventa.ID_Venta = int.Parse(txtBoxIDVenta.Text);
            Modificacionventa.importeVenta = int.Parse(textBoxImporte.Text);
            Modificacionventa.fechaVenta = textBoxFechaVenta.Text;
            Modificacionventa.descripcionVenta = textBoxDescrVenta.Text;
            Modificacionventa.idComprador = int.Parse(textBoxIDComprador.Text);

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.Modificacionventas(Modificacionventa, idVenta);

            PantVentas NuevaVentana = new PantVentas();
            NuevaVentana.Show();
            this.Close();


        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantVentas NuevaVentana = new PantVentas();
            NuevaVentana.Show();
            this.Close();

        }
    }
}
