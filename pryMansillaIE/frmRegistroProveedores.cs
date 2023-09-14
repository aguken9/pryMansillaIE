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
            //Traer  todos los proveedores registrados.

            StreamReader lectorArchivo = new StreamReader("listadoProveedores.csv");
            bool eslaprimerafila = true;
            string leerElRenglon = "";
            string [] separarDatos;
            
            while (!lectorArchivo.EndOfStream)
            {
                leerElRenglon = lectorArchivo.ReadLine();
                separarDatos = leerElRenglon.Split(';');

                if(eslaprimerafila == true)
                {
                    for(int indice = 0; indice < separarDatos.Length; indice++)
                    {
                        grillaProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                    }
                    eslaprimerafila = false;
                }
                else
                {
                    grillaProveedores.Rows.Add(separarDatos);
                }
            }
            lectorArchivo.Close();

        }
    }
}
