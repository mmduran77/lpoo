using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DocenteModel
    {
        DocenteDao docenteDao = new DocenteDao();
        public DataTable listarDocentes()
        {
            return docenteDao.listarDocentes();
        }
    }
}
