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

        private void frmProveedoresActivos_Load(object sender, EventArgs e)
        {
            // Combina la ruta del directorio de inicio de la aplicación con el nombre de la carpeta "Proveedores"
            string folderPath = Path.Combine(Application.StartupPath, "Proveedores");

            // Verifica si la carpeta "Proveedores" existe en la ubicación especificada
            if (Directory.Exists(folderPath))
            {
                // Si existe, carga los contenidos de la carpeta en el TreeView
                CargarDirectorio(folderPath, trvProveedores.Nodes);
            }
            else
            {
                // Si la carpeta no existe, muestra un mensaje de error y cierra el formulario
                MessageBox.Show("La carpeta 'Proveedores' no existe en la ubicación esperada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CargarDirectorio(string dir, TreeNodeCollection nodes)
        {
            // Crea una instancia de DirectoryInfo para representar la carpeta especificada
            DirectoryInfo directory = new DirectoryInfo(dir);

            // Crea un nodo en el TreeView con el nombre de la carpeta
            TreeNode directoryNode = new TreeNode(directory.Name);

            // Itera a través de los archivos en la carpeta
            foreach (var file in directory.GetFiles())
            {
                // Verifica si la extensión del archivo es ".txt" (insensible a mayúsculas y minúsculas)
                if (file.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    // Si es un archivo de texto, agrega un nodo al TreeView con el nombre del archivo
                    directoryNode.Nodes.Add(new TreeNode(file.Name));
                }
            }

            // Itera a través de los subdirectorios en la carpeta actual
            foreach (var subDir in directory.GetDirectories())
            {
                // Llama recursivamente a LoadDirectory para cargar los contenidos de los subdirectorios
                CargarDirectorio(subDir.FullName, directoryNode.Nodes);
            }

            // Agrega el nodo de la carpeta actual al TreeView
            nodes.Add(directoryNode);
        }

        private void trvProveedores_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Combinar la ruta del directorio de inicio de la aplicación con la ruta completa del archivo seleccionado en el TreeView
            string filePath = Path.Combine(Application.StartupPath, "Proveedores", e.Node.FullPath);

            // Verificar si el archivo existe y si su extensión es ".txt" (insensible a mayúsculas y minúsculas)
            if (File.Exists(filePath) && Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase))
            {
                // Leer todas las líneas del archivo y mostrarlas en el ListBox (lstDatos)
                string[] fileLines = File.ReadAllLines(filePath);
                lstDatos.Items.Clear();
                lstDatos.Items.AddRange(fileLines);
            }
        }
    }
}
