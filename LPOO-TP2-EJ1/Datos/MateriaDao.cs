using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MateriaDao : ConnectionToSql
    {
        public DataTable listarMaterias()
        {
            DataTable lst_Materias = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarMaterias";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lst_Materias.Load(leerFilas);
                    leerFilas.Close();
                    return lst_Materias;
                }
            }
        }

        public void agregarAlumno(string nombre, string apellido, string dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.CommandText = "sp_AgregarAlumno";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void modificarAlumno(int lu, string nom, string ape, string dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@luAlu", lu);
                    command.Parameters.AddWithValue("@nombre", nom);
                    command.Parameters.AddWithValue("@apellido", ape);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.CommandText = "sp_ModificarAlumno";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void eliminarAlumno(int lu)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@luAlu", lu);
                    command.CommandText = "sp_EliminarAlumno";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                }
            }
        }

        public DataTable filtrarMaterias(string sp, string param)
        {
            DataTable lst_Materias = new DataTable();
            string storeProc = "";
            string parametro = "";
            if (sp == "XCodigo")
            {
                storeProc = "sp_ListarMateriasXCodigo";
                parametro = "@codigo";
            }
            else
            {
                storeProc = "sp_ListarMateriasXNombre";
                parametro = "@nombre";
                
            }

            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarMaterias";
                    command.Parameters.AddWithValue(parametro, param);
                    command.CommandText = storeProc;
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lst_Materias.Load(leerFilas);
                    leerFilas.Close();
                    return lst_Materias;
                }
            }
        }
    }
}
