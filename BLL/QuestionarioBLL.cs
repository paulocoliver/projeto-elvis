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

        public Types.QuestionariosType select()
        {
            return DAL.select();
        }
        public int insert(Types.QuestionarioType obj)
        {
            return DAL.insert(obj);
        }
    }
}
