using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class AssociacoesType : List<AssociacaoType>
    {
    }

    public class AssociacaoType
    {
        private int _idAssociacao;
        private string _Nome;
        private string _Url;
        private string _Logo;
        private string _Usuario;
        private string _Senha;
    
        public int IdAssociacao
        {
            get { return _idAssociacao; }
            set { _idAssociacao = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Preencha o Nome!");
                }
                _Nome = value;
            }
        }

        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        public string Logo
        {
            get { return _Logo; }
            set { _Logo = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        
    }
}