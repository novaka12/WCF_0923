﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WCF_0923_szerver.DatabaseManagement
{
    public class BaseDatabaseManager
    {
        protected BaseDatabaseManager() { }

        public static MySqlConnection Connection
        {
            get
            {
                MySqlConnection connection= new MySqlConnection();
                string connectionstring = "SERVER=localhost;DATABASE=orai0923db;UID=root;PASSWORD=;SSL MODE=none";
                connection.ConnectionString = connectionstring;
                return connection;
            }
        }
    }
}