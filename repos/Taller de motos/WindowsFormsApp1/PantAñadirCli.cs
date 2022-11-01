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
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    public partial class PantAñadirCli : Form
    {
        Cliente nuevoCliente = new Cliente();
        ClasePrincipal principal = new ClasePrincipal();

        public PantAñadirCli()
        {
            InitializeComponent();
        }

        private void AñadirCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e) //boton aceptar
        {
            if (txtBoxNombreApellido.Text.Length > 5 && textBoxCorreo.Text.Length > 8 && textBoxDocumento.Text.Length > 6 && textBoxDireccion.Text.Length > 4 && textBoxFechaNac.Text.Length > 8 && textBoxTelefono.Text.Length > 8)
            { 

            nuevoCliente = new Cliente();
            nuevoCliente.Telefono = textBoxTelefono.Text;
            nuevoCliente.Correo = textBoxCorreo.Text;
            nuevoCliente.DNI = textBoxDocumento.Text;
            nuevoCliente.Nombre = txtBoxNombreApellido.Text;
            nuevoCliente.Direccion = textBoxDireccion.Text;
            nuevoCliente.fechaNacimiento = textBoxFechaNac.Text;
            nuevoCliente.ID_Cliente = int.Parse(textBoxIDcliente.Text);

            principal = new ClasePrincipal();
            principal.RellenarListas();
            principal.AltaCliente(nuevoCliente);

            Hide();
            PantClientes NuevaPantalla = new PantClientes();
            NuevaPantalla.Show();

            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR LOS CAMPOS CORRECTAMENTE");
            }
        }


        private void textBoxDocumento_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantClientes NuevaPantalla = new PantClientes();
            NuevaPantalla.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)//btnCerrar
        {
            this.Close();
            PantClientes NuevaPantalla = new PantClientes();
            NuevaPantalla.Show();
        }
    }
}




