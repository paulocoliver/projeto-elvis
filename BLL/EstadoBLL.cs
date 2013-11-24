using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class EstadoBLL
    {
        public Types.EstadosType select( int idPais )
        {
            EstadoDAL estado = new EstadoDAL();
            return estado.select(idPais);
        }

        public Types.EstadoType selectRecord(int idEstado)
        {
            EstadoDAL estado = new EstadoDAL();
            return estado.selectRecord(idEstado);
        }
    }
}
