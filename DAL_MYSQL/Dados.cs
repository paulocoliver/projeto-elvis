﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.DAL_MYSQL
{
    public class Dados
    {
        public static string StringConexao
        {
            get
            {
                try
                {
                    if (User.GetUser() == "paulo")
                    {
                        return "server=10.0.2.3;User Id=dbuser;Password=dbuser;database=trabalho_db;Port=3307";
                    }
                }
                catch
                {                    
                }

                return "server=localhost;User Id=root;database=trabalho_db;Convert Zero Datetime=True";                
            }
        }
    }
}
