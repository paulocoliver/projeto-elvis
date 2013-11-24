using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class QuestionarioBLL
    {
        QuestionarioDAL DAL;

        public QuestionarioBLL() {
            DAL = new QuestionarioDAL();
        }

        public Types.QuestionarioType selectRecord(int id)
        {
            return DAL.selectRecord(id);
        }

        public Types.QuestionariosType select(int id_associacao, string id_empresa)
        {
            return DAL.select(id_associacao, id_empresa);
        }

        public int insert(Types.QuestionarioType obj)
        {
            return DAL.insert(obj);
        }

        public void update(Types.QuestionarioType obj)
        {
            DAL.update(obj);
        }

        public void delete(Types.QuestionarioType obj)
        {
            DAL.delete(obj);
        }
    }
}
