using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMansillaIE
{
    public partial class frmLogoEmpresa : Form
    {
        public frmLogoEmpresa()
        {
            InitializeComponent();
        }

        private void frmLogoEmpresa_Load(object sender, EventArgs e)
        {

        }

        int contadorTiempo = 0;

        private void temporizador_Tick(object sender, EventArgs e)
        {
            contadorTiempo += 1000;
            if (contadorTiempo > 3000)
            {
                this.Hide();
                frmInicioSesion formularioInicioSesion = new frmInicioSesion();
                formularioInicioSesion.Show();
                temporizador.Enabled = false;
            }
        }
    }
}
