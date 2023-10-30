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

        string sqlInsertarLog = "INSERT INTO logsR " +
            "(Usuario, FechaHora, Categoria, Descripcion) " +
            "VALUES ('prueba','10/10/2023','prueba','prueba')";

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

        public void RegistrarLog(string usuario, DateTime fechahora, string categoria, string descripcion)
        {
            
            //Realizar y Corregir lo de los parametros
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                //registrar la acciòn
                comandoBD.CommandType = System.Data.CommandType.Text;

                comandoBD.CommandText = sqlInsertarLog;

                comandoBD.ExecuteNonQuery();

                estadoConexion = "Registro Exitoso";
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
