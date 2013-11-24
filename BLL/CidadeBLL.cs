using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class CidadeBLL
    {
        public Types.cidadesType select(int idEstado)
        {
            CidadeDAL cidade = new CidadeDAL();
            return cidade.select(idEstado);
        }

        public Types.cidadeType selectRecord(int idCidade)
        {
            CidadeDAL cidade = new CidadeDAL();
            return cidade.selectRecord(idCidade);
        }
    }
}
