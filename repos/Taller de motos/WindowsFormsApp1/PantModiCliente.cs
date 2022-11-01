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
    public partial class PantModiCliente : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Cliente clienteModificado = new Cliente();
        int cliente;
        public PantModiCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cliente = int.Parse(textBoxIDcliente.Text);
            if (textBoxIDcliente.Text.Length > 1 && txtBoxNombreApellido.Text.Length > 5 && textBoxCorreo.Text.Length > 8 && textBoxDocumento.Text.Length > 6 && textBoxDireccion.Text.Length > 4 && textBoxFechaNac.Text.Length > 8 && textBoxTelefono.Text.Length > 8)
            {

            clienteModificado.Telefono = textBoxTelefono.Text;
            clienteModificado.Correo = textBoxCorreo.Text;
            clienteModificado.DNI = textBoxDocumento.Text;
            clienteModificado.Nombre = txtBoxNombreApellido.Text;
            clienteModificado.Direccion = textBoxDireccion.Text;
            clienteModificado.fechaNacimiento = textBoxFechaNac.Text;
            clienteModificado.ID_Cliente = int.Parse(textBoxIDcliente.Text);

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.ModificarCliente(clienteModificado, cliente);

            this.Close();
            PantClientes NuevaPantalla = new PantClientes();
            NuevaPantalla.Show();
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR LOS CAMPOS CORRECTAMENTE");
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantClientes NuevaPantalla = new PantClientes();
            NuevaPantalla.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantClientes NuevaPantalla = new PantClientes();
            NuevaPantalla.Show();
        }

        private void PantModiCliente_Load(object sender, EventArgs e)
        {
        }
    }
}
