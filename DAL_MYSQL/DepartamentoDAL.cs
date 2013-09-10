using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Trabalho.DAL_MYSQL
{
    public class DepartamentoDAL
    {
        public Types.DepartamentosType select()
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM DEPARTAMENTO";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Types.DepartamentosType types = new Types.DepartamentosType();
            while (dr.Read())
            {
                Types.DepartamentoType type = new Types.DepartamentoType();
                type.Descricao = dr["DESCRICAO"].ToString();
                type.IdDepartamento = Int32.Parse(dr["ID_DEPARTAMENTO"].ToString());
                types.Add(type);
            }
            return types;
        }

        public Types.DepartamentoType selectRecord(Types.DepartamentoType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT U.* FROM DEPARTAMENTO U  " +
                         "WHERE ID_DEPARTAMENTO = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdDepartamento);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read())
            {
                type.Descricao = dr["DESCRICAO"].ToString();
                type.IdDepartamento = Int32.Parse(dr["ID_DEPARTAMENTO"].ToString());
            }
            return type;
        }

        public int insert(Types.DepartamentoType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO DEPARTAMENTO (descricao) " +
                         "VALUES(@descricao)";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            
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

            return int.Parse(cmd.LastInsertedId.ToString());
        }

        public void delete(Types.DepartamentoType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM DEPARTAMENTO " +
                         "WHERE ID_DEPARTAMENTO = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdDepartamento);
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

        public void update(Types.DepartamentoType type)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "UPDATE DEPARTAMENTO " +
                         "SET DESCRICAO = @descricao " +
                         "WHERE ID_DEPARTAMENTO = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdDepartamento);
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
    }
}
