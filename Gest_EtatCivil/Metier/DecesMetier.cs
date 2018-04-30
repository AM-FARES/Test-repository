using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gest_EtatCivil.DAO;
using Gest_EtatCivil.Models;

namespace Gest_EtatCivil.Metier
{
    public class DecesMetier
    {
        public SqlServerConnection conx = new SqlServerConnection();

        public void AjouterDeses(DesesPersonne P)
        {
            conx.Query(@"insert into Deces(Num_Deses, AnneeAct_Deses, Date_Deses)
                            values (@1,@2,@3)");
            conx.cmd.Parameters.AddWithValue("@1", P._Num_Deses);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct_Deses);
            conx.cmd.Parameters.AddWithValue("@3", P._Date_Deses);
            conx.ExecuteNonQuery();
        }
        public void ModifierDeses(DesesPersonne P)
        {

            conx.Query(@"update Deces set Date_Deses=@3 where Num_Deses=@1 and AnneeAct_Deses=@2 ");
            conx.cmd.Parameters.AddWithValue("@1", P._Num_Deses);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct_Deses);
            conx.cmd.Parameters.AddWithValue("@3", P._Date_Deses);
            conx.ExecuteNonQuery();
        }
        public DesesPersonne RechercheDeses(DesesPersonne P)
        {
            DesesPersonne p = null;
            conx.Query(@"select Id_Deses,Num_Deses, AnneeAct_Deses, Date_Deses from Deces where Num_Deses=@1 and AnneeAct_Deses=@2");
            conx.cmd.Parameters.AddWithValue("@1", P._Num_Deses);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct_Deses);
            if (conx.DataTable().Rows.Count > 0)
            {
                int i = new int();
                i = Convert.ToInt16(conx.DataTable().Rows[0][0].ToString());
                DateTime T = new DateTime();
                T = Convert.ToDateTime(conx.DataTable().Rows[0][3]);
                p = new DesesPersonne(i, conx.DataTable().Rows[0][1].ToString(),
                    conx.DataTable().Rows[0][2].ToString(), (DateTime)conx.DataTable().Rows[0][3]);
            }
            return p;
        }
        
    }
}
