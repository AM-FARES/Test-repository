using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_EtatCivil.Models
{
   public class DesesPersonne
    {
       public int _id_Deses { get; set; }
       public string _Num_Deses { get; set; }
       public string _AnneeAct_Deses { get; set; }
       public DateTime _Date_Deses { get; set; }

       public DesesPersonne() { }

       public DesesPersonne(int id_Deses, string Num_Deses,string AnneeAct_Deses,DateTime Date_Deses)
       {
                 _id_Deses = id_Deses;
                 _Num_Deses=Num_Deses;
                 _AnneeAct_Deses = AnneeAct_Deses;
                 _Date_Deses = Date_Deses;
       }
       

    }
          
}
