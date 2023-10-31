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

            if (txtUsuario.Text != "")
            {
                txtContraseña.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false;
            }

        }

        int intentos = 0;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           // Usuario objValidaUsuario = new Usuario();

            //objValidaUsuario.ConectarBD();
            //Realizar y Corregir lo de los parametros
            //objValidaUsuario.RegistrarLog();
            
            
            Usuario clsUsusario =new Usuario();

            //lblTitulo.Text = objValidaUsuario.estadoConexion;
            if (clsUsusario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
               // if (txtUsuario.Text == "agustin" && txtContraseña.Text == "123")
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
                MessageBox.Show("Datos de inicio de sesion incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;
                MessageBox.Show(intentos + " de 3 intentos posibles","Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtContraseña.Clear();


                if (intentos >= 3)
                {
                    MessageBox.Show("Ha superado el limite de los intentos, espere por favor " + (temporizador1.Interval / 1000) + " segundos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Enabled = false;
                    txtContraseña.Enabled = false;
                    btnIngresar.Enabled = false;

                    temporizador1.Tick += temporizador1_Tick;
                    temporizador1.Start();
                }
            }
        }

        private void temporizador1_Tick(object sender, EventArgs e)
        {
            // Habilitar el botón y detener el temporizador.
            intentos = 0;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            btnIngresar.Enabled = true;
            temporizador1.Stop();
        }

        private void lkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrarse frmRegistrarse = new frmRegistrarse();
            frmRegistrarse.Show();
            this.Hide();    
        }
    }
}
