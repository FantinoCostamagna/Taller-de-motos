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
    public partial class PantModiArt : Form
    {
        Articulos Articulomodificado = new Articulos();
        ClasePrincipal principal = new ClasePrincipal();
        int idproducto;
        public PantModiArt()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantStock NuevaVentana = new PantStock();
            NuevaVentana.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            idproducto = int.Parse(txtboxIDART.Text);

            Articulomodificado.Cantidad = int.Parse(txtboxCantidad.Text);
            Articulomodificado.ID_Articulo = int.Parse(txtboxIDART.Text);
            Articulomodificado.Tipo = txtboxTipo.Text;
            Articulomodificado.descripcionArticulo = txtboxDescripcion.Text;

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.ModificacionArticulo(Articulomodificado, idproducto);

            PantStock NuevaVentana = new PantStock();
            NuevaVentana.Show();
            this.Close();
        }
    }
}
