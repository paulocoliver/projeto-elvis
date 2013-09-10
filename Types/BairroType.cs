using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class bairrosType : List<bairroType>
    {
    }

    public class bairroType
    {
        private string _idCidade;
        private string _idBairro;
        private string _descricao;

        public string idCidade
        {
            get { return _idCidade; }
            set { _idCidade = value; }
        }

        public string idBairro
        {
            get { return _idBairro; }
            set { _idBairro = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
