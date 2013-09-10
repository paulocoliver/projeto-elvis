using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class DepartamentoBLL
    {
        public Types.DepartamentosType select()
        {
            DepartamentoDAL DepartamentoDAL = new DepartamentoDAL();
            return DepartamentoDAL.select();
        }

        public Types.DepartamentoType selectRecord(Types.DepartamentoType usuario)
        {
            DAL_MYSQL.DepartamentoDAL DepartamentoDAL = new DAL_MYSQL.DepartamentoDAL();
            return DepartamentoDAL.selectRecord(usuario);
        }

        public int insert(Types.DepartamentoType usuario)
        {
            DepartamentoDAL DepartamentoDAL = new DepartamentoDAL();
            return DepartamentoDAL.insert(usuario);
        }

        public void excluir(Types.DepartamentoType usuario)
        {
            DAL_MYSQL.DepartamentoDAL DepartamentoDAL = new DAL_MYSQL.DepartamentoDAL();
            DepartamentoDAL.delete(usuario);
        }

        public void alterar(Types.DepartamentoType usuario)
        {
            DAL_MYSQL.DepartamentoDAL DepartamentoDAL = new DAL_MYSQL.DepartamentoDAL();
            DepartamentoDAL.update(usuario);
        }

    }
}
