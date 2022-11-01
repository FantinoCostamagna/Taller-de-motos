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
    public partial class BajaProducto : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        int idproducto;
        public BajaProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            idproducto = int.Parse(textBoxIDProducto.Text);
            principal.Bajaarticulo(idproducto);

            PantStock NuevaVentana = new PantStock();
            NuevaVentana.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantVentas NuevaVentana = new PantVentas();
            NuevaVentana.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }
    }
}
