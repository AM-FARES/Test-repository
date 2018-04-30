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
    class AddactPersonneMetier
    {
        public SqlServerConnection conx = new SqlServerConnection();

        /* ajout*/
        // 
        public int AjouterContrat(addactPersonne P)
        {
            conx.Query(@"insert into Personne(Num,AnneeAct,NomFR,NomAR,PrenomFR,prenomAR,DateNaissance,NationnaliteFR,NationnaliteAR,LieuNaissFR,LieuNaissAR) 
                        values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11)
                        ");
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
            conx.cmd.Parameters.AddWithValue("@12", P._Num_Pere);
            conx.cmd.Parameters.AddWithValue("@13", P._Num_Mere);
            conx.cmd.Parameters.AddWithValue("@14", P._AnneeAct_Pere);
            conx.cmd.Parameters.AddWithValue("@15", P._AnneeAct_Mere);
            conx.cmd.Parameters.AddWithValue("@16", P._num_fils);
            conx.cmd.Parameters.AddWithValue("@17", P._AnneeAct_fils);
            if (conx.cmd.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else {
                return 0;
            }
           
        }

        public int PereMereFils(String Num_Pere, String Num_Mere, String AnneeAct_Pere, String AnneeAct_Mere, String num_fils, String AnneeAct_fils)
        {
            conx.Query(@"insert into PereMere(Num_Pere,Num_Mere,AnneeAct_Pere,AnneeAct_Mere,num_fils,AnneeAct_fils)
                        values(@12,@13,@14,@15,@16,@17)");
            conx.cmd.Parameters.AddWithValue("@12", Num_Pere);
            conx.cmd.Parameters.AddWithValue("@13", Num_Mere);
            conx.cmd.Parameters.AddWithValue("@14", AnneeAct_Pere);
            conx.cmd.Parameters.AddWithValue("@15", AnneeAct_Mere);
            conx.cmd.Parameters.AddWithValue("@16", num_fils);
            conx.cmd.Parameters.AddWithValue("@17", AnneeAct_fils);
            return conx.cmd.ExecuteNonQuery();
           
        }

        public addactPersonne RechercheParents(addactPersonne P)
        {
            addactPersonne p = null;
            conx.Query(@"select Num,AnneeAct,NomFR,NomAR,PrenomFR,prenomAR,DateNaissance,NationnaliteFR,NationnaliteAR ,LieuNaissFR,LieuNaissAR,
                          Num_Pere,Num_Mere,AnneeAct_Pere,AnneeAct_Mere, num_fils,AnneeAct_fils from Personne, PereMere where Num=@1 and  AnneeAct=@2");
            //
            conx.cmd.Parameters.AddWithValue("@1", P._Num);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct);
            if (conx.DataTable().Rows.Count > 0)
            {
                DateTime T = new DateTime();
                T = Convert.ToDateTime(conx.DataTable().Rows[0][6]);
                p = new addactPersonne(conx.DataTable().Rows[0][0].ToString(), conx.DataTable().Rows[0][1].ToString(), conx.DataTable().Rows[0][2].ToString(), conx.DataTable().Rows[0][3].ToString(),
                               conx.DataTable().Rows[0][4].ToString(), conx.DataTable().Rows[0][5].ToString(), (DateTime)conx.DataTable().Rows[0][6], conx.DataTable().Rows[0][7].ToString(),
                               conx.DataTable().Rows[0][8].ToString(), conx.DataTable().Rows[0][9].ToString(), conx.DataTable().Rows[0][10].ToString(), conx.DataTable().Rows[0][11].ToString(),
                               conx.DataTable().Rows[0][12].ToString(), conx.DataTable().Rows[0][13].ToString(), conx.DataTable().Rows[0][14].ToString(),
                               conx.DataTable().Rows[0][15].ToString(), conx.DataTable().Rows[0][16].ToString());
            }
            return p;
        }

        public int ModifierActe(addactPersonne P)
        {

            conx.Query(@"update Personne set 
                            NomFR=@3, NomAR=@4, PrenomFR=@5, prenomAR=@6, DateNaissance=@7, NationnaliteFR=@8, NationnaliteAR=@9, 
                        LieuNaissFR=@10, LieuNaissAR=@11 
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
            conx.cmd.Parameters.AddWithValue("@12", P._Num_Pere);
            conx.cmd.Parameters.AddWithValue("@13", P._Num_Mere);
            conx.cmd.Parameters.AddWithValue("@14", P._AnneeAct_Pere);
            conx.cmd.Parameters.AddWithValue("@15", P._AnneeAct_Mere);
            //conx.cmd.Parameters.AddWithValue("@16", P._num_fils);
            //conx.cmd.Parameters.AddWithValue("@17", P._AnneeAct_fils);
            if (conx.cmd.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int PereMereFils2(String Num_Pere, String Num_Mere, String AnneeAct_Pere, String AnneeAct_Mere, String num_fils, String AnneeAct_fils)
        {
            conx.Query(@"update PereMere set Num_Pere=@12, Num_Mere=@13, AnneeAct_Pere=@14 ,AnneeAct_Mere=@15,num_fils=@16,AnneeAct_fils=@17
                        where Num=@1 and  AnneeAct=@2");
            conx.cmd.Parameters.AddWithValue("@12", Num_Pere);
            conx.cmd.Parameters.AddWithValue("@13", Num_Mere);
            conx.cmd.Parameters.AddWithValue("@14", AnneeAct_Pere);
            conx.cmd.Parameters.AddWithValue("@15", AnneeAct_Mere);
            conx.cmd.Parameters.AddWithValue("@16", num_fils);
            conx.cmd.Parameters.AddWithValue("@17", AnneeAct_fils);
            return conx.cmd.ExecuteNonQuery();
        }

    }
}
