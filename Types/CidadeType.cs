using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class cidadesType : List<cidadeType>
    {
    }

    public class cidadeType
    {
        private string _idEstado;
        private string _idCidade;
        private string _descricao;

        public string idEstado
        {
            get { return _idEstado; }
            set { _idEstado = value; }
        }

        public string idCidade
        {
            get { return _idCidade; }
            set { _idCidade = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
