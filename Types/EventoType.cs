using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Types
{
    public class EventosType : List<EventoType>
    {}

    public class EventoType
    {
        private int _idEvento;
        private int _idAssociacao;
        private string _titulo;
        private string _descricao;
        private string _local;
        private string _dataIni;
        private string _dataEnd;

        public int idEvento
        {
            get { return _idEvento; }
            set { _idEvento = value; }
        }

        public int idAssociacao
        {
            get { return _idAssociacao; }
            set { _idAssociacao = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Local
        {
            get { return _local; }
            set { _local = value; }
        }

        public string dataIni
        {
            get { return _dataIni; }
            set {
                _dataIni = value.Replace("T"," ");
            }
        }

        public string dataEnd
        {
            get { return _dataEnd; }
            set {
                _dataEnd = value.Replace("T", " ");
            }
        }

        public string dataIniToInput
        {
            get
            {
                return formatToInput(_dataIni);
            }
        }

        public string dataEndToInput {
            get {
                return formatToInput(_dataEnd); 
            }
        }

        private string formatToInput(string value) {
            return value.Substring(6, 4) + "-" +
                   value.Substring(3, 2) + "-" +
                   value.Substring(0, 2) + "T" +
                   value.Substring(11);
        }
    }
}
