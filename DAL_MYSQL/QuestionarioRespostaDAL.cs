using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.DAL_MYSQL;
using Trabalho.Types;

namespace Trabalho.DAL_MYSQL
{
    public class QuestionarioRespostaDAL{
    
        private MySqlConnection _con;
        private MySqlTransaction _transaction;

        public QuestionarioRespostaDAL() {
            _con = new MySqlConnection(Dados.StringConexao);
        }

        public QuestionarioRespostasType select(int idEmpresa, int idQuestionario)
        {
            string SQL = "SELECT * FROM resposta_empresa " +
                         "WHERE id_empresa = @idEmpresa AND id_questionario = @idQuestionario";

            MySqlCommand cmd = new MySqlCommand(SQL, _con);
            cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
            cmd.Parameters.AddWithValue("@idQuestionario", idQuestionario);
           
            _con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            QuestionarioRespostasType respostas = new QuestionarioRespostasType();
            while (dr.Read())
            {
                QuestionarioRespostaType resposta = new QuestionarioRespostaType();

                resposta.idQuestionario = Int32.Parse(dr["id_questionario"].ToString());
                resposta.idEmpresa = Int32.Parse(dr["id_empresa"].ToString());
                resposta.Valor = dr["resposta"].ToString();

                respostas.Add(resposta);
            }
            _con.Close();

            return respostas;
        }

        public bool save(QuestionarioType questionario, int id_empresa) {

            try {
                _con.Open();
                _transaction = _con.BeginTransaction();
               
                _delete(id_empresa, questionario.idQuestionario);
                _insert(questionario);

                _transaction.Commit();

            }catch(Exception error){

                _transaction.Rollback();
                _con.Close();
                throw error;

            }finally{

                _con.Close();
            }
            return true;
        }

        private void _insert(QuestionarioType questionario)
        {
            QuestionarioRespostasType respostas = questionario.Respostas;
            foreach (QuestionarioRespostaType resposta in respostas) { 
                string SQL = "INSERT INTO resposta_empresa " +
                                "( " +
                                     "id_questionario, " +
                                     "id_empresa, " +
                                     "resposta " +
                                ") " +
                             "VALUES " +
                              "( " +
                                     "@id_questionario, " +
                                     "@id_empresa, " +
                                     "@resposta " +
                               ")";

                MySqlCommand cmd = new MySqlCommand(SQL, _con);
                cmd.Transaction = _transaction;

                cmd.Parameters.AddWithValue("@id_questionario", resposta.idQuestionario);
                cmd.Parameters.AddWithValue("@id_empresa", resposta.idEmpresa);
                cmd.Parameters.AddWithValue("@resposta", resposta.Valor);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally{}
            }
        }

        private void _delete(int id_empresa, int idQuestionario)
        {
            string SQL = "DELETE FROM resposta_empresa " +
                         "WHERE id_empresa = @id_empresa AND id_questionario = @idQuestionario";
            MySqlCommand cmd = new MySqlCommand(SQL, _con);
            cmd.Parameters.AddWithValue("@id_empresa", id_empresa);
            cmd.Parameters.AddWithValue("@idQuestionario", idQuestionario);
            cmd.Transaction = _transaction;

            try{
                cmd.ExecuteNonQuery();
            }
            finally{}
        }
    }
}
