﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace shop
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "shop";
            string user = "root";
            string password = "zqxwec132";

            return DBMySqlUtils.GetMySqlConnection(host, port, database, user, password);
        }
    }
}
