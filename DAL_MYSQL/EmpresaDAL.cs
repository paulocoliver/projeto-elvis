using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trabalho.DAL_MYSQL
{
    public class EmpresaDAL
    {
        public void insert(Types.EmpresaType empresa)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO empresa "+
                            "( "+
                                 "id_associacao,"+
                                 "id_cidade,"+
                                 "razao_social,"+
                                 "nome,"+
                                 "cnpj," +
                                 "ie," +
                                 "cep," +
                                 "endereco," +
                                 "complemento," +
                                 "email," +
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
                                 "@site," +
                                 "@logo" +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_associacao", empresa.IdAssociacao);
            cmd.Parameters.AddWithValue("@id_cidade", empresa.IdCidade);
            cmd.Parameters.AddWithValue("@razao_social", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@nome", empresa.Nome);
            cmd.Parameters.AddWithValue("@ie", empresa.IE);
            cmd.Parameters.AddWithValue("@cep", empresa.CEP);
            cmd.Parameters.AddWithValue("@endereco", empresa.Endereco);
            cmd.Parameters.AddWithValue("@complemento", empresa.Complemento);
            cmd.Parameters.AddWithValue("@email", empresa.Email);
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
        }
    }
}
