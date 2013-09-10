using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho.Types
{
    public class CargosType : List<CargoType>
    {

    }

    public class CargoType
    {
        private int _idcargo;
        public int IdCargo
        {
            get { return _idcargo; }
            set { _idcargo = value; }
        }

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
