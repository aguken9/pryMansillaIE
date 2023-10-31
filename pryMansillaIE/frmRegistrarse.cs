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
using System.Data.SqlClient;
using System.Data.OleDb;

namespace pryMansillaIE
{
    public partial class frmRegistrarse : Form
    {
        private Bitmap signatureBitmap;
        public frmRegistrarse()
        {
            InitializeComponent();
            signatureBitmap = new Bitmap(pbFirma.Width, pbFirma.Height);
            btnRegistrar.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Asegurarse de que se hayan proporcionado un nombre y una contraseña
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un nombre y una contraseña.");
                return;
            }

            // Convertir la firma en un arreglo de bytes (PNG)
            byte[] firmaData;
            using (MemoryStream ms = new MemoryStream())
            {
                pbFirma.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                firmaData = ms.ToArray();
            }

            clsRegistroUsuario registroUsuario = new clsRegistroUsuario(); // Instancia de la clase clsRegistroU
            bool registroExitoso = registroUsuario.InsertarUsuario(nombre, contraseña, firmaData);

            if (registroExitoso)
            {
                MessageBox.Show("Registro exitoso.");
                LimpiarFormulario();

                // Recargar los nombres de usuario en el ComboBox
                registroUsuario.CargarNombresDeUsuariosEnComboBox(cmbUsuarios);

            }
            else
            {
                MessageBox.Show("Error al registrar.");
            }
        }


        private bool isDrawing = false;
        private Point previousPoint;
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(signatureBitmap))
                {
                    g.DrawLine(new Pen(Color.Black, 2), previousPoint, e.Location);
                    previousPoint = e.Location;
                    pbFirma.Image = signatureBitmap;
                }
            }
        }

        private void pbFirma_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void LimpiarFormulario()
        {
            // Limpia los campos del formulario y el PictureBox
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            pbFirma.Image = new Bitmap(pbFirma.Width, pbFirma.Height);
        }

        private void frmRegistrarse_Load(object sender, EventArgs e)
        {
            clsRegistroUsuario registroUsuario = new clsRegistroUsuario(); // Instancia de la clase clsRegistroUsuario.
            registroUsuario.CargarNombresDeUsuariosEnComboBox(cmbUsuarios);
        }

        private void pbFirma_Paint(object sender, PaintEventArgs e)
        {
            if (pbFirma.Image != null)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem != null)
            {
                string nombreUsuario = cmbUsuarios.SelectedItem.ToString();

                // Utiliza el método ObtenerFirmaDeUsuario de clsRegistroUsuario
                // para obtener la firma del usuario seleccionado.
                clsRegistroUsuario registroUsuario = new clsRegistroUsuario();
                byte[] firmaData = registroUsuario.ObtenerFirmaDeUsuario(nombreUsuario);

                if (firmaData != null)
                {
                    // Convierte los datos binarios en una imagen y muestra la firma en el PictureBox.
                    using (MemoryStream ms = new MemoryStream(firmaData))
                    {
                        Image firmaImage = Image.FromStream(ms);
                        pictureBox1.Image = firmaImage;
                    }
                }
                else
                {
                    // Maneja el caso en el que no se encuentre una firma.
                    MessageBox.Show("No se encontró una firma para el usuario seleccionado.");
                }
            }
        }
    }
}
