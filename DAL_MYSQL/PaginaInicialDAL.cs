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
    public class PaginaInicialDAL
    {
        public PaginaInicialType select(int idAssociacao)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM pagina_inicial " +
                         "WHERE id_associacao = @idAssociacao";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idAssociacao", idAssociacao);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            PaginaInicialType pagina = new PaginaInicialType();

            pagina.IdAssociacao = idAssociacao;
            if (dr.Read())
            {
                pagina.IdPaginaInicial = Int32.Parse(dr["id_pagina_inicial"].ToString());
                pagina.Texto = dr["texto"].ToString();
            }
            return pagina;
        }

        public void save(PaginaInicialType pagina)
        {
            if(!(pagina.IdPaginaInicial > 0)){
                pagina.IdPaginaInicial = insert(pagina.IdAssociacao);
            }
            update(pagina);
        }

        private int insert(int idAssociacao)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO pagina_inicial " +
                            "( " +
                                 "id_associacao " +
                            ") " +
                         "VALUES " +
                          "( " +
                                 "@id_associacao" +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_associacao", idAssociacao);
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


        private void update(PaginaInicialType pagina)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "UPDATE pagina_inicial SET " +
                              "texto = @texto " +
                           "WHERE id_pagina_inicial = @idPaginaInicial";

            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idPaginaInicial", pagina.IdAssociacao);
            cmd.Parameters.AddWithValue("@texto", pagina.Texto);

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
