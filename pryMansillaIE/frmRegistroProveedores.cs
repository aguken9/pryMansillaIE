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
    public partial class frmRegistroProveedores : Form
    {
        public frmRegistroProveedores()
        {
            InitializeComponent();
        }

        private List<clsRegistro> registros = new List<clsRegistro>();
        string archivoProveedor = "Listado de aseguradores.csv";

        private void frmRegistroProveedores_Load(object sender, EventArgs e)
        {
           
            try
            {
                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');
                        foreach (string columna in separador)
                        {
                            grillaProveedores.Columns.Add(columna, columna);
                        }
                        HashSet<string> jurisdiccionesUnicas = new HashSet<string>();
                        HashSet<string> juzgadoUnico = new HashSet<string>();
                        HashSet<string> responsablesUnicos = new HashSet<string>();

                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            grillaProveedores.Rows.Add(separador);
                            juzgadoUnico.Add(separador[4]);
                            jurisdiccionesUnicas.Add(separador[5]);
                            responsablesUnicos.Add(separador[7]);
                        }

                        foreach (string jurisdiccion in jurisdiccionesUnicas)
                        {
                            cmbJurisdiccion.Items.Add(jurisdiccion);
                        }

                        foreach (string juzgado in juzgadoUnico)
                        {
                            cmbJuzgado.Items.Add(juzgado);
                        }

                        foreach (string responsable in responsablesUnicos)
                        {
                            cmbLiquidador.Items.Add(responsable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbJuzgado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grillaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text = grillaProveedores.CurrentRow.Cells[0].Value.ToString();
            txtEntidad.Text = grillaProveedores.CurrentRow.Cells[1].Value.ToString();
            dtpApertura.Text = grillaProveedores.CurrentRow.Cells[2].Value.ToString();
            mskExpediente.Text = grillaProveedores.CurrentRow.Cells[3].Value.ToString();
            cmbJuzgado.SelectedItem = grillaProveedores.CurrentRow.Cells[4].Value.ToString();
            cmbJurisdiccion.SelectedItem = grillaProveedores.CurrentRow.Cells[5].Value.ToString();
            txtDireccion.Text = grillaProveedores.CurrentRow.Cells[6].Value.ToString();
            cmbLiquidador.Text = grillaProveedores.CurrentRow.Cells[7].Value.ToString();
        }

        private void mskExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada si no es un número o una tecla de control (como Backspace)
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada si no es un número o una tecla de control (como Backspace)
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int numero = Convert.ToInt32(txtNumero.Text);
            string entidad = txtEntidad.Text;
            DateTime apertura = dtpApertura.Value;
            string expediente = mskExpediente.Text;
            string juzgado = cmbJuzgado.Text;
            string jurisdiccion = cmbJurisdiccion.Text;
            string direccion = txtDireccion.Text;
            string liquidador = cmbLiquidador.Text;

            //Crear un objeto Persona y agregarlo a la lista
            clsRegistro nuevoRegistro = new clsRegistro { Numero = numero, Entidad = entidad, Apertura = apertura, Expediente = expediente, Juzgado = juzgado, Jurisdiccion = jurisdiccion, Direccion = direccion, LiquidadorResponsable = liquidador };
            registros.Add(nuevoRegistro);
            //// Actualizar la lista en el archivo CSV
            ActualizarArchivoCSV();
            CargarDatosEnGrilla();
            LimpiarCampos();
        }

        private void CargarDatosEnGrilla()
        {
            foreach (var reg in registros)
            {
                grillaProveedores.Rows.Add(new object[] { reg.Numero, reg.Entidad, reg.Apertura, reg.Expediente, reg.Juzgado, reg.Jurisdiccion, reg.Direccion, reg.LiquidadorResponsable });
            }
        }


        private void LimpiarCampos()
        {
            txtNumero.Clear();
            txtEntidad.Clear();
            dtpApertura.Value = DateTime.Now; // Puedes establecer la fecha actual o cualquier otra fecha predeterminada
            mskExpediente.Clear();
            cmbJuzgado.SelectedIndex = -1; // Deseleccionar cualquier elemento seleccionado en el ComboBox
            cmbJurisdiccion.SelectedIndex = -1;
            txtDireccion.Clear();
            cmbLiquidador.SelectedIndex = -1;
        }

        private void ActualizarArchivoCSV()
        {
            try
            {
                // Abrir o crear el archivo CSV en modo escritura.
                using (StreamWriter sw = new StreamWriter(archivoProveedor, true))
                {
                    // Iterar a través de la lista de personas y escribir sus datos en el archivo CSV.
                    foreach (var reg in registros)
                    {
                        // Escribir los datos en formato CSV (separados por comas).
                        sw.WriteLine($"{reg.Numero};{reg.Entidad};{reg.Apertura};{reg.Expediente};{reg.Juzgado};{reg.Jurisdiccion};{reg.Direccion};{reg.LiquidadorResponsable}");
                    }
                }
                grillaProveedores.Refresh();

            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de que ocurra una excepción.
                MessageBox.Show("Error al escribir en el archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
  
        }
    }
}

