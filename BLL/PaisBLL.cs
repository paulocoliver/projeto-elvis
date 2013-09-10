using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class PaisBLL
    {
        public Types.PaisesType select() {
            PaisDAL pais = new PaisDAL();
            return pais.select();
        }
    }
}
