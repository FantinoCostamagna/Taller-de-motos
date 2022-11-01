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
    public partial class PantAñadirArt : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Articulos NuevoArticulo = new Articulos();
        public PantAñadirArt()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NuevoArticulo = new Articulos();
            NuevoArticulo.ID_Articulo = int.Parse(txtboxIDART.Text);
            NuevoArticulo.descripcionArticulo = txtboxDescripcion.Text;
            NuevoArticulo.Tipo = txtboxTipo.Text;
            NuevoArticulo.Cantidad = int.Parse(txtboxCantidad.Text);
           

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.AltaArticulo(NuevoArticulo);

            Hide();
            PantStock NuevaPantalla = new PantStock();
            NuevaPantalla.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantStock NuevaPantalla = new PantStock();
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e) //btnCancelar
        {
            this.Close();
            PantStock NuevaPantalla = new PantStock();
            NuevaPantalla.Show();

        }
    }
}
