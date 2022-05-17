using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using БК_Alex_BET.Properties;

namespace БК_Alex_BET
{
    public partial class LeagueForm : Form
    {
        public LeagueForm()
        {
            InitializeComponent();
        }


        Match match = new Match();


        #region Graphic

        public int[,] itm = new int[CountTeams - 2, (CountTeams - 1)];

        Random random = new Random();
        static int CountTeams = 16 + 1;
        Team[] tms = new Team[CountTeams];
        static Team[] defaultTeams;
        static Team[] dt;
        int tourN = 1;

        public int bal;
       

        //Button[] tmNames = new Button[CountTeams];
        //PictureBox[] tmLogos = new PictureBox[CountTeams];
        //Image[] logos = new Image[CountTeams];
        //string[] team = new string[CountTeams];
        //int[] force = new int[CountTeams];

        //int[] teams = new int[CountTeams];
        //int[] team2 = new int[CountTeams];
        //int[] team3 = new int[CountTeams];
        //int[] team4 = new int[CountTeams];
        //int[] team5 = new int[CountTeams];
        //int[] team6 = new int[CountTeams];
        //int[] team7 = new int[CountTeams];
        //int[] team8 = new int[CountTeams];
        //int[] team9 = new int[CountTeams];
        //int[] team10 = new int[CountTeams];
        //int[] team11 = new int[CountTeams];
        //int[] team12 = new int[CountTeams];
        //int[] team13 = new int[CountTeams];
        //int[] team14 = new int[CountTeams];
        //int[] team15 = new int[CountTeams];
        //int[] team16 = new int[CountTeams];

