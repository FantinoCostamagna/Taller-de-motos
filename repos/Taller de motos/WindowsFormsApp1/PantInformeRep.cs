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
    public partial class PantInformeRep : Form
    {
        public PantInformeRep()
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


        private void btnAñadirinforme_Click(object sender, EventArgs e)
        {
            this.Hide();
            AñadirInforme NuevaVentana = new AñadirInforme();
            NuevaVentana.Show();
        }

        private void PantInformeRep_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistencia = new Persistenciadedatos();
            instanciaPersistencia.InicializarArchivos();
            ClasePrincipal instanciaClasePrincipal = new ClasePrincipal();
            instanciaClasePrincipal.RellenarListas();

            dGVInforme.DataSource = instanciaClasePrincipal.ValidarinformeReparaciones();

            AjustarDataGridView();
        }

        private void AjustarDataGridView()
        {
            var height = dGVInforme.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dGVInforme.Rows)
            {
                height += dr.Height;
            }
            dGVInforme.Height = height;
        }

        private void button3_Click(object sender, EventArgs e)//btnEliminar
        {
            PantEliminarInforme NuevaVentana = new PantEliminarInforme();
            NuevaVentana.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//btnModificacion
        {
            PantModiInforme NuevaVentana = new PantModiInforme();
            NuevaVentana.Show();
            this.Close();
        }
    }
}
