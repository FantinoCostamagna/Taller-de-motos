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
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool validarUsuario(string nombre, string clave)
        {
           
            return (nombre == "1") && (clave == "1");


        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            if (textBox1.TextLength < 0)
                MessageBox.Show("Debe ingresar caracteres"); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PantallaLogin_Load(object sender, EventArgs e) 
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
               
                if (validarUsuario(textBox1.Text.Trim(), textBox2.Text.Trim()))
                {
                    this.Hide();

                    PantallaCargaInicio NuevaPantalla = new PantallaCargaInicio();

                    NuevaPantalla.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Usuario");
            }
        


        }

        private void textBox2_TextChanged(object sender, EventArgs e) //TEXTO CONTRASEÑA
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnES_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }
    }

    
}