        private void LeagueForm_Load(object sender, EventArgs e)
        {
            lblCash.Text = bal.ToString();

            //lblS1_1.Text = Convert.ToString(random.Next(1,6));
            //lblS2_1.Text = Convert.ToString(random.Next(1, 6));
            //lblS1_2.Text = Convert.ToString(random.Next(1, 6));
            //lblS2_2.Text = Convert.ToString(random.Next(1, 6));
            //lblS1_3.Text = Convert.ToString(random.Next(1, 6));
            //lblS2_3.Text = Convert.ToString(random.Next(1, 6));
            //lblS1_4.Text = Convert.ToString(random.Next(1, 6));
            //lblS2_4.Text = Convert.ToString(random.Next(1, 6));
            //lblS1_5.Text = Convert.ToString(random.Next(1, 6));
            //lblS2_5.Text = Convert.ToString(random.Next(1, 6));
            //lblS1_6.Text = Convert.ToString(random.Next(1, 6));
            //lblS2_6.Text = Convert.ToString(random.Next(1, 6));
            //lblS1_7.Text = Convert.ToString(random.Next(1, 6));
            //lblS2_7.Text = Convert.ToString(random.Next(1, 6));
            //lblS1_8.Text = Convert.ToString(random.Next(1, 6));
            //lblS2_8.Text = Convert.ToString(random.Next(1, 6));


            //team[1] = "Амкар"; force[1] = 75; logos[1] = Resources.Амкар;
            //team[2] = "Анжи"; force[2] = 76; logos[2] = Resources.Анжи;
            //team[3] = "Арсенал Тула"; force[3] = 75; logos[3] = Resources.Арсенал;
            //team[4] = "Динамо"; force[4] = 78; logos[4] = Resources.Динамо;
            //team[5] = "Зенит"; force[5] = 85; logos[5] = Resources.Зенит;
            //team[6] = "Краснодар"; force[6] = 84; logos[6] = Resources.Краснодар;
            //team[7] = "Локомотив"; force[7] = 85; logos[7] = Resources.Локомотив;
            //team[8] = "Ростов"; force[8] = 77; logos[8] = Resources.Ростов;
            //team[9] = "Рубин"; force[9] = 80; logos[9] = Resources.Рубин;
            //team[10] = "СКА-Хабаровск"; force[10] = 72; logos[10] = Resources.СКА;
            //team[11] = "Спартак"; force[11] = 84; logos[11] = Resources.Спартак;
            //team[12] = "Терек"; force[12] = 76; logos[12] = Resources.Терек;
            //team[13] = "Тосно"; force[13] = 75; logos[13] = Resources.Тосно;
            //team[14] = "Урал"; force[14] = 75; logos[14] = Resources.Урал;
            //team[15] = "Уфа"; force[15] = 78; logos[15] = Resources.Уфа;
            //team[16] = "ЦСКА"; force[16] = 85; logos[16] = Resources.ЦСКА;


            //tmNames[1] = tm1_1; tmLogos[1] = pBoxtm1;
            //tmNames[2] = tm1_2; tmLogos[2] = pBoxtm2;
            //tmNames[3] = tm2_1; tmLogos[3] = pBoxtm3;
            //tmNames[4] = tm2_2; tmLogos[4] = pBoxtm4;
            //tmNames[5] = tm3_1; tmLogos[5] = pBoxtm5;
            //tmNames[6] = tm3_2; tmLogos[6] = pBoxtm6;
            //tmNames[7] = tm4_1; tmLogos[7] = pBoxtm7;
            //tmNames[8] = tm4_2; tmLogos[8] = pBoxtm8;
            //tmNames[9] = tm5_1; tmLogos[9] = pBoxtm9;
            //tmNames[10] = tm5_2; tmLogos[10] = pBoxtm10;
            //tmNames[11] = tm6_1; tmLogos[11] = pBoxtm11;
            //tmNames[12] = tm6_2; tmLogos[12] = pBoxtm12;
            //tmNames[13] = tm7_1; tmLogos[13] = pBoxtm13;
            //tmNames[14] = tm7_2; tmLogos[14] = pBoxtm14;
            //tmNames[15] = tm8_1; tmLogos[15] = pBoxtm15;
            //tmNames[16] = tm8_2; tmLogos[16] = pBoxtm16;


            Team team1 = new Team("Амкар", 75, Resources.Амкар, tm1_1, pBoxtm1, btnWin1_1, btnDraw1, lblS1_1, txtbSumm1, lblTimer1); tms[1] = team1;
            Team team2 = new Team("Анжи", 76, Resources.Анжи, tm1_2, pBoxtm2, btnWin1_2, btnDraw1, lblS2_1, txtbSumm1, lblTimer1); tms[2] = team2;
            Team team3 = new Team("Арсенал Тула", 75, Resources.Арсенал, tm2_1, pBoxtm3, btnWin2_1, btnDraw2, lblS1_2, txtbSumm2, lblTimer2); tms[3] = team3;
            Team team4 = new Team("Динамо", 78, Resources.Динамо, tm2_2, pBoxtm4, btnWin2_2, btnDraw2, lblS2_2, txtbSumm2, lblTimer2); tms[4] = team4;
            Team team5 = new Team("Зенит", 85, Resources.Зенит, tm3_1, pBoxtm5, btnWin3_1, btnDraw3, lblS1_3, txtbSumm3, lblTimer3); tms[5] = team5;
            Team team6 = new Team("Краснодар", 84, Resources.Краснодар, tm3_2, pBoxtm6, btnWin3_2, btnDraw3, lblS2_3, txtbSumm3, lblTimer3); tms[6] = team6;
            Team team7 = new Team("Локомотив", 85, Resources.Локомотив, tm4_1, pBoxtm7, btnWin4_1, btnDraw4, lblS1_4, txtbSumm4, lblTimer4); tms[7] = team7;
            Team team8 = new Team("Ростов", 77, Resources.Ростов, tm4_2, pBoxtm8, btnWin4_2, btnDraw4, lblS2_4, txtbSumm4, lblTimer4); tms[8] = team8;
            Team team9 = new Team("Рубин", 80, Resources.Рубин, tm5_1, pBoxtm9, btnWin5_1, btnDraw5, lblS1_5, txtbSumm5, lblTimer5); tms[9] = team9;
            Team team10 = new Team("СКА Хабаровск", 72, Resources.СКА, tm5_2, pBoxtm10, btnWin5_2, btnDraw5, lblS2_5, txtbSumm5, lblTimer5); tms[10] = team10;
            Team team11 = new Team("Спартак", 84, Resources.Спартак, tm6_1, pBoxtm11, btnWin6_1, btnDraw6, lblS1_6, txtbSumm6, lblTimer6); tms[11] = team11;
            Team team12 = new Team("Терек", 76, Resources.Терек, tm6_2, pBoxtm12, btnWin6_2, btnDraw6, lblS2_6, txtbSumm6, lblTimer6); tms[12] = team12;
            Team team13 = new Team("Тосно", 75, Resources.Тосно, tm7_1, pBoxtm13, btnWin7_1, btnDraw7, lblS1_7, txtbSumm7, lblTimer7); tms[13] = team13;
            Team team14 = new Team("Урал", 75, Resources.Урал, tm7_2, pBoxtm14, btnWin7_2, btnDraw7, lblS2_7, txtbSumm7, lblTimer7); tms[14] = team14;
            Team team15 = new Team("Уфа", 78, Resources.Уфа, tm8_1, pBoxtm15, btnWin8_1, btnDraw8, lblS1_8, txtbSumm8, lblTimer8); tms[15] = team15;
            Team team16 = new Team("ЦСКА", 85, Resources.ЦСКА, tm8_2, pBoxtm16, btnWin8_2, btnDraw8, lblS2_8, txtbSumm8, lblTimer8); tms[16] = team16;

            defaultTeams = tms;

            Generation(CountTeams - 1); // Алгоритм составления календаря

            tms = RandomTeams(tms, tms.Length); // Перестановка пар в туре
            dt = tms; // 
            //Team.WriteProps(dt, "dt:  Button Click", 'm');

            string g = "";
            for (int i = 1; i < tms.Length; i++)
            {
                g += i - 1 + ") " + tms[i].Name + ";\t\tButton: " + tms[i].Buttons.Name + "\t\tWinButton: " + tms[i].Win.Name + "\n";
            }
            //MessageBox.Show(g);
            //Debug.Write(g);
            //ShowTour(0); 

            tms = Show(tourN - 1, defaultTeams, tms, itm); // Вывод


            //Team.WriteProps(tms, "New Teams", 'm');


            //for (int i = 1; i < tms.Length; i++)
            //{
            //    Debug.Write("\n" + tms[i].Name + " - " + tms[i].Force);
            //}
        }



