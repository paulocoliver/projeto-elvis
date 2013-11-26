using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;
using Trabalho.Types;

namespace Trabalho.BLL
{
    public class EmpresaBLL
    {
        EmpresaDAL DAL;

        public EmpresaBLL()
        {
            DAL = new EmpresaDAL();
        }

        public int insert(Types.EmpresaType empresa)
        {
            EmpresaDAL dal = new EmpresaDAL();
            return dal.insert(empresa);
        }

        public bool update(Types.EmpresaType empresa)
        {
            EmpresaDAL dal = new EmpresaDAL();
            return dal.update(empresa);
        }

        public EmpresaType login(string email, string senha) { 
        
            EmpresaDAL dal = new EmpresaDAL();
            return dal.login(email,senha);
        }

        public EmpresaType selectRecord(int id_empresa)
        {
            EmpresaDAL dal = new EmpresaDAL();
            EmpresaType empresa = dal.selectRecord(id_empresa);

            return empresa;
        }

        public Types.EmpresasType select()
        {
            return DAL.select();
        }

        public Types.EmpresasType selectByAssociacao(Types.AssociacaoType associacao)
        {
            return DAL.selectByAssociacao(associacao);
        }

        public void delete(Types.EmpresaType obj)
        {
            DAL.delete(obj);
        }
    }
}
