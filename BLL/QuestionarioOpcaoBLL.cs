using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;

namespace Trabalho.BLL
{
    public class QuestionarioOpcaoBLL
    {
        QuestionarioOpcaoDAL DAL;

        public QuestionarioOpcaoBLL()
        {
            DAL = new QuestionarioOpcaoDAL();
        }

        public Types.QuestionarioOpcaoType selectRecord(int id)
        {
            return DAL.selectRecord(id);
        }

        public Types.QuestionarioOpcoesType select(Types.QuestionarioType questionario)
        {
            return DAL.select(questionario);
        }

        public int insert(Types.QuestionarioOpcaoType obj)
        {
            return DAL.insert(obj);
        }

        public void delete(Types.QuestionarioType questionario)
        {
            DAL.delete(questionario);
        }
    }
}
