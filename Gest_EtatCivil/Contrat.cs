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
    public partial class Contrat : Form
    {
        AddactPersonneMetier AP = new AddactPersonneMetier();
        addactPersonne A = new addactPersonne();
        PeremereMetier pmm = new PeremereMetier();

        public Contrat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            A = new addactPersonne();
            A._Num = txt_act.Text;
            A._AnneeAct = txt_annee.Text;
            A._NomFR = txt_nomfr.Text;
            A._NomAR = txt_nomAr.Text;
            A._PrenomFR = txt_prenomfr.Text;
            A._prenomAR = txt_prenomAr.Text;
            A._DateNaissance = Date_naiss.Value;
            A._NationnaliteFR = txt_nationFr.Text;
            A._NationnaliteAR = txt_nationAr.Text;
            A._LieuNaissFR = txt_lieuNaissFr.Text;
            A._LieuNaissAR = txt_lieuNaissAr.Text;
            A._Num_Pere = txt_numPer.Text;
            A._Num_Mere = txt_numMer.Text;
            A._AnneeAct_Pere = txt_anneePer.Text;
            A._AnneeAct_Mere = txt_AnneeMer.Text;
            A._num_fils = txt_act.Text;
            A._AnneeAct_fils = txt_annee.Text;
            int x=AP.AjouterContrat(A);
            if (x == 0)
            {
                MessageBox.Show("erreur", "Erreur");
            }
            else
            {
               int a= AP.PereMereFils(txt_numPer.Text, txt_numMer.Text, txt_anneePer.Text, txt_AnneeMer.Text, txt_act.Text, txt_annee.Text);        
                if(a>0) MessageBox.Show("Bien ajouté");
                else MessageBox.Show("erreur");
            }
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
            txt_numMer.Clear(); txt_numPer.Clear();
            txt_AnneeMer.Clear(); txt_anneePer.Clear();
            txt_found_mer.Clear(); txt_found_per.Clear();
        }

        private void txt_anneePer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_numPer_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string methodeFindAGuy(String anne,String num)
        {
            Personne p = new Personne();
            p._Num = num;
            p._AnneeAct = anne;
            Personne Trouve = new Personne();
            Trouve = pmm.RechercheParents(p);
            if (Trouve!= null) return Trouve._NomFR + " " + Trouve._PrenomFR;
            else return "not found";
            
        }

        private void txt_AnneeMer_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txt_numMer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_found_per.Text=methodeFindAGuy(txt_anneePer.Text, txt_numPer.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_found_mer.Text = methodeFindAGuy(txt_AnneeMer.Text, txt_numMer.Text);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            addactPersonne personne_du_recherche = new addactPersonne();
            personne_du_recherche._Num = txt_act.Text;
            personne_du_recherche._AnneeAct = txt_annee.Text;
            if (AP.RechercheParents(personne_du_recherche) == null)
                MessageBox.Show("introuvable");

            else
            {
                txt_nomfr.Text = AP.RechercheParents(personne_du_recherche)._PrenomFR;
                txt_nomAr.Text = AP.RechercheParents(personne_du_recherche)._prenomAR;
                txt_prenomfr.Text = AP.RechercheParents(personne_du_recherche)._PrenomFR;
                txt_prenomAr.Text = AP.RechercheParents(personne_du_recherche)._prenomAR;
                Date_naiss.Value = AP.RechercheParents(personne_du_recherche)._DateNaissance;
                txt_nationFr.Text = AP.RechercheParents(personne_du_recherche)._NationnaliteFR;
                txt_nationAr.Text = AP.RechercheParents(personne_du_recherche)._NationnaliteAR;
                txt_lieuNaissFr.Text = AP.RechercheParents(personne_du_recherche)._LieuNaissFR;
                txt_lieuNaissAr.Text = AP.RechercheParents(personne_du_recherche)._LieuNaissAR;
                
                txt_numMer.Text = AP.RechercheParents(personne_du_recherche)._Num_Mere;
                txt_numPer.Text = AP.RechercheParents(personne_du_recherche)._Num_Pere;
                txt_AnneeMer.Text = AP.RechercheParents(personne_du_recherche)._AnneeAct_Mere;
                txt_anneePer.Text = AP.RechercheParents(personne_du_recherche)._AnneeAct_Pere;

                
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            addactPersonne A = new addactPersonne();
            A._Num = txt_act.Text;
            A._AnneeAct = txt_annee.Text;
            A._NomFR = txt_nomfr.Text;
            A._NomAR = txt_nomAr.Text;
            A._PrenomFR = txt_prenomfr.Text;
            A._prenomAR = txt_prenomAr.Text;
            A._DateNaissance = Date_naiss.Value;
            A._NationnaliteFR = txt_nationFr.Text;
            A._NationnaliteAR = txt_nationAr.Text;
            A._LieuNaissFR = txt_lieuNaissFr.Text;
            A._LieuNaissAR = txt_lieuNaissAr.Text;
            A._Num_Pere = txt_numPer.Text;
            A._Num_Mere = txt_numMer.Text;
            A._AnneeAct_Pere = txt_anneePer.Text;
            A._AnneeAct_Mere = txt_AnneeMer.Text;
            AP.ModifierActe(A);
        }
        
    }
}
