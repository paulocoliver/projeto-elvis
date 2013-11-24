using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class QuestionarioRespostasType : List<QuestionarioRespostaType>
    {
        public bool hasValue( string value ) {

            foreach (QuestionarioRespostaType resposta in this) {   
                if(resposta.Valor.Equals(value)){
                    return true;
                }            
            }
            return false;
        }
    }

    public class QuestionarioRespostaType
    {
        private int _idQuestionario;
        private int _idEmpresa;
        private string _Valor;

        public int idQuestionario
        {
            get { return _idQuestionario; }
            set { _idQuestionario = value; }
        }

        public int idEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }

        public string Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
    }
}
