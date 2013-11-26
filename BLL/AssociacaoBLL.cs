using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class AssociacaoBLL
    {
        public Types.AssociacaoType login(Types.AssociacaoType assoc)
        {
            AssociacaoDAL assocDAL = new AssociacaoDAL();
            return assocDAL.login(assoc);
        }

        public int insert(Types.AssociacaoType obj)
        {
            AssociacaoDAL assocDAL = new AssociacaoDAL();
            return assocDAL.insert(obj);
        }

        public Types.AssociacaoType selectRecord(int id)
        {
            AssociacaoDAL assocDAL = new AssociacaoDAL();
            return assocDAL.selectRecord(id);
        }
    }
}
