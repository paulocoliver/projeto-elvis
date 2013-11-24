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
        public Types.QuestionarioType selectRecord(int id)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM questionario " +
                         "WHERE id_questionario = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Types.QuestionarioType type = new Types.QuestionarioType();
            if (dr.Read())
            {
                type.idQuestionario = Int32.Parse(dr["id_questionario"].ToString());
                type.IdAssociacao = Int32.Parse(dr["id_associacao"].ToString());
                type.Tipo = dr["tipo"].ToString();
                type.Descricao = dr["descricao"].ToString();
            }
            return type;
        }

        public Types.QuestionariosType select(int id_associacao, string id_empresa)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
             
            string SQL = "SELECT * FROM questionario q WHERE id_associacao = @id_associacao";
       
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_associacao",id_associacao);

            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Types.QuestionariosType types = new Types.QuestionariosType();
            QuestionarioRespostaDAL dalResposta = new QuestionarioRespostaDAL();
            while (dr.Read())
            {
                Types.QuestionarioType type = new Types.QuestionarioType();
                type.idQuestionario = Int32.Parse(dr["id_questionario"].ToString());
                type.IdAssociacao = Int32.Parse(dr["id_associacao"].ToString());
                type.Tipo = dr["tipo"].ToString();
                type.Descricao = dr["descricao"].ToString();
                if (id_empresa != null)
                {
                    type.Respostas = dalResposta.select(Convert.ToInt32(id_empresa), type.idQuestionario);
                }
                types.Add(type);
            }
            return types;
        }

        public int insert(Types.QuestionarioType obj)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO questionario " +
                            "( "+
                                 "id_associacao, " +
                                 "tipo, " +
                                 "descricao " +
                            ") " +
                         "VALUES "+
                          "( "+
                                 "@id_associacao, " +
                                 "@tipo, " +
                                 "@descricao " +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_associacao", obj.IdAssociacao);
            cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
            cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
            con.Open();
            int id = 0;
            try
            {             
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT MAX(id_questionario) " +
                                  "FROM questionario";
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                con.Close();
            }
         
            return id;
        }

        public void update(Types.QuestionarioType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "UPDATE questionario " +
                         "SET id_associacao = @id_associacao, tipo = @tipo, descricao = @descricao " +
                         "WHERE id_questionario = @id_questionario";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_questionario", type.idQuestionario);
            cmd.Parameters.AddWithValue("@id_associacao", type.IdAssociacao);
            cmd.Parameters.AddWithValue("@tipo", type.Tipo);
            cmd.Parameters.AddWithValue("@descricao", type.Descricao);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void delete(Types.QuestionarioType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM questionario " +
                         "WHERE id_questionario = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.idQuestionario);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
