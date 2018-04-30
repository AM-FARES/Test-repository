using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_EtatCivil.Models
{
    public class AddEtatPersonne
    {
        public string _Num { get; set; }
        public string _AnneeAct { get; set; }
        public string _NomFR { get; set; }
        public string _NomAR { get; set; }
        public string _PrenomFR { get; set; }
        public string _prenomAR { get; set; }
        public string _NationnaliteFR { get; set; }
        public string _NationnaliteAR { get; set; }
        public string _LieuNaissFR { get; set; }
        public string _LieuNaissAR { get; set; }
        public DateTime _DateNaissance { get; set; }
        public char _Sexe { get; set; }
        public string _DomicileFR { get; set; }
        public string _DomicileAR { get; set; }
        public DateTime _DateDr { get; set; }
        public string _FaiteParFR { get; set; }
        public string _FaiteParAR { get; set; }
        public string _SigneFR { get; set; }
        public string _signeAR { get; set; }
        public string _OfficierFr { get; set; }
        public string _OfficierAr { get; set; }
        public string _ProfessionFR { get; set; }
        public string _professionAR { get; set; }
        public string _HamichFR { get; set; }
        public string _HamichAR { get; set; }
        public string _Num_Pere { get; set; }
        public string _Num_Mere { get; set; }
        public string _AnneeAct_Pere { get; set; }
        public string _AnneeAct_Mere { get; set; }

        public AddEtatPersonne() { }

        public AddEtatPersonne(string Num, string AnneeAct, string FaiteParFR, string FaiteParAR, DateTime DateDr, char Sexe, string SigneFR, string signeAR, string OfficierFr, string OfficierAr, string HamichFR, string HamichAR, string Num_Pere, string Num_Mere, string AnneeAct_Pere, string AnneeAct_Mere)
        {
            _Num = Num;
            _AnneeAct = AnneeAct;
            _FaiteParFR = FaiteParFR;
            _FaiteParAR = FaiteParAR;
            _DateDr = DateDr;
            _Sexe = Sexe;
            _SigneFR = SigneFR;
            _signeAR = signeAR;
            _OfficierFr = OfficierFr;
            _OfficierAr = _OfficierAr;
            _HamichFR = HamichFR;
            _HamichAR = HamichAR;
            _Num_Pere = Num_Pere;
            _Num_Mere = Num_Mere;
            _AnneeAct_Pere = AnneeAct_Pere;
            _AnneeAct_Mere = AnneeAct_Mere;
        }
    }
}
