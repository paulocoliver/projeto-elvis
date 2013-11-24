using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Trabalho.Types;

namespace Trabalho.DAL_MYSQL
{
    public class QuestionarioOpcaoDAL
    {
        public Types.QuestionarioOpcaoType selectRecord(int id)
        {
            Types.QuestionarioOpcaoType type = new Types.QuestionarioOpcaoType();
            /*MySqlConnection con = new MySqlConnection(Dados.StringConexao);
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
            }*/
            return type;
        }

        public QuestionarioOpcoesType select(QuestionarioType questionario)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM opcao_questionario " +
                         "WHERE id_questionario = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", questionario.idQuestionario);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            QuestionarioOpcoesType types = new QuestionarioOpcoesType();
            while (dr.Read())
            {
                QuestionarioOpcaoType type = new QuestionarioOpcaoType();
                type.idOpcaoQuestionario = Int32.Parse(dr["id_opcao_questionario"].ToString());
                type.IdQuestionario = Int32.Parse(dr["id_questionario"].ToString());
                type.Descricao = dr["descricao"].ToString();
                types.Add(type);
            }
            return types;
        }


        public int insert(Types.QuestionarioOpcaoType obj)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO opcao_questionario " +
                            "( "+
                                 "id_questionario," +
                                 "descricao" +
                            ") " +
                         "VALUES"+
                          "( "+
                                 "@id_questionario," +
                                 "@descricao" +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_questionario", obj.IdQuestionario);
            cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
            con.Open();
            int id = 0;
            try
            {             
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT MAX(id_opcao_questionario) " +
                                  "FROM opcao_questionario";
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public void delete(QuestionarioType questionario)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM opcao_questionario " +
                         "WHERE id_questionario = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", questionario.idQuestionario);
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
