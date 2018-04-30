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

namespace Gest_EtatCivil
{
    public partial class EtatCivil : Form
    {
        AddEtatPersonneMetier AE = new AddEtatPersonneMetier();
        AddEtatPersonne A = new AddEtatPersonne();
        PeremereMetier pmm = new PeremereMetier();

        public EtatCivil()
        {
            InitializeComponent();
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            foreach (Control T in Controls)
            {
                if (T.GetType() == typeof(TextBox))
                {
                    T.Text = "";
                }
            }
        }

       

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            
            char Sexe;
            if (radio_homme.Checked) Sexe = 'H';
            else Sexe = 'F';
            A = new AddEtatPersonne();
            A._FaiteParFR = txt_DeclFaitPar_Fr.Text;
            A._FaiteParAR = txt_DeclFaitPar_Ar.Text;
            A._DateDr = date_dresse.Value;
            A._SigneFR = txt_SignePar_Fr.Text;
            A._signeAR = txt_SignePar_Ar.Text;
            A._OfficierFr = txt_OfficerEtat_Fr.Text;
            A._OfficierAr = txt_OfficerEtat_Ar.Text;
            A._HamichFR = txt_Hamich_Fr.Text;
            A._HamichAR = txt_Hamich_Ar.Text;
            A._Num = txt_act.Text;
            A._AnneeAct = txt_annee.Text;
            A._Sexe = Sexe;
            AE.AjouterEtat(A);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            AddEtatPersonne M = new AddEtatPersonne();
            M._Num = txt_act.Text;
            M._AnneeAct = txt_annee.Text;
            
            if (AE.RechercheEtat(M) == null)
                MessageBox.Show("introuvable");

            else
            {
                txt_DeclFaitPar_Fr.Text = AE.RechercheEtat(M)._FaiteParFR;
                txt_DeclFaitPar_Ar.Text = AE.RechercheEtat(M)._FaiteParAR;
                DateTime d = new DateTime();
                d = AE.RechercheEtat(M)._DateDr;
                date_dresse.Value = d;
                txt_SignePar_Fr.Text = AE.RechercheEtat(M)._SigneFR;
                txt_SignePar_Ar.Text = AE.RechercheEtat(M)._signeAR;
                txt_OfficerEtat_Fr.Text = AE.RechercheEtat(M)._OfficierFr;
                txt_OfficerEtat_Ar.Text = AE.RechercheEtat(M)._OfficierAr;
                txt_Hamich_Fr.Text = AE.RechercheEtat(M)._HamichFR;
                txt_Hamich_Ar.Text = AE.RechercheEtat(M)._HamichAR;
                label1.Text = txt_act.Text + " " + txt_annee.Text+" exist" ;
                if (AE.RechercheEtat(M)._Sexe == 'H') radio_homme.Checked = true;//ha bugg
                else radio_femme.Checked=true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public string methodeFindAGuy(String anne, String num)
        {
            Personne p = new Personne();
            p._Num = num;
            p._AnneeAct = anne;
            Personne Trouve = new Personne();
            Trouve = pmm.RechercheParents(p);
            if (Trouve != null) return Trouve._NomFR + " " + Trouve._PrenomFR;
            else return "not found";

        }
    }
}
