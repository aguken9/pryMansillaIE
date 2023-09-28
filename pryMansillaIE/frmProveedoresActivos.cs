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
            string folderPath = Application.StartupPath + @"\Proveedores";

            LoadDirectory(folderPath, trvProveedores.Nodes);
        }

        private void LoadDirectory(string dir, TreeNodeCollection nodes)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);
            if (!directory.Exists) return;

            TreeNode directoryNode = new TreeNode(directory.Name);

            foreach (var file in directory.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            foreach (var subDir in directory.GetDirectories())
                LoadDirectory(subDir.FullName, directoryNode.Nodes);

            nodes.Add(directoryNode);
        }
    }
}
