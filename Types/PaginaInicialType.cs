using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class PaginaInicialType
    {
        private int _idAssociacao;
        private int _idPaginaInicial;
        private string _Texto;

        public int IdAssociacao
        {
            get { return _idAssociacao; }
            set { _idAssociacao = value; }
        }

        public int IdPaginaInicial
        {
            get { return _idPaginaInicial; }
            set { _idPaginaInicial = value; }
        }

        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
    }
}
