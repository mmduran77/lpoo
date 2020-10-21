using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CarreraModel
    {
        CarreraDao carreraDao = new CarreraDao();
        public DataTable listarCarreras()
        {
            return carreraDao.listarCarreras();
        }
    }
}
