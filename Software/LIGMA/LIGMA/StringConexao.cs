using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIGMA
{
    class StringConexao
    {
        private static String _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbLIGMA;Integrated Security=True";
        public static string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
    }
}
