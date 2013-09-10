using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Trabalho.DAL_MYSQL
{
    public class EmpresarioDAL
    {
        public void insert(Types.EmpresarioType empresario)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO empresario (nome,sobrenome,email,RG,CPF,endereco,id_bairro) " +
                         "VALUES(@nome,@sobrenome,@email,@RG,@CPF,@endereco,@id_bairro)";
            
            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@nome", empresario.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", empresario.Sobrenome);
            cmd.Parameters.AddWithValue("@email", empresario.Email);
            cmd.Parameters.AddWithValue("@RG", empresario.RG);
            cmd.Parameters.AddWithValue("@CPF", empresario.CPF);
            cmd.Parameters.AddWithValue("@endereco", empresario.Endereco);
            cmd.Parameters.AddWithValue("@id_bairro", empresario.idBairro);
            
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

        public Types.EmpresariosType select()
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "select * from empresario order by nome";

            MySqlCommand cmd = new MySqlCommand(SQL, con);
            con.Open();

            MySqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Types.EmpresariosType empresarios = new Types.EmpresariosType();
            while (rd.Read())
            {
                Types.EmpresarioType empresario = new Types.EmpresarioType();

                empresario.idEmpresario = rd["id_empresario"].ToString();
                empresario.idBairro     = rd["id_bairro"].ToString();
                empresario.Nome         = rd["nome"].ToString();
                empresario.Sobrenome    = rd["sobrenome"].ToString();
                empresario.Email        = rd["email"].ToString();
                empresario.CPF          = rd["CPF"].ToString();
                empresario.RG           = rd["RG"].ToString();
                empresario.Endereco     = rd["endereco"].ToString();

                empresarios.Add(empresario);
            }
            return empresarios;
        }
    }
}
