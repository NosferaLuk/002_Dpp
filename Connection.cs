using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Blog
{
    public class Connection
    {
        private readonly string CONNECTION_STRING = 
                @"Server=localhost,1433;
                Database=Blog;
                User ID=sa;
                Password=1q2w3e4r@#$;
                Trust Server Certificate = true"
                ;
        public Connection()
            => new SqlConnection(CONNECTION_STRING);
    }
}