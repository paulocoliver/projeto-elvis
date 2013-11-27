using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;
using Trabalho.Types;

namespace Trabalho.BLL
{
    public class FinanceiroBLL
    {
        FinanceiroDAL DAL;

        public FinanceiroBLL()
        {
            DAL = new FinanceiroDAL();
        }

        public FinanceiroType selectRecord(int id)
        {
            return DAL.selectRecord(id);
        }

        public FinanceirosType selectByAssociacao(AssociacaoType assoc, string ano, string mes)
        {
            return DAL.selectByAssociacao(assoc, ano, mes);
        }

        public double selectSaldoAnterior(AssociacaoType assoc, string ano, string mes)
        {
            return DAL.selectSaldoAnterior(assoc, ano, mes);
        }

        public int insert(FinanceiroType obj)
        {
            return DAL.insert(obj);
        }

        public void update(FinanceiroType obj)
        {
            DAL.update(obj);
        }

        public void delete(FinanceiroType obj)
        {
            DAL.delete(obj);
        }
        
    }
}
