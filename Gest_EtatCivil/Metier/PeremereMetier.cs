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
    class PeremereMetier
    {
        public SqlServerConnection conx = new SqlServerConnection();

        /* ajout*/
        public void AjouterParents(Personne P)
        {
            conx.Query(@"insert into Personne(Num,AnneeAct,NomFR,NomAR,PrenomFR,prenomAR,DateNaissance,NationnaliteFR,NationnaliteAR,LieuNaissFR,LieuNaissAR,ProfessionFR,professionAR,DomicileFR,DomicileAR)
                            values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15)");
            conx.cmd.Parameters.AddWithValue("@1", P._Num);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct);
            conx.cmd.Parameters.AddWithValue("@3", P._NomFR);
            conx.cmd.Parameters.AddWithValue("@4", P._NomAR);
            conx.cmd.Parameters.AddWithValue("@5", P._PrenomFR);
            conx.cmd.Parameters.AddWithValue("@6", P._prenomAR);
            conx.cmd.Parameters.AddWithValue("@7", P._DateNaissance);
            conx.cmd.Parameters.AddWithValue("@8", P._NationnaliteFR);
            conx.cmd.Parameters.AddWithValue("@9", P._NationnaliteAR);
            conx.cmd.Parameters.AddWithValue("@10", P._LieuNaissFR);
            conx.cmd.Parameters.AddWithValue("@11", P._LieuNaissAR);
            conx.cmd.Parameters.AddWithValue("@12", P._ProfessionFR);
            conx.cmd.Parameters.AddWithValue("@13", P._professionAR);
            conx.cmd.Parameters.AddWithValue("@14", P._DomicileFR);
            conx.cmd.Parameters.AddWithValue("@15", P._DomicileAR);
            conx.ExecuteNonQuery();
        }

        public void ModifierParents(Personne P)
        {
        
            conx.Query(@"update 
                        Personne set NomFR=@3,NomAR=@4,PrenomFR=@5,prenomAR=@6,DateNaissance=@7,NationnaliteFR=@8,
                        NationnaliteAR=@9 ,LieuNaissFR=@10,LieuNaissAR=@11,ProfessionFR=@12,professionAR=@13,DomicileFR=14,DomicileAR=@15  
                        where Num=@1 and  AnneeAct=@2 ");
            conx.cmd.Parameters.AddWithValue("@1", P._Num);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct);
            conx.cmd.Parameters.AddWithValue("@3", P._NomFR);
            conx.cmd.Parameters.AddWithValue("@4", P._NomAR);
            conx.cmd.Parameters.AddWithValue("@5", P._PrenomFR);
            conx.cmd.Parameters.AddWithValue("@6", P._prenomAR);
            conx.cmd.Parameters.AddWithValue("@7", P._DateNaissance);
            conx.cmd.Parameters.AddWithValue("@8", P._NationnaliteFR);
            conx.cmd.Parameters.AddWithValue("@9", P._NationnaliteAR);
            conx.cmd.Parameters.AddWithValue("@10", P._LieuNaissFR);
            conx.cmd.Parameters.AddWithValue("@11", P._LieuNaissAR);
            conx.cmd.Parameters.AddWithValue("@12", P._ProfessionFR);
            conx.cmd.Parameters.AddWithValue("@13", P._professionAR);
            conx.cmd.Parameters.AddWithValue("@14", P._DomicileFR);
            conx.cmd.Parameters.AddWithValue("@15", P._DomicileAR);
            conx.ExecuteNonQuery();
        }

        public Personne RechercheParents(Personne P)
        {
            
            Personne p = null;
            conx.Query(@"select Num,AnneeAct,NomFR,NomAR,PrenomFR,prenomAR,NationnaliteFR,NationnaliteAR ,LieuNaissFR,LieuNaissAR,DateNaissance,
                            DomicileFR,DomicileAR,ProfessionFR,professionAR from Personne where Num=@1 and  AnneeAct=@2");
            conx.cmd.Parameters.AddWithValue("@1", P._Num);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct);
            if (conx.DataTable().Rows.Count > 0) {
                DateTime T = new DateTime();
                T = Convert.ToDateTime(conx.DataTable().Rows[0][10]);
                p = new Personne(conx.DataTable().Rows[0][0].ToString(), conx.DataTable().Rows[0][1].ToString(), conx.DataTable().Rows[0][2].ToString(), conx.DataTable().Rows[0][3].ToString(),
                               conx.DataTable().Rows[0][4].ToString(), conx.DataTable().Rows[0][5].ToString(), conx.DataTable().Rows[0][6].ToString(), conx.DataTable().Rows[0][7].ToString(),
                               conx.DataTable().Rows[0][8].ToString(), conx.DataTable().Rows[0][9].ToString(),(DateTime) conx.DataTable().Rows[0][10], conx.DataTable().Rows[0][11].ToString(),
                               conx.DataTable().Rows[0][12].ToString(), conx.DataTable().Rows[0][13].ToString(), conx.DataTable().Rows[0][14].ToString());
            }
            return p;

        }
    }
}
