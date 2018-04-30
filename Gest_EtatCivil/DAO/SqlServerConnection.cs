using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gest_EtatCivil.DAO
{
    public class SqlServerConnection
    {
        public SqlConnection connextion;
        public SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter da;

        public SqlServerConnection()
        {
            connextion = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=Gest_EtatCivil;Integrated Security=True");
            connextion.Open();
        }
        public void Query(string requete)
        {
            cmd = new SqlCommand(requete, connextion);
        }
        public DataTable DataTable()
        {
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public void ExecuteNonQuery()
        {
            cmd.ExecuteNonQuery();
        }
    }
}
