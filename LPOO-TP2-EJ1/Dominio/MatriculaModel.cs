using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MatriculaModel
    {
        MatriculaDao matriculaDao = new MatriculaDao();
        public DataTable listarMatriculas()
        {
            return matriculaDao.listarMatriculas();
        }

        public void agregarMatricula(string lu, string cod, DateTime fe)
        {
            matriculaDao.agregarMatricula(lu, cod, fe);
        }

        public void modificarMatricula(int id, string lu, string cod, DateTime fe)
        {
            matriculaDao.modificarMatricula(id, lu, cod, fe);
        }
        public void eliminarMatricula(int id)
        {
            matriculaDao.eliminarMatricula(id);
        }

        public DataTable filtrarMatriculas(string storp, string param)
        {
            return matriculaDao.filtrarMatriculas(storp, param);
        }
    }
}
