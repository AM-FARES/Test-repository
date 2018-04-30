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
    public partial class Form_printEtat : Form
    {
        public Form_printEtat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Menu M = new Form_Menu();
            M.Show();
            this.Close();
        }
    }
}
