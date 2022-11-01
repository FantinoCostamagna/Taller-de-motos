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
    public partial class PantEliminarInforme : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        int idInforme;
        public PantEliminarInforme()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            idInforme = int.Parse(textBoxIDInforme.Text);
            principal.BajainformeReparaciones(idInforme);

            PantInformeRep NuevaVentana = new PantInformeRep();
            NuevaVentana.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantInformeRep NuevaVentana = new PantInformeRep();
            NuevaVentana.Show();
            this.Close();
        }
    }
}
