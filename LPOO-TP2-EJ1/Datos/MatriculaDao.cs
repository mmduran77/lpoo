using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MatriculaDao : ConnectionToSql
    {
        public DataTable listarMatriculas()
        {
            DataTable lst_Matriculas = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarMatriculas";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lst_Matriculas.Load(leerFilas);
                    leerFilas.Close();
                    return lst_Matriculas;
                }
            }
        }

        public void agregarMatricula(string lu, string cod, DateTime fe)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@lu", lu);
                    command.Parameters.AddWithValue("@cod", cod);
                    command.Parameters.AddWithValue("@fecha", fe);
                    command.CommandText = "sp_AgregarMatricula";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void modificarMatricula(int id, string lu, string cod, DateTime fe)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@id", id); 
                    command.Parameters.AddWithValue("@lu", lu);
                    command.Parameters.AddWithValue("@cod", cod);
                    command.Parameters.AddWithValue("@fecha", fe);                    
                    command.CommandText = "sp_ModificarMatricula";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void eliminarMatricula(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandText = "sp_EliminarMatricula";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                }
            }
        }
       
        public DataTable filtrarMatriculas(string sp, string param)
        {
            DataTable lst_Matriculas = new DataTable();
            string storeProc = "";
            string parametro = "";
            if (sp == "XNombreAlu")
            {
                storeProc = "sp_ListarMatriculasXAlumno";
                parametro = "@nombre";
            }
            else
            {
                storeProc = "sp_ListarMatriculasXMateria";
                parametro = "@nombre";

            }

            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ListarMatriculas";
                    command.Parameters.AddWithValue(parametro, param);
                    command.CommandText = storeProc;
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lst_Matriculas.Load(leerFilas);
                    leerFilas.Close();
                    return lst_Matriculas;
                }
            }
        }
    }
}
