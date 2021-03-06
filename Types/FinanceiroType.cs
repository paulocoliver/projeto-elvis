﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class FinanceirosType : List<FinanceiroType>
    {
    }

    public class FinanceiroType
    {
        private int _IdFinanceiro;
        private int _IdAssociacao;
        private string _Titulo;
        private double _Valor;
        private string _Data;
        private string _Tipo;

        public int IdFinanceiro
        {
            get { return _IdFinanceiro; }
            set { _IdFinanceiro = value; }
        }

        public int IdAssociacao
        {
            get { return _IdAssociacao; }
            set { _IdAssociacao = value; }
        }

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public double Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        public string Data
        {
            get { return _Data = _Data.Replace(" 00:00:00", "");}
            set { _Data = value; }
        }


        public string DataFormatSql
        {
            get {
                
                string[] exploded = Data.Split('/');
                return exploded[2] + '-' + exploded[1] + '-' + exploded[0]; 
            }
        }

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        
    }
}