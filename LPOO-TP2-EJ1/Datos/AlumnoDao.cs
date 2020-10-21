using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AlumnoDao : ConnectionToSql
    {
        public DataTable listarAlumnos()
        {
            DataTable lst_Alumnos = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarAlumnos";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lst_Alumnos.Load(leerFilas);
                    leerFilas.Close();
                    return lst_Alumnos;
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

        public DataTable listarxNombre(string sp, string param)
        {
            string storProc = "sp_ListarAlumnos";
            string parametro = "";
            if (sp == "xNombre")
            {
                storProc = "sp_ListarXNombre";
                parametro = "@nombre";
            }
            DataTable lstFiltrada = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue(parametro, param);
                    command.CommandText = storProc;
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstFiltrada.Load(leerFilas);
                    leerFilas.Close();
                    return lstFiltrada;
                }
            }
        }

        public DataTable filtrarAlumnos(string sp, string param)
        {
            DataTable lst_Alumnos = new DataTable();
            string storeProc = "";
            string parametro = "";
            if (sp == "XLU")
            {
                storeProc = "sp_ListarAlumnosXLU";
                parametro = "@lu";
            }
            else
            {
                storeProc = "sp_ListarAlumnosXNombre";
                parametro = "@nombre";

            }

            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarAlumnos";
                    command.Parameters.AddWithValue(parametro, param);
                    command.CommandText = storeProc;
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lst_Alumnos.Load(leerFilas);
                    leerFilas.Close();
                    return lst_Alumnos;
                }
            }
        }

    }
}
