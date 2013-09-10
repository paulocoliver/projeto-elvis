using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class BairroBLL
    {
        public Types.bairrosType select(int idBairro)
        {
            BairroDAL cidade = new BairroDAL();
            return cidade.select(idBairro);
        }
    }
}