        private Team[] Show(int i, Team[] dt, Team[] tms, int[,] cal)
        {
            Team[] tt = new Team[tms.Length];


            for (int k = 1; k < tt.Length; k++)
            {
                tt[k] = new Team();
            }


            for (int j = 0; j < cal.GetLength(1); j++)
            {
                //dt[j + 1].Buttons.Text = tms[cal[i, j] + 1].Name;
                //dt[j + 1].Pboxes.Image = tms[cal[i, j] + 1].Logos;

                tt[j + 1].Name = tms[cal[i, j] + 1].Name;
                tt[j + 1].Force = tms[cal[i, j] + 1].Force;
                tt[j + 1].Logos = tms[cal[i, j] + 1].Logos;

                tt[j + 1].Buttons = dt[j + 1].Buttons;
                tt[j + 1].Pboxes = dt[j + 1].Pboxes;
                tt[j + 1].Win = dt[j + 1].Win;
                tt[j + 1].Draw = dt[j + 1].Draw;
                tt[j + 1].Score = dt[j + 1].Score;
                tt[j + 1].TxtbSumm = dt[j + 1].TxtbSumm;
                tt[j + 1].LblTimer = dt[j + 1].LblTimer;

                tt[j + 1].Buttons.Text = tt[j + 1].Name;
                tt[j + 1].Pboxes.Image = tt[j + 1].Logos;


                //tms[j + 1].Pboxes.Image = tms[cal[i, j] + 1].Logos;

                //dt[j + 1].Buttons.Text = tt[j+1].Name;
                //dt[j + 1].Pboxes.Image = tt[j+1].Logos;
            }
            return tt;
        }

