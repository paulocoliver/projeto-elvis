using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class EstadosType : List<EstadoType>
    {
    }

    public class EstadoType
    {
        private string _idPais;
        private string _idEstado;
        private string _sigla;
        private string _descricao;

        public string idPais
        {
            get { return _idPais; }
            set { _idPais = value; }
        }

        public string idEstado
        {
            get { return _idEstado; }
            set { _idEstado = value; }
        }

        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
