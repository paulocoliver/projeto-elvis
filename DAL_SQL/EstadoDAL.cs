﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Trabalho.DAL_SQL
{
    public class EstadoDAL
    {
        public Types.EstadosType select(int idPais)
        {
            SqlConnection con = new SqlConnection(Dados.StringConexao);
            string SQL = "select * from estado e "+
                         "join pais p on p.id_pais = e.id_pais "+
                         "where p.id_pais = @idPais " +
                         "order by e.descricao";

            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@idPais", idPais);
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Types.EstadosType estados = new Types.EstadosType();
            while (rd.Read())
            {
                Types.EstadoType estado = new Types.EstadoType();

                estado.idPais    = rd["id_pais"].ToString();
                estado.idEstado  = rd["id_estado"].ToString();
                estado.Sigla     = rd["sigla"].ToString();
                estado.Descricao = rd["descricao"].ToString();

                estados.Add(estado);
            }
            return estados;
        }
    }
}
