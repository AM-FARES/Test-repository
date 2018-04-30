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
    public partial class Form_printActeET : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=Gest_EtatCivil;Integrated Security=True");

        public Form_printActeET()
        {
            InitializeComponent();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from acte where num='" + txt_act.Text + "'and anneeAct='"+txt_annee.Text+"'", con);
            DS_actetat ds1 = new DS_actetat();
            CR_Act1 cr = new CR_Act1();
            da.Fill(ds1, "acte");
            cr.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
