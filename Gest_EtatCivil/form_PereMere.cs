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
    public partial class form_PereMere : Form
    {
        PeremereMetier PM = new PeremereMetier();
        Personne P = new Personne();

        public form_PereMere()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            P = new Personne();
            P._Num = txt_act.Text;
            P._AnneeAct = txt_annee.Text;
            P._NomFR = txt_nomfr.Text;
            P._NomAR = txt_nomAr.Text;
            P._PrenomFR = txt_prenomfr.Text;
            P._prenomAR = txt_prenomAr.Text;
            P._DateNaissance = Date_naiss.Value;
            P._NationnaliteFR = txt_nationFr.Text;
            P._NationnaliteAR = txt_nationAr.Text;
            P._LieuNaissFR = txt_lieuNaissFr.Text;
            P._LieuNaissAR = txt_lieuNaissAr.Text;
            P._ProfessionFR = txt_ProfessionPere_FR.Text;
            P._professionAR = txt_ProfessionPere_AR.Text;
            P._DomicileFR = txt_domicilFR.Text;
            P._DomicileAR = txt_domicilAR.Text;
            PM.AjouterParents(P);
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Personne P = new Personne();
            P._Num = txt_act.Text;
            P._AnneeAct = txt_annee.Text;
            P._NomFR = txt_nomfr.Text;
            P._NomAR = txt_nomAr.Text;
            P._PrenomFR = txt_prenomfr.Text;
            P._prenomAR = txt_prenomAr.Text;
            P._DateNaissance = Date_naiss.Value;
            P._NationnaliteFR = txt_nationFr.Text;
            P._NationnaliteAR = txt_nationAr.Text;
            P._LieuNaissFR = txt_lieuNaissFr.Text;
            P._LieuNaissAR = txt_lieuNaissAr.Text;
            P._ProfessionFR = txt_ProfessionPere_FR.Text;
            P._professionAR = txt_ProfessionPere_AR.Text;
            P._DomicileFR = txt_domicilFR.Text;
            P._DomicileAR = txt_domicilAR.Text;
            PM.ModifierParents(P);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            Personne personne_du_recherche = new Personne();
            personne_du_recherche._Num = txt_act.Text;
            personne_du_recherche._AnneeAct = txt_annee.Text;
            if (PM.RechercheParents(personne_du_recherche) == null) 
                MessageBox.Show("introuvable");

            else
            {
                txt_nomfr.Text = PM.RechercheParents(personne_du_recherche)._PrenomFR;
                txt_nomAr.Text = PM.RechercheParents(personne_du_recherche)._prenomAR;
                txt_prenomfr.Text = PM.RechercheParents(personne_du_recherche)._PrenomFR;
                txt_prenomAr.Text = PM.RechercheParents(personne_du_recherche)._prenomAR;
                Date_naiss.Value = PM.RechercheParents(personne_du_recherche)._DateNaissance;
                txt_nationFr.Text = PM.RechercheParents(personne_du_recherche)._NationnaliteFR;
                txt_nationAr.Text = PM.RechercheParents(personne_du_recherche)._DomicileAR;
                txt_lieuNaissFr.Text = PM.RechercheParents(personne_du_recherche)._LieuNaissFR;
                txt_lieuNaissAr.Text = PM.RechercheParents(personne_du_recherche)._LieuNaissAR;
                txt_ProfessionPere_FR.Text = PM.RechercheParents(personne_du_recherche)._ProfessionFR;
                txt_ProfessionPere_AR.Text = PM.RechercheParents(personne_du_recherche)._professionAR;
                txt_domicilFR.Text = PM.RechercheParents(personne_du_recherche)._DomicileFR;
                txt_domicilAR.Text = PM.RechercheParents(personne_du_recherche)._DomicileAR;

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
        }
       


    }
}
