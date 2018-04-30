using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_EtatCivil.Models
{
    public class Acte
    {
        public Acte()
        {
        }
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
        public string _DateNaissanceHj { get; set; }
        public string _prenomperear  { get; set; }
        public string _prenommerear  { get; set; }
        public string _prenompere  { get; set; }
        public string _prenommere  { get; set; }
    }
}
