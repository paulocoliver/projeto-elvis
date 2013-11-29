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
    public class FinanceiroDAL
    {
        public FinanceiroType execReader(MySqlDataReader dr)
        {
            FinanceiroType type = new FinanceiroType();
            type.IdFinanceiro = Convert.ToInt32(dr["id_financeiro"].ToString());
            type.IdAssociacao = Convert.ToInt32(dr["id_associacao"].ToString());
            type.Titulo = dr["titulo"].ToString();
            type.Valor = dr.GetDouble("valor");
            type.Data = dr["data"].ToString();
            type.Tipo = dr["tipo"].ToString();
            return type;
        }

        public FinanceiroType selectRecord(int id)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM financeiro " +
                         "WHERE id_financeiro = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            FinanceiroType type = new FinanceiroType();
            if (dr.Read())
            {
                type = execReader(dr);
            }
            return type;
        }

        public FinanceirosType selectByAssociacao(AssociacaoType assoc, string ano, string mes)
        {
            FinanceirosType types = new FinanceirosType();

            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM financeiro " +
                         "WHERE id_associacao = @id " +
                         "AND YEAR(financeiro.`data`) = @ano " +
                         "AND MONTH(financeiro.`data`) = @mes " +
                         "ORDER BY `data`, `id_financeiro`";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", assoc.IdAssociacao);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                types.Add(execReader(dr));
            }
            return types;
        }

        public double selectSaldoAnterior(AssociacaoType assoc, string ano, string mes)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT IFNULL(SUM(valor), 0) AS saldo FROM financeiro " +
                         "WHERE id_associacao = @id "+
                         "AND financeiro.`data` < @data";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", assoc.IdAssociacao);
            cmd.Parameters.AddWithValue("@data", ano + "-" + mes + "-01");

            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            double saldo = 0;
            if (dr.Read())
            {
                saldo = dr.GetDouble("saldo");
            }
            return saldo;
        }



        public int insert(FinanceiroType obj)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO financeiro " +
                            "( " +
                                 "id_associacao," +
                                 "titulo," +
                                 "valor," +
                                 "data," +
                                 "tipo" +
                            ") " +
                         "VALUES" +
                          "( " +
                                 "@id_associacao," +
                                 "@titulo," +
                                 "@valor," +
                                 "@data," +
                                 "@tipo" +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_associacao", obj.IdAssociacao);
            cmd.Parameters.AddWithValue("@titulo", obj.Titulo);
            cmd.Parameters.AddWithValue("@valor", obj.Valor);
            cmd.Parameters.AddWithValue("@data", obj.Data);
            cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
            con.Open();
            int id = 0;
            try
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT MAX(id_financeiro) " +
                                  "FROM financeiro";
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public void update(FinanceiroType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "UPDATE financeiro " +
                         "SET id_associacao = @id_associacao, titulo = @titulo, valor = @valor, data = @data, tipo = @tipo " +
                         "WHERE id_financeiro = @id_financeiro";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_financeiro", type.IdFinanceiro);
            cmd.Parameters.AddWithValue("@id_associacao", type.IdAssociacao);
            cmd.Parameters.AddWithValue("@titulo", type.Titulo);
            cmd.Parameters.AddWithValue("@valor", type.Valor);
            cmd.Parameters.AddWithValue("@data", type.Data);
            cmd.Parameters.AddWithValue("@tipo", type.Tipo);
            
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

        public void delete(FinanceiroType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM financeiro " +
                         "WHERE id_financeiro = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdFinanceiro);
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
