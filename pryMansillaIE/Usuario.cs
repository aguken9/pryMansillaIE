using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryMansillaIE
{
     public class Usuario
    {
        public string Nombre { get; set; }

        string rutaArchivo;
        string cadenaConexion;

        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectoBD;


        public string estadoConexion;
        public Usuario()
        {
            rutaArchivo = @"../../BD/Login.accdb";
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            estadoConexion = "CERRADO";

            ConectarBD();
        }

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "ABIERTO";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }
        public bool ValidarUsuario(string usuario, string clave)
        {
            using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
            using (OleDbCommand cmd = new OleDbCommand("SELECT Usuario, Contrasena FROM Usuario WHERE Usuario = ?", conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("Usuario", usuario);

                    using (OleDbDataReader rd = cmd.ExecuteReader())
                    {
                        return rd.Read() && rd["Usuario"].ToString() == usuario && rd["Contrasena"].ToString() == clave;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
