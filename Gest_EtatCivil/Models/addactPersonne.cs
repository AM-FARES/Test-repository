using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_EtatCivil.Models
{
    class addactPersonne
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
        public string _ProfessionFR { get; set; }
        public string _professionAR { get; set; }
        public string _HamichFR { get; set; }
        public string _HamichAR { get; set; }
        public string _Num_Pere { get; set; }
        public string _Num_Mere { get; set; }
        public string _AnneeAct_Pere { get; set; }
        public string _AnneeAct_Mere { get; set; }
        public string _num_fils { get; set; }
        public string _AnneeAct_fils { get; set; }

        public addactPersonne() { }

        public addactPersonne(string Num, string AnneeAct, string NomFR, string NomAR, string PrenomFR, string prenomAR, DateTime DateNaissance, string NationnaliteFR, string NationnaliteAR, string LieuNaissFR, string LieuNaissAR, string Num_Pere, string Num_Mere, string AnneeAct_Pere, string AnneeAct_Mere, string num_fils, string AnneeAct_fils)
        {
            _Num = Num;
            _AnneeAct = AnneeAct;
            _NomFR = NomFR;
            _NomAR = NomAR;
            _PrenomFR = PrenomFR;
            _prenomAR = prenomAR;
            _DateNaissance = DateNaissance;
            _NationnaliteFR = NationnaliteFR;
            _NationnaliteAR = NationnaliteAR;
            _LieuNaissFR = LieuNaissFR;
            _LieuNaissAR = LieuNaissAR;
            _Num_Pere = Num_Pere;
            _Num_Mere = Num_Mere;
            _AnneeAct_Pere = AnneeAct_Pere;
            _AnneeAct_Mere = AnneeAct_Mere;
            _num_fils = num_fils;
            _AnneeAct_fils = AnneeAct_fils;
        }



    }
}
