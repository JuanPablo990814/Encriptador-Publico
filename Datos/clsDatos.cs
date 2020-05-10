using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class clsDatos
    {
        #region Definicion de Variables SQL SERVER
        SqlConnection conexionDB = null;
        SqlCommand cmdConsCliente = null;  
        SqlDataReader drConsCliente = null;
        //DataTable dttConsCliente = null;
        string cadenaConexion = null;
        #endregion

        #region Definicion de variables MySql Server
        MySqlConnection MyconexionDB = null;
        MySqlCommand MycmdConsCliente = null;
        MySqlDataReader MydrConsCliente = null;
        #endregion

        public clsDatos()
        {
            cadenaConexion = "Server=(LocalDB)\\LOCALSERVER-JP;Database=DB_MyBase;Integrated Security = True";
        }

        public void mtInsertarBaseDatos(string dato, string comentario)
        {
            conexionDB = new SqlConnection(cadenaConexion);
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = conexionDB;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "insert into tblWeb values('" + dato + "','" + comentario + "')";

            //Abre conexion y ejecuta consulta

            conexionDB.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            conexionDB.Close();
        }

        public void mtInsertarEnElServidor(string dato, string comentario)
        {
            //puerto por defecto
            string MycadenaConexion = ("Server=paginaweb;Port=3306;Database=basesdedatos;UID=usuarioconpermisos;Password=contraseña");
            MyconexionDB = new MySqlConnection(MycadenaConexion);
            MycmdConsCliente = new MySqlCommand();

            //Preparar comando MySQL

            MycmdConsCliente.Connection = MyconexionDB;
            MycmdConsCliente.CommandType = CommandType.Text;
            //insertar datos en  MySql
            //INSERT INTO `tblWeb`(`recurso`, `comentario`) VALUES ("un dato"," otro dato")
            MycmdConsCliente.CommandText = "INSERT INTO `tblWeb`(`recurso`, `comentario`) VALUES ('" + dato + "','" + comentario + "')";

            //Abre conexion y ejecuta consulta

            MyconexionDB.Open();
            MydrConsCliente = MycmdConsCliente.ExecuteReader();
            MyconexionDB.Close();

        }
    }
}
