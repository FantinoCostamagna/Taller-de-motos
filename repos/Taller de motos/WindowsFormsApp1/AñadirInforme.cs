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
    public partial class AñadirInforme : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        informeReparaciones NuevoInforme = new informeReparaciones();
        public AñadirInforme()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NuevoInforme = new informeReparaciones();
            NuevoInforme.ID_Cliente = int.Parse(textBoxIDCliente.Text);
            NuevoInforme.ID_informeReparacion = int.Parse(txtboxIDInforme.Text);
            NuevoInforme.detalleReparacion = txtboxDetalle.Text;
            NuevoInforme.importeReparacion = int.Parse(txtboxImporte.Text);
      

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.AltainformeReparaciones(NuevoInforme);

            Hide();
            PantInformeRep NuevaPantalla = new PantInformeRep();
            NuevaPantalla.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantInformeRep NuevaPantalla = new PantInformeRep();
            NuevaPantalla.Show();
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantInformeRep NuevaPantalla = new PantInformeRep();
            NuevaPantalla.Show();
        }
    }
}
