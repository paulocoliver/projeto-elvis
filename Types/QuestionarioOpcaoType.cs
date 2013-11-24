using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class QuestionarioOpcoesType : List<QuestionarioOpcaoType>
    {
    }

    public class QuestionarioOpcaoType
    {
        private int _idOpcaoQuestionario;
        private int _idQuestionario;
        private string _Descricao;

        public int idOpcaoQuestionario
        {
            get { return _idOpcaoQuestionario; }
            set { _idOpcaoQuestionario = value; }
        }

        public int IdQuestionario
        {
            get { return _idQuestionario; }
            set { _idQuestionario = value; }
        }

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

    }
}