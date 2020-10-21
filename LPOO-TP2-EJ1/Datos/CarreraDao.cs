using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CarreraDao : ConnectionToSql
    {
        public DataTable listarCarreras()
        {
            DataTable listaCarreras = new DataTable();
            return listaCarreras;
        }
    }
}
