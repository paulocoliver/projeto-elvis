using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class EmpresaBLL
    {
        public void insert(Types.EmpresaType empresa)
        {
            EmpresaDAL dal = new EmpresaDAL();
            dal.insert(empresa);
        }
    }
}
