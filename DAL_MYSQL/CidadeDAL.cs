using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Trabalho.DAL_MYSQL
{
    public class CidadeDAL
    {
        public Types.cidadesType select(int idEstado)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "select * from cidade c " +
                         "join estado e on e.id_estado = c.id_estado " +
                         "where e.id_estado = @idEstado " +
                         "order by c.descricao";

            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idEstado", idEstado);
            con.Open();

            MySqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Types.cidadesType cidades = new Types.cidadesType();
            while (rd.Read())
            {
                Types.cidadeType cidade = new Types.cidadeType();

                cidade.idEstado  = rd["id_estado"].ToString();
                cidade.idCidade  = rd["id_cidade"].ToString();
                cidade.Descricao = rd["descricao"].ToString();

                cidades.Add(cidade);
            }
            return cidades;
        }
    }
}
