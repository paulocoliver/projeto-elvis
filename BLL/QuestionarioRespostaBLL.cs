using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;
using Trabalho.Types;

namespace Trabalho.BLL
{
    public class QuestionarioRespostaBLL
    {
        public bool save(QuestionarioType questionario, int idEmpresa)
        {
            QuestionarioRespostaDAL dal = new QuestionarioRespostaDAL();
            return dal.save(questionario, idEmpresa);
        }
    }
}
