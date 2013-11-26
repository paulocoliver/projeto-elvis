using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class EmpresasType : List<EmpresaType>
    {
    }

    public class EmpresaType
    {
        private int _idEmpresa;
        private int _idAssociacao;
        private int _idCidade;
        private string _RazaoSocial;
        private string _Senha;
        private string _Nome;
        private string _CNPJ;
        private string _IE;
        private string _CEP;
        private string _Endereco;
        private string _Complemento;
        private string _Email;
        private string _Site;
        private string _Logo;
        private string _DataCadastro;
        private string _DataVencimento;

        public string DataVencimento
        {
            get {
                DateTime date = DateTime.Parse(_DataVencimento);
                return date.ToString("yyyy-MM-dd"); 
            }
            set { _DataVencimento = value; }
        }

        public int dateCompare() {

            TimeSpan date = Convert.ToDateTime(_DataVencimento) - Convert.ToDateTime(DateTime.Now);
            int diff = date.Days;

            if(diff < 0){
                diff = 0;
            }
            return diff;
        }

        public int IdEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }

        public int IdAssociacao
        {
            get { return _idAssociacao; }
            set { _idAssociacao = value; }
        }

        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }


        public int IdCidade
        {
            get { return _idCidade; }
            set
            {
                if (value > 0)
                {
                    _idCidade = value;
                }
                else {
                    throw new Exception("Selecione a Cidade!");
                }
               
            }
        }

        public string RazaoSocial
        {
            get { return _RazaoSocial; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Preencha a Razão Social!");
                }
                _RazaoSocial = value;
            }
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

        public string CNPJ
        {
            get { return _CNPJ; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Preencha o CNPJ!");
                }
                _CNPJ = value;
            }
        }

        public string IE
        {
            get { return _IE; }
            set
            {
               _IE = value;
            }
        }

        public string CEP
        {
            get { return _CEP; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Preencha o CEP!");
                }
                _CEP = value;
            }
        }

        public string Endereco
        {
            get { return _Endereco; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Preencha o Endereco!");
                }
                _Endereco = value;
            }
        }

        public string Complemento
        {
            get { return _Complemento; }
            set
            {
                _Complemento = value;
            }
        }

        public string Email
        {
            get { return _Email; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Preencha o Email!");
                }
                _Email = value;
            }
        }

        public string Site
        {
            get { return _Site; }
            set
            {
                _Site = value;
            }
        }

        public string Logo
        {
            get { return _Logo; }
            set
            {
                  _Logo = value;
            }
        }

        public string DataCadastro
        {
            get { return _DataCadastro; }
            set
            {
                 _DataCadastro = value;
            }
        }

        public void addDays(int days)
        {
            days += dateCompare();
            DateTime date = DateTime.Now;
            date = date.AddDays(days);

            _DataVencimento = date.ToString("dd/MM/yyyy");
        }
    }
}