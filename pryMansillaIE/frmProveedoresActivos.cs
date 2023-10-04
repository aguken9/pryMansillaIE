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
    public partial class frmProveedoresActivos : Form
    {
        public frmProveedoresActivos()
        {
            InitializeComponent();
        }
        private clsTrv proveedoresLoader;
        private void frmProveedoresActivos_Load(object sender, EventArgs e)
        {
            // Crear una instancia de clsTrv y pasar el TreeView como parámetro
            proveedoresLoader = new clsTrv(trvProveedores);

            // Llamar al método CargarProveedores para cargar los proveedores en el TreeView
            proveedoresLoader.CargarProveedores();
        }
    }
}
