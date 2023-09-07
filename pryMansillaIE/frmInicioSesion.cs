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

            StreamWriter sw = new StreamWriter("logInicio", true);
            sw.WriteLine(txtUsuario.Text+ "- Fecha: " + DateTime.Now);
            sw.Close();

            UserName = txtUsuario.Text; // Asigna el nombre de usuario
            this.Hide(); // Oculta el formulario de inicio de sesión
            frmPrincipal menuForm = new frmPrincipal();
            menuForm.Show(); // Muestra el formulario de menú




            //  string usuario = txtUsuario.Text;
            // string contraseña = txtContraseña.Text;
            // if (usuario == "" && contraseña == "")
            // {
            //   GenerarInforme(usuario);
            // MessageBox.Show("Inicio de sesión exitoso.");
            // }
            //else
            {
                // Inicio de sesión fallido, mostrar un mensaje de error
              //  MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void GenerarInforme(string usuario)
        {
            string registroUsuarios = $"{usuario}_Informe.txt";
            using (StreamWriter writer = File.CreateText(registroUsuarios))
            {
                writer.WriteLine($"Usuario: {usuario}");
                writer.WriteLine($"Fecha y hora del inicio de sesión: {DateTime.Now}");
            }
            MessageBox.Show("Informe generado con éxito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
