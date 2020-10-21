using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DocenteDao : ConnectionToSql
    {
        public DataTable listarDocentes()
        {
            DataTable listaDocentes = new DataTable();
            return listaDocentes;
        }
    }
}