        private Team[] RandomTeams(Team[] t, int c)
        {
            Team[] trash = new Team[c];
            int[] nums = new int[c];

            for (int i = 1; i < c; i++)
            {
                nums[i] = i;
                trash[i] = new Team();
            }

            for (int i = 1; i < trash.Length; i++)
            {
                int k = random.Next(1, nums.Length);

                //trash[i] = defaultTeams[i];
                trash[i].Name = t[nums[k]].Name;
                trash[i].Force = t[nums[k]].Force;
                trash[i].Logos = t[nums[k]].Logos;

                trash[i].Buttons = defaultTeams[i].Buttons;
                trash[i].Pboxes = defaultTeams[i].Pboxes;
                trash[i].Win = defaultTeams[i].Win;
                trash[i].Draw = defaultTeams[i].Draw;
                trash[i].Score = defaultTeams[i].Score;
                trash[i].TxtbSumm = defaultTeams[i].TxtbSumm;
                trash[i].LblTimer = defaultTeams[i].LblTimer;


                //Debug.Write(i + ") " + trash[i].Name + "; Button " + trash[i].Buttons.Name + "; PBox " + trash[i].Pboxes.Name  + "; \t tms[i].Button = " + t[i].Buttons.Name + "\n");
                //Debug.Write(t[7].Name + "  " + t[7].Buttons.Name);


                List<int> lst = new List<int>(nums); // Преобразование в список
                lst.RemoveAt(k); // Удаление элемента
                nums = lst.ToArray();
            }

            return trash;
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            maxTours = itm.GetLength(0);
            if (tourN + 2 > maxTours)
            {
                btnNext.Enabled = false;
                btnNext.Text = "Чемпионат окончен!";
            }
            tourN++;
            lbl_TourN.Text = Convert.ToString(tourN);
            tms = Show(tourN - 1, defaultTeams, dt, itm);

            int start = txtbResults.TextLength;
            txtbResults.AppendText("\n_______________\nТур " + tourN + ":\n");
            int finish = txtbResults.TextLength;

            txtbResults.Select(start, finish);

            txtbResults.SelectionColor = Color.Black;

            for (int i = 1; i < tms.Length; i++)
            {
                tms[i].Win.Enabled = true;
                tms[i].Win.BackColor = Color.FromArgb(65, 235, 60);
                tms[i].Draw.Enabled = true;
                tms[i].Draw.BackColor = Color.Gold;
                tms[i].Score.Text = "-";
                tms[i].TxtbSumm.Text = "0";
            }
        }









        private void Generation(int a)
        {
            int li_Teams = a;
            int li_Tours = li_Teams - 1;

            int li_sum;
            int li_TourNo;
            string[,] ls_Pairs = new string[li_Teams / 2, li_Tours];
            for (int i = 0; i < li_Teams - 1; i++)
            {
                for (int j = i + 1; j < li_Teams; j++)
                {
                    if (i != j)
                    {
                        if (j + 1 == li_Teams)
                        { li_sum = 2 * (i + 1); }
                        else
                        { li_sum = (i + 1) + (j + 1); }
                        if (li_sum > li_Teams)
                        { li_TourNo = li_sum - li_Teams - 1; }
                        else { li_TourNo = li_sum - 1 - 1; }
                        for (int k = 0; k < li_Teams / 2; k++)
                        {

                            if (ls_Pairs[k, li_TourNo] == null)
                            {
                                ls_Pairs[k, li_TourNo] = Convert.ToString(i) + " " + Convert.ToString(j) + " ";
                                break;
                            }
                        }

                    }

                }
            }
            


            // Randomizing


            string[,] ran = new string[ls_Pairs.GetLength(0), ls_Pairs.GetLength(1)];

            for (int j = 0; j < ls_Pairs.GetLength(1); j++)  // 15 туров
            {
                int[] tour = new int[ls_Pairs.GetLength(0)];

                for (int l = 0; l < tour.Length; l++)
                {
                    tour[l] = l;
                }

                for (int i = 0; i < ls_Pairs.GetLength(0); i++) // 8 пар соперников
                {
                    int k = random.Next(tour.Length);
                    ran[i, j] = ls_Pairs[tour[k], j];

                    List<int> lst = new List<int>(tour); // Преобразование в список
                    lst.RemoveAt(k); // Удаление элемента
                    tour = lst.ToArray();
                }
            }



            //String Array to Int Array




            for (int j = 0; j < ran.GetLength(1); j++)  // 15 туров
            {
                for (int i = 0; i < ran.GetLength(0); i++) // 8 пар соперников
                {
                    string[] t = ran[i, j].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    itm[j, i * 2] = Convert.ToInt32(t[0]);
                    itm[j, i * 2 + 1] = Convert.ToInt32(t[1]);
                }
            }



            // Writing


            string g = "";

            for (int i = 0; i < itm.GetLength(0); i++)
            {
                g += "Tour " + i + " | ";
                for (int j = 0; j < itm.GetLength(1); j += 2)
                {
                    g += $"   {itm[i, j]}-{itm[i, j + 1]}";
                }
                g += "\n";
            }


            //MessageBox.Show(g);

            //Debug.Write(g);
        }


