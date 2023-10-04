using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryMansillaIE
{
    class clsTrv
    {
        private TreeView trvProveedores;

        public clsTrv(TreeView treeView)
        {
            trvProveedores = treeView;
        }

        public void CargarProveedores()
        {
            // Combina la ruta del directorio de inicio de la aplicación con el nombre de la carpeta "Proveedores"
            string folderPath = Path.Combine(Application.StartupPath, "../../Proveedores");

            // Verifica si la carpeta "Proveedores" existe en la ubicación especificada
            if (Directory.Exists(folderPath))
            {
                // Si existe, carga los contenidos de la carpeta en el TreeView
                CargarDirectorio(folderPath, trvProveedores.Nodes);
            }
            else
            {
                // Si la carpeta no existe, muestra un mensaje de error
                MessageBox.Show("La carpeta 'Proveedores' no existe en la ubicación esperada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDirectorio(string dir, TreeNodeCollection nodes)
        {
            // Crea una instancia de DirectoryInfo para representar la carpeta especificada
            //Crear mover y enumerar archivos en directorios y subdirectorios
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
                // Llama recursivamente a CargarDirectorio para cargar los contenidos de los subdirectorios
                CargarDirectorio(subDir.FullName, directoryNode.Nodes);
            }

            // Agrega el nodo de la carpeta actual al TreeView
            nodes.Add(directoryNode);
        }
    }
}
