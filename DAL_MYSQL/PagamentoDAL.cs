using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Types;

namespace Trabalho.DAL_MYSQL
{
    public class PagamentoDAL
    {
        public PagamentoType selectRecord(int idPagamento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM historico_mensalidade " +
                         "WHERE id_historico_mensalidade = @idPagamento";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idPagamento", idPagamento);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            PagamentoType pagamento = new PagamentoType();
            if (dr.Read())
            {
                pagamento.IdEmpresa = Int32.Parse(dr["id_empresa"].ToString());
                pagamento.IdEmpresa = Int32.Parse(dr["id_historico_mensalidade"].ToString());
                pagamento.Valor = Convert.ToDouble(dr["valor"]);
                pagamento.Data = dr["data"].ToString();
            }
            return pagamento;
        }

        public PagamentosType select(int idEmpresa)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);

            string SQL = "SELECT * FROM historico_mensalidade WHERE id_empresa = @idEmpresa ORDER BY data DESC";

            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);

            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            PagamentosType pagamentos = new PagamentosType();
            while (dr.Read())
            {
                PagamentoType pagamento = new PagamentoType();
                pagamento.IdEmpresa = Int32.Parse(dr["id_empresa"].ToString());
                pagamento.IdEmpresa = Int32.Parse(dr["id_historico_mensalidade"].ToString());
                pagamento.Valor = Convert.ToDouble(dr["valor"]);
                pagamento.Data = dr["data"].ToString();

                pagamentos.Add(pagamento);
            }
            return pagamentos;
        }

        public int insert(PagamentoType pagamento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO historico_mensalidade " +
                            "( " +
                                 "id_empresa, " +
                                 "valor, " +
                                 "data " +
                            ") " +
                         "VALUES " +
                          "( " +
                                 "@idEmpresa, " +
                                 "@valor, " +
                                 "NOW() " +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@idEmpresa", pagamento.IdEmpresa);
            cmd.Parameters.AddWithValue("@valor", pagamento.Valor);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }

            return Convert.ToInt32(cmd.LastInsertedId);
        }

        public void update(PagamentoType pagamento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "UPDATE historico_mensalidade SET " +
                              "id_empresa = @idEmpresa, " +
                              "valor = @valor, " +
                              "data = @data, " +
                           " WHERE id_historico_mensalidade = @idPagamento";

            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idEmpresa", pagamento.IdEmpresa);
            cmd.Parameters.AddWithValue("@valor", pagamento.Valor);
            cmd.Parameters.AddWithValue("@data", pagamento.Data);
            cmd.Parameters.AddWithValue("@idPagamento", pagamento.IdPagamento);

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

        public void delete(PagamentoType pagamento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM historico_mensalidade " +
                         "WHERE id_historico_mensalidade = @idPagamento";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idPagamento", pagamento.IdPagamento);
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
