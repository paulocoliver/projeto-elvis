using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Trabalho.DAL_SQL
{
    public class BairroDAL
    {
        public Types.bairrosType select(int idCidade)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "select * from bairro b " +
                         "join cidade c on b.id_cidade = c.id_cidade " +
                         "where c.id_cidade = @idCidade " +
                         "order by b.descricao";

            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idCidade", idCidade);
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Types.bairrosType bairros = new Types.bairrosType();
            while (rd.Read())
            {
                Types.bairroType bairro = new Types.bairroType();

                bairro.idCidade = rd["id_cidade"].ToString();
                bairro.idBairro  = rd["id_bairro"].ToString();           
                bairro.Descricao = rd["descricao"].ToString();

                bairros.Add(bairro);
            }
            return bairros;
        }
    }
}
