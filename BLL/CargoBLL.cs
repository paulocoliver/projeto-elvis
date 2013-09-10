using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class CargoBLL
    {
        public Types.CargosType select()
        {
            CargoDAL CargoDAL = new CargoDAL();
            return CargoDAL.select();
        }

        public Types.CargoType selectRecord(Types.CargoType usuario)
        {
            DAL_MYSQL.CargoDAL CargoDAL = new DAL_MYSQL.CargoDAL();
            return CargoDAL.selectRecord(usuario);
        }

        public int insert(Types.CargoType usuario)
        {
            CargoDAL CargoDAL = new CargoDAL();
            return CargoDAL.insert(usuario);
        }

        public void excluir(Types.CargoType usuario)
        {
            DAL_MYSQL.CargoDAL CargoDAL = new DAL_MYSQL.CargoDAL();
            CargoDAL.delete(usuario);
        }

        public void alterar(Types.CargoType usuario)
        {
            DAL_MYSQL.CargoDAL CargoDAL = new DAL_MYSQL.CargoDAL();
            CargoDAL.update(usuario);
        }

    }
}
