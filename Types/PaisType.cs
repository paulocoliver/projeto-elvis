using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class PaisesType : List<PaisType>
    {

    }

    public class PaisType 
    {
        private string _idPais;
        private string _descricao;

        public string idPais {
            get { return _idPais; }
            set { _idPais = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
