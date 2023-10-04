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

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            // Asociar eventos a los controles relevantes
            txtNumero.TextChanged += HabilitarBotones;
            txtEntidad.TextChanged += HabilitarBotones;
            cmbJuzgado.SelectedIndexChanged += HabilitarBotones;
            cmbJurisdiccion.SelectedIndexChanged += HabilitarBotones;
            txtDireccion.TextChanged += HabilitarBotones;
            cmbLiquidador.SelectedIndexChanged += HabilitarBotones;
        }
        

        private void HabilitarBotones(object sender, EventArgs e)
        {
            bool numeroValido = !string.IsNullOrEmpty(txtNumero.Text);
            bool entidadValida = !string.IsNullOrEmpty(txtEntidad.Text);
            bool juzgadoSeleccionado = !string.IsNullOrEmpty(cmbJuzgado.Text);
            bool jurisdiccionSeleccionada = !string.IsNullOrEmpty(cmbJurisdiccion.Text);
            bool direccionValida = !string.IsNullOrEmpty(txtDireccion.Text);
            bool liquidadorSeleccionado = !string.IsNullOrEmpty(cmbLiquidador.Text);

            // Habilitar el botón Agregar y Eliminar si todas las condiciones se cumplen
            btnAgregar.Enabled = numeroValido && entidadValida && juzgadoSeleccionado && jurisdiccionSeleccionada && direccionValida && liquidadorSeleccionado;
            btnEliminar.Enabled = numeroValido && entidadValida && juzgadoSeleccionado && jurisdiccionSeleccionada && direccionValida && liquidadorSeleccionado;
            btnModificar.Enabled = numeroValido && entidadValida && juzgadoSeleccionado && jurisdiccionSeleccionada && direccionValida && liquidadorSeleccionado; 
        }



        private List<clsRegistro> registros = new List<clsRegistro>();
        string archivoProveedor = "../../Listado de aseguradores.csv";

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

            bool idRepetido = false;
            foreach (DataGridViewRow fila in grillaProveedores.Rows)
            {
                if (fila.Cells[0].Value != null && Convert.ToInt32(fila.Cells[0].Value) == numero)
                {
                    idRepetido = true;
                    break; // Salir del bucle si encuentra un ID repetido
                }
            }

            if (idRepetido)
            {
                MessageBox.Show("El número ya existe en la grilla. Ingrese un número diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // El ID no está repetido, agregar el nuevo registro
                clsRegistro nuevoRegistro = new clsRegistro { Numero = numero, Entidad = entidad, Apertura = apertura, Expediente = expediente, Juzgado = juzgado, Jurisdiccion = jurisdiccion, Direccion = direccion, LiquidadorResponsable = liquidador };
                registros.Add(nuevoRegistro);
                ActualizarArchivoCSV();
                CargarDatosEnGrilla();
                LimpiarCampos();
            }
        }

        private void CargarDatosEnGrilla()
        {
            foreach (var reg in registros)
            {
                grillaProveedores.Rows.Add(new object[] { reg.Numero, reg.Entidad, reg.Apertura, reg.Expediente, reg.Juzgado, reg.Jurisdiccion, reg.Direccion, reg.LiquidadorResponsable });
            }
            registros.Clear();
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
            if (grillaProveedores.SelectedRows.Count > 0)
            {
                int numeroRegistroAEliminar = grillaProveedores.SelectedRows[0].Index + 2; // Obtén el número de fila seleccionada

                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Elimina la fila del DataGridView
                    grillaProveedores.Rows.RemoveAt(grillaProveedores.SelectedRows[0].Index);

                    // Elimina la fila del archivo CSV
                    EliminarRegistroCSV(archivoProveedor, numeroRegistroAEliminar);
                    ActualizarArchivoCSV();
                    CargarDatosEnGrilla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        static void EliminarRegistroCSV(string filePath, int numeroRegistroAEliminar)
        {
            try
            {
                // Lee todo el contenido del archivo CSV
                string[] lineas = File.ReadAllLines(filePath);

                // Verifica que el número de registro a eliminar sea válido
                if (numeroRegistroAEliminar >= 1 && numeroRegistroAEliminar <= lineas.Length)
                {
                    // Crea un nuevo contenido sin el registro a eliminar
                    StringBuilder nuevoContenido = new StringBuilder();
                    for (int i = 0; i < lineas.Length; i++)
                    {
                        if (i + 1 != numeroRegistroAEliminar) // Omitir el registro que deseas eliminar
                        {
                            nuevoContenido.AppendLine(lineas[i]);
                        }
                    }

                    // Escribe el nuevo contenido en el archivo CSV
                    File.WriteAllText(filePath, nuevoContenido.ToString());

                    MessageBox.Show("Registro eliminado con éxito.");
                }
                else
                {
                    MessageBox.Show("Número de registro a eliminar no válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTodo()
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
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);
            string Entidad = txtEntidad.Text;
            string Expediente = mskExpediente.Text;
            string Juzgado = cmbJuzgado.Text;
            string Jurisdiccion = cmbJurisdiccion.Text;
            string Direccion = txtDireccion.Text;
            string Liquidador = cmbLiquidador.Text;
            DateTime fechaApertura = dtpApertura.Value;
            try
            {
                // Crear una lista para almacenar las líneas del archivo CSV
                List<string> lineas = new List<string>();
                // Agregar la primera línea con encabezados de columnas
                lineas.Add("Nº;Entidad;APERTURA;Nº EXPTE;JUZG.;JURISD;DIRECCION;LIQUIDADOR RESPONSABLE");
                // Variable para verificar si es la primera línea del archivo
                bool primerLinea = true;
                // Abrir el archivo CSV para lectura
                using (StreamReader lector = new StreamReader(archivoProveedor))
                {
                    string readLine;

                    // Leer el archivo línea por línea
                    while ((readLine = lector.ReadLine()) != null)
                    {
                        // Dividir la línea en elementos usando ';' como separador
                        string[] separador = readLine.Split(';');

                        // Verificar si hay al menos un elemento y si el primer elemento es un número válido
                        if (separador.Length > 0 && int.TryParse(separador[0], out int existingID))
                        {
                            // Comprobar si el número coincide con el valor de la variable "Numero"
                            if (existingID == Numero)
                            {
                                // Crear una nueva línea con los datos modificados
                                string nuevaLinea = $"{Numero};{Entidad};{fechaApertura};{Expediente};{Juzgado};{Jurisdiccion};{Direccion};{Liquidador}";

                                // Agregar la nueva línea a la lista
                                lineas.Add(nuevaLinea);
                            }
                            else
                            {
                                // Si el número no coincide, agregar la línea original sin modificaciones
                                lineas.Add(readLine);
                            }
                        }
                    }
                }
                // Escribir las líneas en el archivo original (sobreescribiendo el archivo)
                using (StreamWriter sw = new StreamWriter(archivoProveedor, false))
                {
                    foreach (string linea in lineas)
                    {
                        // Agregar la primera línea con los títulos de las columnas
                        if (primerLinea)
                        {
                            sw.WriteLine(linea);
                            primerLinea = false;
                        }
                        else
                        {
                            sw.WriteLine(linea);
                        }
                    }
                }
                // Mostrar un mensaje de éxito
                MessageBox.Show("Datos del Proveedor Nº " + Numero + " modificados correctamente.", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar y recargar los datos en la grilla de proveedores
                grillaProveedores.Rows.Clear();
                grillaProveedores.Columns.Clear();
                CargarTodo();
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar un mensaje de error
                MessageBox.Show("Error al modificar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

