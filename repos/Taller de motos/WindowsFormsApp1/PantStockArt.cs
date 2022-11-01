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
    public partial class PantStock : Form
    {
        public PantStock()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

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


        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void PantStock_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistencia = new Persistenciadedatos();
            instanciaPersistencia.InicializarArchivos();
            ClasePrincipal instanciaClasePrincipal = new ClasePrincipal();
            instanciaClasePrincipal.RellenarListas();

            dGVArticulos.DataSource = instanciaClasePrincipal.ValidarArticulos();

            AjustarDataGridView();
        }

      
        private void AjustarDataGridView()
        {
            var height = dGVArticulos.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dGVArticulos.Rows)
            {
                height += dr.Height;
            }
            dGVArticulos.Height = height;
        }

        private void btnAñadircliente_Click(object sender, EventArgs e)
        {
            this.Close();
            PantAñadirArt NuevaVentana = new PantAñadirArt();
            NuevaVentana.Show();
        }

        private void dGVArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//btnEliminar
        {
            BajaProducto NuevaVentana = new BajaProducto();
            NuevaVentana.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//btnModificar
        {
            PantModiArt NuevaVentana = new PantModiArt();
            NuevaVentana.Show();
        }
    }
}
