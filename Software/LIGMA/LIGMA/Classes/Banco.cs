using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIGMA
{
    class StringConexao
    {
        private static String _connectionString = @"Data Source=Victor-HP;Initial Catalog=dbLIGMA;Integrated Security=True";
        
        public static string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public void Deslogar()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("sp_deslogar_usuario", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
