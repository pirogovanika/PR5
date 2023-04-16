﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace shop
{
    class DBMySqlUtils
    {
        public static MySqlConnection GetMySqlConnection(string host, int port, string database, string user, string password)
        {
            String connString = "Server=" + host + ";database=" + database + ";port=" + port.ToString() + ";user=" + user + ";password=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
