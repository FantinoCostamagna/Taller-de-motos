using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PantallaCargaInicio : Form
    {
        public PantallaCargaInicio()
        {
            InitializeComponent();
            timer1.Start();         
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void PantallaCargaInicio_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                MenuPrincipal NuevaVentana = new MenuPrincipal();
                NuevaVentana.Show();
            }
            else
            {
                progressBar1.Increment(2);
            }
        }
    }
}
