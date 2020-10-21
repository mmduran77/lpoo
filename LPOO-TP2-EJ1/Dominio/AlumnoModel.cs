using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AlumnoModel
    {
        AlumnoDao alumnoDao = new AlumnoDao();
        public DataTable listarAlumnos()
        {
            return alumnoDao.listarAlumnos();
        }

        public void agregarAlumno(string nom, string ape, string dni)
        {
            alumnoDao.agregarAlumno(nom, ape, dni);
        }

        public void modificarAlumno(int lu, string nom, string ape, string dni)
        {
            alumnoDao.modificarAlumno(lu, nom, ape, dni);
        }
        public void eliminarAlumno(int lu)
        {
            alumnoDao.eliminarAlumno(lu);
        }

        public DataTable listarxNombre(string storp, string param)
        {
            return alumnoDao.listarxNombre(storp, param);
        }

        public DataTable filtrarAlumnos(string storp, string param)
        {
            return alumnoDao.filtrarAlumnos(storp, param);
        }
    }
}
