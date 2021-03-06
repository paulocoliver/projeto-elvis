﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabalho.Types
{
    public class PagamentosType : List<PagamentoType> { }

    public class PagamentoType
    {
        private int _idPagamento;
        private int _idEmpresa;
        private double _valor;
        private string _data;

        public int IdPagamento
        {
            get { return _idPagamento; }
            set { _idPagamento = value; }
        }

        public int IdEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
