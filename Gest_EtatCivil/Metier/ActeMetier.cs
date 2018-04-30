using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gest_EtatCivil.DAO;
using Gest_EtatCivil.Models;

namespace Gest_EtatCivil.Metier
{

    public class ActeMetier
    {
        public SqlServerConnection conx = new SqlServerConnection();

        public Acte RechercheEtat(Acte P)
        {
            Acte p = new Acte();
            conx.Query(@"select * from acte where Num=@1 and  AnneeAct=@2");
            conx.cmd.Parameters.AddWithValue("@1", P._Num);
            conx.cmd.Parameters.AddWithValue("@2", P._AnneeAct);
            if (conx.DataTable().Rows.Count > 0)
            {
                p._Num = conx.DataTable().Rows[0][0].ToString();
                p._AnneeAct = conx.DataTable().Rows[0][1].ToString();
                p._NomFR= conx.DataTable().Rows[0][2].ToString();
                p._NomAR= conx.DataTable().Rows[0][3].ToString();
                p._PrenomFR = conx.DataTable().Rows[0][4].ToString();
                p._prenomAR = conx.DataTable().Rows[0][5].ToString();
                p._NationnaliteFR = conx.DataTable().Rows[0][6].ToString();
                p._NationnaliteAR = conx.DataTable().Rows[0][7].ToString();
                p._LieuNaissFR = conx.DataTable().Rows[0][8].ToString();
                p._LieuNaissAR = conx.DataTable().Rows[0][9].ToString();
                p._DateNaissance = (DateTime)(conx.DataTable().Rows[0][10]);
                p._DateNaissanceHj = conx.DataTable().Rows[0][11].ToString();
                p._prenommerear = conx.DataTable().Rows[0][13].ToString();
                p._prenommerear= conx.DataTable().Rows[0][14].ToString();
                p._prenompere = conx.DataTable().Rows[0][15].ToString();
                p._prenommere= conx.DataTable().Rows[0][16].ToString();
            }
            return p;
        }

     

    }
}
