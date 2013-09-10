using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho.Types
{
    public class DepartamentosType : List<DepartamentoType>
    {

    }

    public class DepartamentoType
    {
        private int _iddepartamento;
        public int IdDepartamento
        {
            get { return _iddepartamento; }
            set { _iddepartamento = value; }
        }

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
