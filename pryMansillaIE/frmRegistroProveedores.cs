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

        private void frmRegistroProveedores_Load(object sender, EventArgs e)
        {

            string archivoProveedor = "Listado de aseguradores.csv";
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
    }
}
