using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using БК_Alex_BET.Properties;


namespace БК_Alex_BET
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
        }
        
        public static int[,] cal;
        static int CountTeams = 16 + 1;
        static public Team[] defaultTeams = new Team[CountTeams];

        int tourN = 1;
        int maxTours;
        

        public int[,] tm
        {
            get { return cal; }
            set { cal = value; }
        }
        

        public Team[] GetDefault
        {
            get { return defaultTeams; }
            set { defaultTeams = value; }
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            lblTour.Text = "Тур №" + tourN.ToString();
            maxTours = cal.GetLength(0);


            defaultTeams[1].Buttons = tm1_1;
            defaultTeams[2].Buttons = tm1_2;
            defaultTeams[3].Buttons = tm2_1;
            defaultTeams[4].Buttons = tm2_2;
            defaultTeams[5].Buttons = tm3_1;
            defaultTeams[6].Buttons = tm3_2;
            defaultTeams[7].Buttons = tm4_1;
            defaultTeams[8].Buttons = tm4_2;
            defaultTeams[9].Buttons = tm5_1;
            defaultTeams[10].Buttons = tm5_2;
            defaultTeams[11].Buttons = tm6_1;
            defaultTeams[12].Buttons = tm6_2;
            defaultTeams[13].Buttons = tm7_1;
            defaultTeams[14].Buttons = tm7_2;
            defaultTeams[15].Buttons = tm8_1;
            defaultTeams[16].Buttons = tm8_2;


            defaultTeams[1].Pboxes = pBoxtm1;
            defaultTeams[2].Pboxes = pBoxtm2;
            defaultTeams[3].Pboxes = pBoxtm3;
            defaultTeams[4].Pboxes = pBoxtm4;
            defaultTeams[5].Pboxes = pBoxtm5;
            defaultTeams[6].Pboxes = pBoxtm6;
            defaultTeams[7].Pboxes = pBoxtm7;
            defaultTeams[8].Pboxes = pBoxtm8;
            defaultTeams[9].Pboxes = pBoxtm9;
            defaultTeams[10].Pboxes = pBoxtm10;
            defaultTeams[11].Pboxes = pBoxtm11;
            defaultTeams[12].Pboxes = pBoxtm12;
            defaultTeams[13].Pboxes = pBoxtm13;
            defaultTeams[14].Pboxes = pBoxtm14;
            defaultTeams[15].Pboxes = pBoxtm15;
            defaultTeams[16].Pboxes = pBoxtm16;

            

            ShowTour(tourN - 1, defaultTeams, cal);
        }

        private void btn_Direct_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn_Next":
                    if (tourN + 1 > maxTours)
                    {
                        tourN = 0;
                    }
                    tourN++;
                    break;

                case "btn_Back":
                    if (tourN == 1)
                    {
                        tourN = maxTours + 1;
                    }
                    tourN--;
                    break;
            }

            lblTour.Text = "Тур №" + tourN.ToString();


            //Team.WriteProps(tms, "CalendarForm");

            //tms = ChangeTeamsInTour(tourN - 1, cal, defaultTeams);
            //Team.WriteProps(defaultTeams, "After Change", 'm');

            ShowTour(tourN - 1, defaultTeams, cal);

            //Team.WriteProps(defaultTeams, "CalendarForm", 'm');
        }

        private void ShowTour(int i, Team[] dt, int[,] cal)
        {

            for (int j = 0; j < cal.GetLength(1); j++)
            {
                dt[j + 1].Buttons.Text = dt[cal[i, j] + 1].Name;
                dt[j + 1].Pboxes.Image = dt[cal[i, j] + 1].Logos;
                //Debug.Write("\n " + dt[cal[i, j] + 1].Name);
            }


        }
    }
}