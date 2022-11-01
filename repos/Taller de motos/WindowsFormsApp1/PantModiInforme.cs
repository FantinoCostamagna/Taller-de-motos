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
    public partial class PantModiInforme : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        informeReparaciones modiInforme = new informeReparaciones();
        int idInforme;
        public PantModiInforme()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            idInforme = int.Parse(txtboxIDInforme.Text);

            modiInforme.ID_Cliente = int.Parse(textBoxIDCliente.Text);
            modiInforme.ID_informeReparacion = int.Parse(txtboxIDInforme.Text);
            modiInforme.importeReparacion = int.Parse(txtboxImporte.Text);
            modiInforme.detalleReparacion = txtboxDetalle.Text;

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.ModificacioninformeReparaciones(modiInforme, idInforme);

            PantInformeRep NuevaVentana = new PantInformeRep();
            NuevaVentana.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantInformeRep NuevaVentana = new PantInformeRep();
            NuevaVentana.Show();
        }
    }
}
