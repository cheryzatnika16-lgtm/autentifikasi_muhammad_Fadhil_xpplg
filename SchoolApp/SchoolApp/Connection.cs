using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSQl()
        {

            string strConnection = "Server=localhost;Database=pi_school;Uid=root;Pwd";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}

