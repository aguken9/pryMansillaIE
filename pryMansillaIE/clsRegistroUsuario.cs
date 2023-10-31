using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMansillaIE
{
    internal class clsRegistroUsuario
    {

        private string rutaArchivo;
        private string cadenaConexion;
        private string estadoConexion;
        private OleDbConnection conexionBD;

        public clsRegistroUsuario()
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

        public bool InsertarUsuario(string nombre, string contraseña, byte[] firmaData)
        {
            try
            {
                // Primero, verifica si el nombre de usuario ya existe en la base de datos.
                string verificaQuery = "SELECT COUNT(*) FROM Usuario WHERE Usuario = @Usuario";

                using (OleDbCommand verificaCmd = new OleDbCommand(verificaQuery, conexionBD))
                {
                    verificaCmd.Parameters.AddWithValue("@Usuario", nombre);
                    int count = (int)verificaCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // El usuario ya existe, muestra un mensaje de error.
                        MessageBox.Show("Usuario ya registrado.");
                        return false;
                    }
                }

                // Si el usuario no existe, procede con la inserción.
                string insertQuery = "INSERT INTO Usuario (Usuario, Contrasena, Firma) VALUES (@Usuario, @Contrasena, @Firma)";

                using (OleDbCommand cmd = new OleDbCommand(insertQuery, conexionBD))
                {
                    cmd.Parameters.AddWithValue("@Usuario", nombre);
                    cmd.Parameters.AddWithValue("@Contrasena", contraseña);
                    cmd.Parameters.Add("@Firma", OleDbType.LongVarBinary).Value = firmaData;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                estadoConexion = ex.Message;
                return false;
            }
        }


        public byte[] ObtenerFirmaDeUsuario(string nombreUsuario)
        {
            try
            {
                byte[] firmaData = null;

                // Realiza una consulta SQL para obtener la firma del usuario seleccionado.
                string query = "SELECT Firma FROM Usuario WHERE Usuario = @NombreUsuario"; // Ajusta el nombre de la tabla según tu base de datos.

                using (OleDbConnection connection = new OleDbConnection(cadenaConexion)) // Utiliza tu cadena de conexión.
                {
                    connection.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && reader["Firma"] != DBNull.Value)
                            {
                                firmaData = (byte[])reader["Firma"];
                            }
                        }
                    }
                }

                return firmaData;
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir durante la obtención de la firma.
                // Puedes mostrar un mensaje de error o registrar el error según tus necesidades.
                MessageBox.Show("Error al obtener la firma del usuario: " + ex.Message);
                return null;
            }
        }





        public void CargarNombresDeUsuariosEnComboBox(ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Clear(); // Limpia cualquier elemento previo en el ComboBox.

                // Realiza una consulta SQL para obtener los nombres de usuario desde la base de datos.
                string query = "SELECT Usuario FROM Usuario"; // Ajusta el nombre de la tabla según tu base de datos.

                using (OleDbConnection connection = new OleDbConnection(cadenaConexion)) // Utiliza tu cadena de conexión.
                {
                    connection.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nombreUsuario = reader["Usuario"].ToString();
                                comboBox.Items.Add(nombreUsuario); // Agrega el nombre de usuario al ComboBox.
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir durante la carga de los nombres de usuario.
                // Puedes mostrar un mensaje de error o registrar el error según tus necesidades.
                MessageBox.Show("Error al cargar los nombres de usuario: " + ex.Message);
            }
        }






    }
}
