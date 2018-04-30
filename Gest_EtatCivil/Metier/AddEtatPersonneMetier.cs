using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gest_EtatCivil.DAO;
using Gest_EtatCivil.Models;

namespace Gest_EtatCivil.Metier
{
    public class AddEtatPersonneMetier
    {
        public SqlServerConnection conx = new SqlServerConnection();

        public void AjouterEtat(AddEtatPersonne P)
        {
            conx.Query(@"update Personne set FaiteParFR=@3,FaiteParAR=@4,DateDr=@5,Sexe=@6,SigneFR=@7,signeAR=@8,OfficierFr=@9,
            OfficierAr=@10,HamichFR=@11,HamichAR=@12 where Num=@1 and AnneeAct=@2  ");
            conx.cmd.Parameters.AddWithValue("@1", P._Num);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct);
            conx.cmd.Parameters.AddWithValue("@3", P._FaiteParFR);
            conx.cmd.Parameters.AddWithValue("@4", P._FaiteParAR);
            conx.cmd.Parameters.AddWithValue("@5", P._DateDr);
            conx.cmd.Parameters.AddWithValue("@6", P._Sexe);
            conx.cmd.Parameters.AddWithValue("@7", P._SigneFR);
            conx.cmd.Parameters.AddWithValue("@8", P._signeAR);
            conx.cmd.Parameters.AddWithValue("@9", P._OfficierFr);
            conx.cmd.Parameters.AddWithValue("@10", P._OfficierAr);
            conx.cmd.Parameters.AddWithValue("@11", P._HamichFR);
            conx.cmd.Parameters.AddWithValue("@12", P._HamichAR);
            
            conx.ExecuteNonQuery();
        }


        public AddEtatPersonne RechercheEtat(AddEtatPersonne P)
        {
            AddEtatPersonne p = new AddEtatPersonne();
            conx.Query(@"select Num,AnneeAct,FaiteParFR,FaiteParAR,DateDr,Sexe,SigneFR,signeAR,OfficierFr,OfficierAr,HamichFR,
                            HamichAR from Personne where Num=@1 and  AnneeAct=@2");
            
            conx.cmd.Parameters.AddWithValue("@1", P._Num);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct);
            if (conx.DataTable().Rows.Count > 0)
            {
               
                p._Num = conx.DataTable().Rows[0][0].ToString();
                p._AnneeAct = conx.DataTable().Rows[0][1].ToString();
                p._FaiteParFR = conx.DataTable().Rows[0][2].ToString();
                p._FaiteParAR = conx.DataTable().Rows[0][3].ToString();
                p._DateDr = (DateTime)(conx.DataTable().Rows[0][4]);
                p._Sexe = Convert.ToChar(conx.DataTable().Rows[0][5]);
                p._SigneFR = conx.DataTable().Rows[0][6].ToString();
                p._signeAR = conx.DataTable().Rows[0][7].ToString();
                p._OfficierFr = conx.DataTable().Rows[0][8].ToString();
                p._OfficierAr = conx.DataTable().Rows[0][9].ToString();
                p._HamichFR = conx.DataTable().Rows[0][10].ToString();
                p._HamichAR = conx.DataTable().Rows[0][11].ToString();
            }
            return p;

        }
        public void FindEtat()
        {
            


        }

    }
}
