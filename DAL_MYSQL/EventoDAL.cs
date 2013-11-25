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
    public class EventoDAL
    {
        public EventoType selectRecord(int idEvento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "SELECT * FROM evento " +
                         "WHERE id_evento = @idEvento";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            EventoType evento = new EventoType();
            if (dr.Read())
            {
                evento.idEvento = Int32.Parse(dr["id_evento"].ToString());
                evento.idAssociacao = Int32.Parse(dr["id_associacao"].ToString());
                evento.Titulo = dr["titulo"].ToString();
                evento.Descricao = dr["descricao"].ToString();
                evento.Local = dr["local"].ToString();
                evento.dataIni = dr["data_ini"].ToString();
                evento.dataEnd = dr["data_fim"].ToString();
            }
            return evento;
        }

        public EventosType select(int idAssociacao)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);

            string SQL = "SELECT * FROM evento WHERE id_associacao = @idAssociacao";

            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idAssociacao", idAssociacao);

            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            EventosType eventos = new EventosType();
            while (dr.Read())
            {
                EventoType evento = new EventoType();
                evento.idEvento = Int32.Parse(dr["id_evento"].ToString());
                evento.idAssociacao = Int32.Parse(dr["id_associacao"].ToString());
                evento.Titulo = dr["titulo"].ToString();
                evento.Descricao = dr["descricao"].ToString();
                evento.Local = dr["local"].ToString();
                evento.dataIni = dr["data_ini"].ToString();
                evento.dataEnd = dr["data_fim"].ToString();

                eventos.Add(evento);
            }
            return eventos;
        }

        public int insert(EventoType evento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "INSERT INTO evento " +
                            "( " +
                                 "id_associacao, " +
                                 "titulo, " +
                                 "descricao, " +
                                 "local, " +
                                 "data_ini, " +
                                 "data_fim " +
                            ") " +
                         "VALUES " +
                          "( " +
                                 "@id_associacao, " +
                                 "@titulo, " +
                                 "@descricao, " +
                                 "@local, " +
                                 "@data_ini, " +
                                 "@data_fim " +
                           ")";

            MySqlCommand cmd = new MySqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@id_associacao", evento.idAssociacao);
            cmd.Parameters.AddWithValue("@titulo", evento.Titulo);
            cmd.Parameters.AddWithValue("@descricao", evento.Descricao);
            cmd.Parameters.AddWithValue("@local", evento.Local);
            cmd.Parameters.AddWithValue("@data_ini", evento.dataIni);
            cmd.Parameters.AddWithValue("@data_fim", evento.dataEnd);

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

        public void update(EventoType evento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "UPDATE evento SET " +
                              "id_associacao = @id_associacao, " +
                              "titulo = @titulo, " +
                              "descricao = @descricao, " +
                              "local = @local, " +
                              "data_ini = @data_ini, " +
                              "data_fim = @data_fim " +
                           " WHERE id_evento = @id_evento";

            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_associacao", evento.idAssociacao);
            cmd.Parameters.AddWithValue("@titulo", evento.Titulo);
            cmd.Parameters.AddWithValue("@descricao", evento.Descricao);
            cmd.Parameters.AddWithValue("@local", evento.Local);
            cmd.Parameters.AddWithValue("@data_ini", evento.dataIni);
            cmd.Parameters.AddWithValue("@data_fim", evento.dataEnd);
            cmd.Parameters.AddWithValue("@id_evento", evento.idEvento);

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

        public void delete(EventoType evento)
        {
            MySqlConnection con = new MySqlConnection(Dados.StringConexao);
            string SQL = "DELETE FROM evento " +
                         "WHERE id_evento = @id_evento";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_evento", evento.idEvento);
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
