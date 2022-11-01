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
    public partial class PantClientes : Form
    {
        public PantClientes()
        {
            InitializeComponent();
        }

        private void PantClientes_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistencia = new Persistenciadedatos();
            instanciaPersistencia.InicializarArchivos();
            ClasePrincipal instanciaClasePrincipal = new ClasePrincipal();
            instanciaClasePrincipal.RellenarListas();

            dGVClientes.DataSource = instanciaClasePrincipal.ValidarCliente();

            AjustarDataGridView();


        }

        private void AjustarDataGridView() //Ajusta la grilla
        {
            var height = dGVClientes.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dGVClientes.Rows)
            {
                height += dr.Height;
            }
            dGVClientes.Height = height;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void btnAñadircliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantAñadirCli NuevaVentana = new PantAñadirCli();
            NuevaVentana.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //btnEliminar
        {
            BajaCliente NuevaVentana = new BajaCliente();
            NuevaVentana.Show();
            this.Close();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//btnModificar
        {
            PantModiCliente NuevaVentana = new PantModiCliente();
            NuevaVentana.Show();
            this.Close();

        }
    }
}
