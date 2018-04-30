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
    public partial class Form_Deses : Form
    {
        DecesMetier D = new DecesMetier();
        DesesPersonne ds = new DesesPersonne();
        

        public Form_Deses()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            ds = new DesesPersonne();
            ds._Num_Deses = txt_act.Text;
            ds._AnneeAct_Deses = txt_annee.Text;
            ds._Date_Deses = date_deses.Value;
            D.AjouterDeses(ds);
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            ds = new DesesPersonne();
            ds._Num_Deses = txt_act.Text;
            ds._AnneeAct_Deses = txt_annee.Text;
            ds._Date_Deses = date_deses.Value;
            D.ModifierDeses(ds);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            DesesPersonne personne_du_recherche = new DesesPersonne();
            personne_du_recherche._Num_Deses = txt_act.Text;
            personne_du_recherche._AnneeAct_Deses = txt_annee.Text;
            if (D.RechercheDeses(personne_du_recherche) == null)
                MessageBox.Show("introuvable");

            else
            {
                txt_act.Text = D.RechercheDeses(personne_du_recherche)._Num_Deses;
                txt_annee.Text = D.RechercheDeses(personne_du_recherche)._AnneeAct_Deses;
                date_deses.Value = D.RechercheDeses(personne_du_recherche)._Date_Deses;
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
