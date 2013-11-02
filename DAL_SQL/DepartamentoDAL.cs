using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Trabalho.DAL_SQL
{
    public class DepartamentoDAL
    {
        public Types.DepartamentosType select()
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM DEPARTAMENTO";
            SqlCommand cmd = new SqlCommand(SQL, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
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
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "SELECT U.* FROM DEPARTAMENTO U  " +
                         "WHERE ID_DEPARTAMENTO = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdDepartamento);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read())
            {
                type.Descricao = dr["DESCRICAO"].ToString();
                type.IdDepartamento = Int32.Parse(dr["ID_DEPARTAMENTO"].ToString());
            }
            return type;
        }

        public int insert(Types.DepartamentoType type)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO DEPARTAMENTO (descricao) " +
                         "VALUES(@descricao)";
            SqlCommand cmd = new SqlCommand(SQL, con);
            
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

            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        public void delete(Types.DepartamentoType type)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM DEPARTAMENTO " +
                         "WHERE ID_DEPARTAMENTO = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
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
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "UPDATE DEPARTAMENTO " +
                         "SET DESCRICAO = @descricao " +
                         "WHERE ID_DEPARTAMENTO = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
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
