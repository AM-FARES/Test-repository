using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gest_EtatCivil
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            
        }

        private void btn_ajouter_contrat_Click(object sender, EventArgs e)
        {
            //panel2.Visible = true;
            SidePanel.Height = btn_ajouter_contrat.Height;
            SidePanel.Top = btn_ajouter_contrat.Top;
            Contrat C = new Contrat();
            C.Show();
        }

        private void btn_ajouter_etat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_ajouter_etat.Height;
            SidePanel.Top = btn_ajouter_etat.Top;
            EtatCivil E = new EtatCivil();
            E.Show();
           
        }

        private void btn_rechercher_contrat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_rechercher_contrat.Height;
            SidePanel.Top = btn_rechercher_contrat.Top;
            Contrat C = new Contrat();
            C.Show();
        }

        private void btn_modif_contrat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_modif_contrat.Height;
            SidePanel.Top = btn_modif_contrat.Top;
            Contrat C = new Contrat();
            C.Show();
        }

        private void btn_copy_contrat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_copy_contrat.Height;
            SidePanel.Top = btn_copy_contrat.Top;
            Form_printActe A = new Form_printActe();
            A.Show();
        }

        private void btn_copy_etat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_copy_etat.Height;
            SidePanel.Top = btn_copy_etat.Top;
            Form_printEtatET a = new Form_printEtatET();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            form_PereMere p = new form_PereMere();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            Form_Deses p = new Form_Deses();
            p.Show();
        }
    }
}
