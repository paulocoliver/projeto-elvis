using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class EmpresarioBLL
    {
        public void insert(Types.EmpresarioType empresario) {
            EmpresarioDAL dal = new EmpresarioDAL();
            dal.insert(empresario);
        }

        public Types.EmpresariosType select() {
            EmpresarioDAL dal = new EmpresarioDAL();
            return dal.select();
        }
    }
}
