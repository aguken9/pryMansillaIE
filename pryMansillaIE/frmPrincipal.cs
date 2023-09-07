using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMansillaIE
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProveedores formulario = new frmRegistroProveedores();
            formulario.Show();
            StreamWriter sw = new StreamWriter("logGeneral", true);
            sw.WriteLine("- Fecha: " + DateTime.Now + "- Ingreso a: " + GesProvRegistro.Text);
            sw.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void hora_Click(object sender, EventArgs e)
        {

        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // registro logs falta agregar el usuario
            frmProveedoresActivos formulario = new frmProveedoresActivos();
            formulario.Show();
            StreamWriter sw = new StreamWriter("logGeneral", true);
            sw.WriteLine( "- Fecha: " + DateTime.Now + "- Ingreso a: " + ListProvActivos.Text);
            sw.Close();
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
