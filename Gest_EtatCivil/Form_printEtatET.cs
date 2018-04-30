using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gest_EtatCivil
{

    public partial class Form_printEtatET : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=Gest_EtatCivil;Integrated Security=True");
        

        public Form_printEtatET()
        {
            InitializeComponent();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            //bla bla bla
            //SqlDataAdapter da = new SqlDataAdapter("select * from etat where num='" + txt_act.Text + "'and anneeAct='" + txt_annee.Text + "'", con);
            SqlCommand cmd = new SqlCommand("select * from etat where num=@var1 and anneeAct=@var2", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.Parameters.AddWithValue("@var1", txt_act.Text);
            cmd.Parameters.AddWithValue("@var2", txt_annee.Text);
            DS_Act ds1 = new DS_Act();
            CR_Etat cr = new CR_Etat();
            da.Fill(ds1, "etat");
            //chof daba ok att
            cr.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
        public void changedatetimetodate()
        {

            
        }
    }
}
