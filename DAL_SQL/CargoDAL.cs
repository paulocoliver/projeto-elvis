using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Trabalho.DAL_SQL
{
    public class CargoDAL
    {
        public Types.CargosType select()
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM CARGO";
            SqlCommand cmd = new SqlCommand(SQL, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Types.CargosType types = new Types.CargosType();
            while (dr.Read())
            {
                Types.CargoType type = new Types.CargoType();
                type.IdCargo = Int32.Parse(dr["ID_CARGO"].ToString());
                type.IdDepartamento = Int32.Parse(dr["ID_DEPARTAMENTO"].ToString());
                type.Descricao = dr["DESCRICAO"].ToString();
                
                types.Add(type);
            }
            return types;
        }

        public Types.CargoType selectRecord(Types.CargoType type)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "SELECT U.* FROM CARGO U  " +
                         "WHERE ID_CARGO = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdCargo);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read())
            {
                type.IdCargo = Int32.Parse(dr["ID_CARGO"].ToString());
                type.IdDepartamento = Int32.Parse(dr["ID_DEPARTAMENTO"].ToString());
                type.Descricao = dr["DESCRICAO"].ToString();
            }
            return type;
        }

        public int insert(Types.CargoType type)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO CARGO (id_departamento,descricao)" +
                         "VALUES( @idDepartamento, @descricao)";
            SqlCommand cmd = new SqlCommand(SQL, con);
 
            cmd.Parameters.AddWithValue("@idDepartamento", type.IdDepartamento);
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

        public void delete(Types.CargoType type)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM CARGO " +
                         "WHERE ID_CARGO = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdCargo);
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

        public void update(Types.CargoType type)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "UPDATE CARGO " +
                         "SET ID_DEPARTAMENTO = @idDepartamento, DESCRICAO = @descricao " +
                         "WHERE ID_CARGO = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", type.IdCargo);
            cmd.Parameters.AddWithValue("@idDepartamento", type.IdDepartamento);
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
