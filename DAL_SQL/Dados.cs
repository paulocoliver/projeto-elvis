﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.DAL_SQL
{
    public class Dados
    {
        public static string StringConexao
        {
            get
            {
                return "server=localhost;User Id=root;database=dev_db";
            }
        }
    }
}
