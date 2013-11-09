using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Trabalho.DAL_MYSQL
{
    public class QuestionarioDAL
    {
        public Types.QuestionariosType select()
        {
            Types.QuestionariosType res = new Types.QuestionariosType();
            return res;
        }

        /*public Types.AssociacaoType login(Types.AssociacaoType assoc)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);

            string SQL = "SELECT * FROM associacao A  " +
                         "WHERE USUARIO = @usuario AND SENHA = @senha";
            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@usuario", assoc.Usuario);
            cmd.Parameters.AddWithValue("@senha", assoc.Senha);
            con.Open();
            
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (dr.Read())
            {
                assoc.IdAssociacao = Convert.ToInt32(dr["ID_ASSOCIACAO"].ToString());
                assoc.Nome = dr["NOME"].ToString();
                assoc.Url = dr["URL"].ToString();
                assoc.Logo = dr["LOGO"].ToString();
            }
            return assoc;
        }
        */

        public int insert(Types.QuestionarioType obj)
        {
           /* MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO associacao "+
                            "( "+
                                 "nome,"+
                                 "url,"+
                                 "usuario,"+
                                 "senha" +
                            ") " +
                         "VALUES"+
                          "( "+
                                 "@nome,"+
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
            return id;*/
            return 0;
        }
    }
}