        private void txtb_TextChanged(object sender, EventArgs e)
        {
            TextBox txtb = sender as TextBox;

            if (txtb.Text == "")
            {
                txtb.Text = "0";
            }
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();  
            this.Hide();
            ModeForm mF = new ModeForm();
            mF.bal = bal;
            mF.Show();
        }

        private void LeagueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ModeForm mF = new ModeForm();
            mF.bal = bal;
            mF.Show();
        }


        private void btn_ShowCal_Click(object sender, EventArgs e)
        {
            //Team.WriteProps(tms, "League", 'm');

            CalendarForm FCal = new CalendarForm();
            FCal.tm = itm;
            //FCal.GetTeams = tms;
            FCal.GetDefault = dt;
            //Team.WriteProps(dt, "Button Click", 'm');
            FCal.ShowDialog();

        }

        int maxTours;


        #endregion




        private void btn_Click(object sender, EventArgs e)
        {
            if (!timerPlaying.Enabled)
            {
                Button b = sender as Button;

                if (b.Name.Contains("btnWin"))
                {
                    for (int i = 1; i < tms.Length; i++)
                    {
                        if (tms[i].Win == b)
                        {
                            Team t1 = null, t2 = null;
                            string bt = "";

                            if (i % 2 != 0) // Win 1
                            {
                                t1 = tms[i];
                                t2 = tms[i + 1];
                                bt = tms[i].Win.Name;
                            }
                            else // Win 1
                            {
                                t1 = tms[i - 1];
                                t2 = tms[i];
                                bt = tms[i].Win.Name;
                            }

                            match = new Match(t1, t2);

                            match.TxtbResults = txtbResults;
                            match.LblCash = lblCash;

                            match.TimerPlaying = timerPlaying;

                            match.kofs = chBKofs.Checked;
                            match.timing = chBTiming.Checked;
                            match.results = chBResults.Checked;
                            match.btnNext = btnNext;

                            match.bet = bt;
                            match.Game();

                            break;
                        }
                    }

                }
                else
                {
                    for (int i = 1; i < tms.Length; i++)
                    {
                        if (tms[i].Draw == b)
                        {
                            Team t1 = tms[i], t2 = tms[i + 1];
                            string bt = b.Name;


                            match = new Match(t1, t2);

                            match.TxtbResults = txtbResults;
                            match.LblCash = lblCash;

                            match.TimerPlaying = timerPlaying;

                            match.kofs = chBKofs.Checked;
                            match.timing = chBTiming.Checked;
                            match.results = chBResults.Checked;
                            match.btnNext = btnNext;

                            match.bet = bt;
                            match.Game();

                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show( "Дождитесь завершения матча!", "Игра еще не закончилась!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void timerPlaying_Tick(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            match.time++;
            match.min += 20;
            if (match.min < 1000)
            {
                match.LblTimer.Text = Convert.ToString("0" + match.min / 100 + ":" + match.min % 100);
            }
            else
            {
                match.LblTimer.Text = Convert.ToString(match.min / 100 + ":" + match.min % 100);
            }



            if (match.time < match.MatchTime)
            {
                for (int i = 1; i <= (match.s1 + match.s2); i++)
                {
                    if (match.time == match.times1[i])
                    {
                        match.t1++;
                        match.Goal1.Text = Convert.ToString(match.t1);
                        match.times1[i] = 0;
                    }
                    if (match.time == match.times2[i])
                    {
                        match.t2++;
                        match.Goal2.Text = Convert.ToString(match.t2);
                        match.times2[i] = 0;
                    }
                }

            }
            else
            {
                match.TimerPlaying.Enabled = false;
                match.LblTimer.Text = "90:00";
                match.Win();
                match.time = 0;
                btnNext.Enabled = true;
                bal = Convert.ToInt32(lblCash.Text);
            }
        }

        private void btnShowRates_Click(object sender, EventArgs e)
        {
            string rates = "";

            for (int i = 1; i < defaultTeams.Length; i++)
            {
                rates += defaultTeams[i].Name + " - " + defaultTeams[i].Force + "\n";
            }

            MessageBox.Show(rates, "Рейтинги", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}