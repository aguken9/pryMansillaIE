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
            // Obtener los valores ingresados por el usuario
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar el inicio de sesión (aquí puedes usar tus propios criterios)
            if (usuario == "usuario" && contraseña == "contraseña")
            {
                // Inicio de sesión exitoso, generar el informe
                GenerarInforme(usuario);
                MessageBox.Show("Inicio de sesión exitoso.");
            }
            else
            {
                // Inicio de sesión fallido, mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void GenerarInforme(string usuario)
        {
            // Crear un nombre de archivo único basado en el usuario
            string registroUsuarios = $"{usuario}_Informe.txt";

            // Crear o abrir un archivo de texto para escribir el informe
            using (StreamWriter writer = File.CreateText(registroUsuarios))
            {
                // Escribir los datos del usuario en el informe
                writer.WriteLine($"Usuario: {usuario}");
                writer.WriteLine($"Fecha y hora del inicio de sesión: {DateTime.Now}");
            }

            // Mostrar un mensaje de éxito
            MessageBox.Show("Informe generado con éxito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
