using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blog
{
    public static class DataBase
    {
        private const string CONNECTION_STRING = 
        @"
        Server=localhost,1433;
        Database=Blog;
        User ID=sa;
        Password=1q2w3e4r@#$;
        Trust Server Certificate = true";
        public static SqlConnection Connection = new SqlConnection(CONNECTION_STRING);
    }
}