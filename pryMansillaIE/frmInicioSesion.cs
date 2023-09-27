using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMansillaIE
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        public string UserName { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "agustin" && txtContraseña.Text == "123")
            {
                StreamWriter sw = new StreamWriter("logInicio", true);
                sw.WriteLine(txtUsuario.Text + "- Fecha: " + DateTime.Now);
                sw.Close();
                Usuario usuario = new Usuario();
                usuario.Nombre = txtUsuario.Text;
                frmPrincipal principalForm = new frmPrincipal(usuario);
                principalForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos de inicio de sesion incorrectos");
            }
        }
    }
}
