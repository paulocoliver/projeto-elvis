using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Trabalho.Types;
using System.Data;

namespace Trabalho.DAL_MYSQL
{
    public class EmpresaDAL
    {
        public Types.EmpresaType execReader(MySqlDataReader dr)
        {
            EmpresaType type = new EmpresaType();

            type.IdEmpresa = Int32.Parse(dr["id_empresa"].ToString());
            type.IdAssociacao = Int32.Parse(dr["id_associacao"].ToString());
            type.IdCidade = Int32.Parse(dr["id_cidade"].ToString());
            //type.IdPlano = Int32.Parse(dr["id_plano"].ToString());
            type.RazaoSocial = dr["razao_social"].ToString();
            type.Senha = dr["senha"].ToString();
            type.Nome = dr["nome_fantasia"].ToString();
            type.CNPJ = dr["cnpj"].ToString();
            type.IE = dr["ie"].ToString();
            type.CEP = dr["cep"].ToString();
            type.Endereco = dr["endereco"].ToString();
            type.Complemento = dr["complemento"].ToString();
            type.Email = dr["email"].ToString();
            type.Site = dr["site"].ToString();
            type.Logo = dr["logo"].ToString();
            type.DataCadastro = dr["data_cadastro"].ToString();

            return type;
        }

        public int insert(Types.EmpresaType empresa)
        {
            MySqlCommand cmd;
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);

            string SQL = "INSERT INTO empresa "+
                            "( "+
                                 "id_associacao,"+
                                 "id_cidade,"+
                                 "razao_social,"+
                                 "nome_fantasia,"+
                                 "cnpj," +
                                 "ie," +
                                 "cep," +
                                 "endereco," +
                                 "complemento," +
                                 "email," +
                                 "senha," +
                                 "site," +
                                 "logo" +
                            ") " +
                         "VALUES"+
                          "( "+
                                 "@id_associacao,"+
                                 "@id_cidade,"+
                                 "@razao_social,"+
                                 "@nome,"+
                                 "@cnpj," +
                                 "@ie," +
                                 "@cep," +
                                 "@endereco," +
                                 "@complemento," +
                                 "@email," +
                                 "@senha," +
                                 "@site," +
                                 "@logo" +
                           ")";

            cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_associacao", empresa.IdAssociacao);
            cmd.Parameters.AddWithValue("@id_cidade", empresa.IdCidade);
            cmd.Parameters.AddWithValue("@razao_social", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@nome", empresa.Nome);
            cmd.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
            cmd.Parameters.AddWithValue("@ie", empresa.IE);
            cmd.Parameters.AddWithValue("@cep", empresa.CEP);
            cmd.Parameters.AddWithValue("@endereco", empresa.Endereco);
            cmd.Parameters.AddWithValue("@complemento", empresa.Complemento);
            cmd.Parameters.AddWithValue("@email", empresa.Email);
            cmd.Parameters.AddWithValue("@senha", empresa.Senha);
            cmd.Parameters.AddWithValue("@site", empresa.Site);
            cmd.Parameters.AddWithValue("@logo", empresa.Logo);
            
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

        public bool update(Types.EmpresaType empresa)
        {
            MySqlCommand cmd;
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);

            string SQL = "UPDATE empresa SET " +
                                 "id_associacao = @id_associacao," +
                                 "id_cidade = @id_cidade," +
                                 "razao_social = @razao_social," +
                                 "nome_fantasia = @nome_fantasia," +
                                 "cnpj = @cnpj," +
                                 "ie = @ie," +
                                 "cep = @cep," +
                                 "endereco = @endereco," +
                                 "complemento = @complemento," +
                                 "email = @email," +
                                 "senha = @senha," +
                                 "site = @site," +
                                 "logo = @logo" +
                            " WHERE id_empresa = @id_empresa";

            cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_associacao", empresa.IdAssociacao);
            cmd.Parameters.AddWithValue("@id_cidade", empresa.IdCidade);
            cmd.Parameters.AddWithValue("@razao_social", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@nome_fantasia", empresa.Nome);
            cmd.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
            cmd.Parameters.AddWithValue("@ie", empresa.IE);
            cmd.Parameters.AddWithValue("@cep", empresa.CEP);
            cmd.Parameters.AddWithValue("@endereco", empresa.Endereco);
            cmd.Parameters.AddWithValue("@complemento", empresa.Complemento);
            cmd.Parameters.AddWithValue("@email", empresa.Email);
            cmd.Parameters.AddWithValue("@senha", empresa.Senha);
            cmd.Parameters.AddWithValue("@site", empresa.Site);
            cmd.Parameters.AddWithValue("@logo", empresa.Logo);
            cmd.Parameters.AddWithValue("@id_empresa", empresa.IdEmpresa);

            try{
                con.Open();
                cmd.ExecuteNonQuery();

            }finally{
                con.Close();
            }
            return true;
        }

        public EmpresaType login(string email, string senha)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);

            string SQL = "SELECT * FROM empresa " +
                         "WHERE email = @email AND SENHA = @senha";
           

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            con.Open();

            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            EmpresaType empresa = new EmpresaType();

            if (dr.Read())
            {
                empresa.IdEmpresa = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
            }
            Console.Write(empresa.IdEmpresa);
            return empresa;
        }

        public EmpresaType selectRecord(int id)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM empresa " +
                         "WHERE id_empresa = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            EmpresaType type = new EmpresaType();
            if (dr.Read())
            {
                type = execReader(dr);
            }
            return type;
        }

        public EmpresasType select()
        {
            EmpresasType types = new EmpresasType();
            return types;
        }

        public EmpresasType selectByAssociacao(AssociacaoType associacao)
        {
            EmpresasType types = new EmpresasType();

            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM empresa " +
                         "WHERE id_associacao = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", associacao.IdAssociacao);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                types.Add(execReader(dr));
            }
            return types;
        }

        public void delete(Types.EmpresaType type)
        {
        }
    }
}
