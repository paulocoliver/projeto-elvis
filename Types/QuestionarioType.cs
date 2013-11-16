using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class QuestionariosType : List<QuestionarioType>
    {
    }

    public class QuestionarioType
    {
        private int _idQuestionario;
        private int _idAssociacao;
        private string _Tipo;
        private string _Descricao;

        public int idQuestionario
        {
            get { return _idQuestionario; }
            set { _idQuestionario = value; }
        }

        public int IdAssociacao
        {
            get { return _idAssociacao; }
            set { _idAssociacao = value; }
        }

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public string TipoFormat
        {
            get {
                string[] exploded = _Tipo.Split('_');
                return exploded[0]; 
            }
        }

        public Boolean TipoIsMultiple
        {
            get
            {
                string[] exploded = _Tipo.Split('_');
                if (exploded[1] == "S")
                    return true;
                else
                    return false;
            }
        }

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }
    }
}