using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Trabalho.DAL_MYSQL
{
    public class PaisDAL
    {
        public Types.PaisesType select() {

            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "select * from pais order by descricao";
            MySqlCommand cmd = new MySqlCommand(SQL,con);
            con.Open();

            MySqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Types.PaisesType paises = new Types.PaisesType();
            while( rd.Read() ){
                Types.PaisType pais = new Types.PaisType();

                pais.idPais     = rd["id_pais"].ToString();
                pais.Descricao  = rd["descricao"].ToString();

                paises.Add(pais);
            }
            return paises;
        }
    }
}
