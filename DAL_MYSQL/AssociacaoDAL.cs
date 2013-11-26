using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Trabalho.DAL_MYSQL
{
    public class AssociacaoDAL
    {
        public Types.AssociacaoType execReader(MySqlDataReader dr)
        {
            Types.AssociacaoType type = new Types.AssociacaoType();
            type.IdAssociacao = Convert.ToInt32(dr["ID_ASSOCIACAO"].ToString());
            type.Nome = dr["NOME"].ToString();
            type.Url = dr["URL"].ToString();
            type.Logo = dr["LOGO"].ToString();
            type.Usuario = dr["USUARIO"].ToString();
            type.Senha = dr["SENHA"].ToString();
            return type;
        }

        public Types.AssociacaoType selectRecord(int id)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM associacao " +
                         "WHERE id_associacao = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Types.AssociacaoType type = new Types.AssociacaoType();
            if (dr.Read())
            {
                type = execReader(dr);
            }
            return type;
        }

        public Types.AssociacaoType login(Types.AssociacaoType assoc)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM associacao A  " +
                         "WHERE USUARIO = @usuario AND SENHA = @senha";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@usuario", assoc.Usuario);
            cmd.Parameters.AddWithValue("@senha", assoc.Senha);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Types.AssociacaoType type = new Types.AssociacaoType();
            if (dr.Read())
            {
                type = execReader(dr);
            }
            return type;
        }


        public int insert(Types.AssociacaoType obj)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO associacao " +
                            "( " +
                                 "nome," +
                                 "url," +
                                 "usuario," +
                                 "senha" +
                            ") " +
                         "VALUES" +
                          "( " +
                                 "@nome," +
                                 "@url," +
                                 "@usuario," +
                                 "@senha" +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@nome", obj.Nome);
            cmd.Parameters.AddWithValue("@url", obj.Url);
            cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
            cmd.Parameters.AddWithValue("@senha", obj.Senha);
            con.Open();
            int id = 0;
            try
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT MAX(id_associacao) " +
                                  "FROM associacao";
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                con.Close();
            }
            return id;
        }
    }
}
