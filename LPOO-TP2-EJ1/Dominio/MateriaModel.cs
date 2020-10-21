using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MateriaModel
    {
        MateriaDao materiaDao = new MateriaDao();
        public DataTable listarMaterias()
        {
            return materiaDao.listarMaterias();
        }

        public void agregarMateria(string nom, string ape, string dni)
        {
            materiaDao.agregarAlumno(nom, ape, dni);
        }

        public void modificarMateria(int lu, string nom, string ape, string dni)
        {
            materiaDao.modificarAlumno(lu, nom, ape, dni);
        }
        public void eliminarMateria(int lu)
        {
            materiaDao.eliminarAlumno(lu);
        }

        public DataTable filtrarMaterias(string storp, string param)
        {
            return materiaDao.filtrarMaterias(storp, param);
        }
    }
}
