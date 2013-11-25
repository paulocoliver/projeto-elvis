using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;
using Trabalho.Types;

namespace Trabalho.BLL
{
    public class EventoBLL
    {
        EventoDAL DAL;

        public EventoBLL()
        {
            DAL = new EventoDAL();
        }

        public int inserir(EventoType evento) {
            return DAL.insert(evento);
        }

        public EventoType selectRecord(int idEvento) {
            return DAL.selectRecord(idEvento);
        }

        public void update(EventoType _evento)
        {
            DAL.update(_evento);
        }

        public void delete(EventoType _evento)
        {
            DAL.delete(_evento);
        }
    }
}
