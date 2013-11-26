using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;
using Trabalho.Types;

namespace Trabalho.BLL
{
    public class PagamentoBLL
    {
        private PagamentoDAL _DAL;

        public PagamentoBLL() {
            _DAL = new PagamentoDAL();
        }

        public PagamentoType selectRecord(int idPagamento) {
            return _DAL.selectRecord(idPagamento);
        }

        public PagamentosType select(int idEmpresa) {
            return _DAL.select(idEmpresa);
        }

        public int insert(PagamentoType pagamento) {
            return _DAL.insert(pagamento);
        }

        public void update(PagamentoType pagamento)
        {
            _DAL.update(pagamento);
        }

        public void delete(PagamentoType pagamento)
        {
            _DAL.delete(pagamento);
        }
    }
}
