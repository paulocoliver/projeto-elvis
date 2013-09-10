using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class EmpresariosType : List<EmpresarioType>
    {
    }

    public class EmpresarioType
    {
        private string _idEmpresario;
        private string _idBairro;
        private string _Nome;
        private string _Sobrenome;
        private string _Email;
        private string _RG;
        private string _CPF;
        private string _Endereco;

        public string idEmpresario
        {
            get { return _idEmpresario; }
            set { _idEmpresario = value; }
        }

        public string idBairro
        {
            get { return _idBairro; }
            set {
                if (value == "")
                {
                    throw new Exception("Selecione o Bairro!");
                } 
                _idBairro = value;
            }
        }

        public string Nome
        {
            get { return _Nome; }
            set { 
                if(value == ""){
                    throw new Exception("Preencha o Nome!");
                }
                _Nome = value;
            }
        }

        public string Sobrenome
        {
            get { return _Sobrenome; }
            set {
                if (value == "")
                {
                    throw new Exception("Preencha o Sobrenome!");
                } 
                _Sobrenome = value;
            }
        }

        public string Email
        {
            get { return _Email; }
            set {
                if (value == "")
                {
                    throw new Exception("Preencha o Email!");
                } 
                _Email = value;
            }
        }
        
        public string RG
        {
            get { return _RG; }
            set {
                if (value == "")
                {
                    throw new Exception("Preencha o RG!");
                } 
                _RG = value;
            }
        }

        public string CPF
        {
            get { return _CPF; }
            set {
                if (value == "")
                {
                    throw new Exception("Preencha o CPF!");
                } 
                _CPF = value;
            }
        }

        public string Endereco
        {
            get { return _Endereco; }
            set {
                if (value == "")
                {
                    throw new Exception("Preencha o Endereco!");
                } 
                _Endereco = value;
            }
        }
    }
}
