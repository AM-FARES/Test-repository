using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gest_EtatCivil.Metier;
using Gest_EtatCivil.Models;
using System.IO;
using System.Text.RegularExpressions;

namespace Gest_EtatCivil
{
    public partial class Form_printActe : Form
    {
        ActeMetier AM = new ActeMetier();
        Acte A = new Acte();

        public Form_printActe()
        {
            InitializeComponent();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            CreateActHtml();
        }


        public void CreateActHtml()
        {
            Acte s=new Acte ();
            s._Num=txt_act.Text;
            s._AnneeAct=txt_annee.Text;
            A=AM.RechercheEtat(s);
            if (File.Exists("ok.html"))
            {
                File.Delete("ok.html");
            }
            StreamWriter sw = new StreamWriter("ok.html");

            var amine = new StringBuilder(File.ReadAllText(@"page acte.htm"));
           
            amine.Replace("GETDATE", DateTime.Now.ToShortDateString());
            amine.Replace("ACTENUMBER", A._Num);
            amine.Replace("ACTEYEAR", A._AnneeAct);
            amine.Replace("LNFR", A._NomFR);
            amine.Replace("LNAR", A._NomAR);
            amine.Replace("FNFR", A._PrenomFR);
            amine.Replace("FNAR", A._prenomAR);
            amine.Replace("NATIOFR", A._NationnaliteFR);
            amine.Replace("NATIOAR", A._NationnaliteAR);
            amine.Replace("LIEUFR", A._LieuNaissFR);
            amine.Replace("LIEUAR", A._LieuNaissAR);
            amine.Replace("JOURFR", A._DateNaissance.Day.ToString());
            amine.Replace("MONTHFR", A._DateNaissance.Month.ToString());
            amine.Replace("YEARFR", A._DateNaissance.Year.ToString());
            amine.Replace("PEREFR", A._prenompere);
            amine.Replace("PEREAR", A._prenomperear);
            amine.Replace("MEREFR", A._prenommere);
            amine.Replace("MEREAR", A._prenommerear);
            string [] se=new string[3];
            se=A._DateNaissanceHj.Split('/');
            amine.Replace("JOURAR", se[0]);
            amine.Replace("MONTHAR", se[1]);
            amine.Replace("YEARAR", se[2]);
            sw.AutoFlush = true;
            sw.Write(amine);
            
            string curDir = Directory.GetCurrentDirectory();
           
            curDir = Regex.Replace(curDir, " ", "%20");
            try
            {
               System.Diagnostics.Process.Start("Chrome", String.Format("file:///"+curDir+"/ok.html"));

            }
            catch (Exception)
            {
                System.Diagnostics.Process.Start("file:///" + curDir + "/ok.html");
            }
            
        }

        private void Form_printActe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Menu M = new Form_Menu();
            M.Show();
            this.Close();
        }



    }
}
