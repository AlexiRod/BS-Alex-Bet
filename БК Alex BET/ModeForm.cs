using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БК_Alex_BET
{
    public partial class ModeForm : Form
    {
        public ModeForm()
        {
            InitializeComponent();
        }

        public int bal = 100000;

     
        private void btnOwn_Click(object sender, EventArgs e)
        {
            OwnForm form1 = new OwnForm();
            form1.bal = bal;
            form1.Show();
            this.Hide();

            //btnOwn.Enabled = false;
            //btnLeague.Enabled = false;
        }

       
       
        private void btnLeague_Click(object sender, EventArgs e)
        {
            LeagueForm form2 = new LeagueForm();
            form2.bal = bal;
            form2.Show();
            this.Hide();

            //btnOwn.Enabled = false;
            //btnLeague.Enabled = false;
        }

        private void ModeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}