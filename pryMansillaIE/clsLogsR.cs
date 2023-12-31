﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMansillaIE
{
    internal class clsLogsR
    {

        private OleDbConnection conexionBD;
        private OleDbCommand comandoBD;

        public string rutaArchivo;
        public string cadenaConexion;
        public string estadoConexion;

        public clsLogsR()
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
            try
            {
                string sqlInsertarLog = "INSERT INTO LogsR (Usuario, FechaHora, Categoria, Descripcion) VALUES (?, ?, ?, ?)";

                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.Text;
                comandoBD.CommandText = sqlInsertarLog;

                // Utilizar parámetros para los valores
                comandoBD.Parameters.AddWithValue("Usuario", usuario);
                comandoBD.Parameters.AddWithValue("FechaHora", fechahora.ToString("yyyy-MM-dd HH:mm:ss")); // Formatear fecha y hora
                comandoBD.Parameters.AddWithValue("Categoria", categoria);
                comandoBD.Parameters.AddWithValue("Descripcion", descripcion);

                comandoBD.ExecuteNonQuery();
                estadoConexion = "Registro Exitoso";
                conexionBD.Close();

            }
            catch (Exception error)
            {
                conexionBD.Close();
                MessageBox.Show(error.Message);
                estadoConexion = error.Message;
            }
        }
    }
}
