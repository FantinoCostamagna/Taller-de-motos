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
    public partial class PantVentas : Form
    {
        public PantVentas()
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            
            PantNuevaVenta NuevaVentana = new PantNuevaVenta();
            NuevaVentana.Show();
            this.Close();
        }

        private void PantVentas_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistencia = new Persistenciadedatos();
            instanciaPersistencia.InicializarArchivos();
            ClasePrincipal instanciaClasePrincipal = new ClasePrincipal();
            instanciaClasePrincipal.RellenarListas();

            dGVVentas.DataSource = instanciaClasePrincipal.ValidarVentas();

            AjustarDataGridView();
        }
        private void AjustarDataGridView()
        {
            var height = dGVVentas.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dGVVentas.Rows)
            {
                height += dr.Height;
            }
            dGVVentas.Height = height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarVenta NuevaVentana = new ModificarVenta();
            NuevaVentana.Show();
        }
    }
}
