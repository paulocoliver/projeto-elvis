using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;
using Trabalho.Types;

namespace Trabalho.BLL
{
    public class PaginaInicialBLL
    {
        private PaginaInicialDAL DAL;

        public PaginaInicialBLL() {
            DAL = new PaginaInicialDAL();
        }
        public void save(PaginaInicialType pagina) {
            DAL.save(pagina);
        }

        public PaginaInicialType select(int idAssocicao)
        {
            return DAL.select(idAssocicao);
        }
    }
}
