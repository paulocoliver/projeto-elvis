using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Trabalho.DAL_SQL
{
    public class PaisDAL
    {
        public Types.PaisesType select() {

            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "select * from pais order by descricao";
            SqlCommand cmd = new SqlCommand(SQL,con);
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

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
