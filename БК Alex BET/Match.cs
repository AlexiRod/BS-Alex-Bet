using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БК_Alex_BET
{
    class Match
    {
        Random random = new Random();

        public string bet { get; set; } // Определение, на какую кнопку нажали (П1, П2 или Н)

        public Team Team1 { get; set; } // Класс команды 1. Свойства для отображения на кнопках и боксах
        public Team Team2 { get; set; } // Класс команды 2. Свойства для отображения на кнопках и боксах

        public Label Goal1 { get; set; } // Лейбл для счета 1
        public Label Goal2 { get; set; } // Лейбл для счета 2

        //public Button btn { get; set; } // Нажатая кнопка (с именем = bet)

        public TextBox TxtbSumm { get; set; } // Окно ввода ставки
        public Label LblTimer { get; set; } //  // Окно отображения времени матча

        public RichTextBox TxtbResults { get; set; } // Окно отображения результатов
        public Label LblCash { get; set; }              //.... (?)
        public Timer TimerPlaying { get; set; }
        public Button btnNext { get; set; }

        int bal;
        int k1, k2 // Рейтинги для одного матча
            , res, c, summ, win = 0;

        public int time, min = 0, s1, s2, t1, t2;

        public int MatchTime = 450;


        public int[] times1 = new int[11];
        public int[] times2 = new int[11];

        public bool results = true;
        public bool kofs = true;
        public bool timing = true; // (?)

        // Конструктор создания матча (переход к одиночной ставке)

        public Match(Team team1, Team team2)
        {
            Team1 = team1;
            Team2 = team2;
            Goal1 = team1.Score;
            Goal2 = team2.Score;
            TxtbSumm = team1.TxtbSumm;
            LblTimer = team1.LblTimer;

        }

        public Match()
        {
        }

        public void Game()
        {
            bal = Convert.ToInt32(LblCash.Text);
            summ = Convert.ToInt32(TxtbSumm.Text);

            if (summ > 0 && summ <= bal)
            {
                bal -= summ;
                LblCash.Text = Convert.ToString(bal);

                Disabled();

                //Button butn = sender as Button;
                

                int f1 = random.Next(1, 11);
                int f2 = random.Next(1, 11);


                k1 = random.Next(Team1.Force - f1, Team1.Force + f1 + 1);
                k2 = random.Next(Team2.Force - f2, Team2.Force + f2 + 1);

                if (kofs)
                {
                    Team1.Buttons.Text +=  " (" + Convert.ToString(k1) + ")";
                    Team2.Buttons.Text += " (" + Convert.ToString(k2) + ")";
                }

                Goal1.Text = "0";
                Goal2.Text = "0";

                Result();
                Playing();
                //timerPlaying_Tick();
                TimerPlaying.Enabled = true;
            }
            else
            {
                if (summ <= 0)
                {
                    MessageBox.Show("Вы ничего не поставили!");
                }

                if (summ > bal)
                {
                    MessageBox.Show("У вас нет такой суммы!");
                }

            }
            

        }

         
        
        public void Win()
        {
            //string bet = btn.Name;

            int istr = summ;

            if (bet.Contains("btnWin")) 
            {
                if (bet.Contains("_1")) // Win 1
                {
                    if (res == 1)
                    {
                        if (results)
                        {
                            MessageBox.Show("Поздравляю! Вы выйграли! Команда " + Team1.Name + " смогла победить команду " + Team2.Name + ". Вы выйграли " + summ);
                        }
                        summ += summ;
                    }
                    if (res == 2)
                    {
                        if (results)
                        {
                            MessageBox.Show("Сожалею! Вы проиграли! Команда " + Team1.Name + " потерпела поражение от команды " + Team2.Name + ". Вы проиграли " + summ);
                        }
                        summ = 0;
                    }
                    if (res == 0)
                    {
                        if (results)
                        {
                            MessageBox.Show("Сожалею! Вы проиграли! Команда " + Team1.Name + " сыграла вничью с командой " + Team2.Name + ". Вы проиграли " + summ);
                        }
                        summ = 0;
                    }

                    win = summ / 2;

                }
                else // Win 2
                {
                    if (res == 1)
                    {
                        if (results)
                        {
                            MessageBox.Show("Сожалею! Вы проиграли! Команда " + Team2.Name + " потерпела поражение от команды " + Team1.Name + ". Вы проиграли " + summ);
                        }
                        summ = 0;
                    }
                    if (res == 2)
                    {
                        if (results)
                        {
                            MessageBox.Show("Поздравяю! Вы выйграли! Команда " + Team2.Name + " смогла победить команду " + Team1.Name + ". Вы выйграли " + summ);
                        }
                        summ += summ;
                    }
                    if (res == 0)
                    {
                        if (results)
                        {
                            MessageBox.Show("Сожалею! Вы проиграли! Команда " + Team2.Name + " сыграла вничью с командой " + Team1.Name + ". Вы проиграли " + summ);
                        }
                        summ = 0;
                    }

                    win = summ / 2;
                }
            }
            else // Draw
            {
                if (res == 1)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + Team1.Name + " смогла победить команду " + Team2.Name + ". Вы проиграли " + summ);
                    }
                    summ = 0;
                }
                if (res == 2)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + Team2.Name + " смогла победить команду " + Team1.Name + ". Вы проиграли " + summ);
                    }
                    summ = 0;
                }
                if (res == 0)
                {
                    if (results)
                    {
                        MessageBox.Show("Поздравляю! Вы выйграли! Команда " + Team1.Name + " сыграла вничью с командой " + Team2.Name + ". Вы выйграли " + summ);
                    }
                    summ += summ;
                }

                win = summ / 2;
            }



            Font font = TxtbResults.Font;

            if (summ > 0)
            {
                int start = TxtbResults.TextLength;
                TxtbResults.Font = font;
                TxtbResults.AppendText("\n▲  " + win);
                int fimish = TxtbResults.TextLength;

                TxtbResults.Select(start, fimish);

                TxtbResults.SelectionColor = Color.Lime;
                TxtbResults.Font = font;
            }
            else
            {

                int start = TxtbResults.TextLength;
                TxtbResults.Font = font;
                TxtbResults.AppendText("\n▼  " + istr);
                int fimish = TxtbResults.TextLength;

                TxtbResults.Select(start, fimish);

                TxtbResults.SelectionColor = Color.Red;
                TxtbResults.Font = font;
            }

            bal += summ;
            LblCash.Text = Convert.ToString(bal);

            //LeagueForm lf = new LeagueForm();
            //lf.bal = bal;

            btnNext.Enabled = true;
        }

        private void Playing()
        { // Определение счета
            if (res == 1)
            {
                c = k1 - k2;

                if (c > 20)
                {
                    c = c - 20;

                    if (c > 1)
                    {
                        s1 = c - 1;
                    }
                    else
                    {
                        s1 = c;
                    }

                    s2 = random.Next(0, s1);
                }
                if (c > 18 && c < 21)
                {
                    c = c - 12;
                    if (c > 1)
                    {
                        s1 = c - 1;
                    }
                    else
                    {
                        s1 = c;
                    }
                    s2 = random.Next(0, s1);
                }
                if (c > 14 && c < 19)
                {
                    c = c - 14;
                    s1 = c;
                    s2 = random.Next(0, s1);
                }
                if (c > 10 && c < 15)
                {
                    c = c - 10;
                    if (c > 1)
                    {
                        s1 = c - 1;
                    }
                    else
                    {
                        s1 = c;
                    }
                    s2 = random.Next(0, s1);
                }
                if (c > 5 && c < 11)
                {
                    c = c / 2;
                    if (c > 1)
                    {
                        s1 = c - 1;
                    }
                    else
                    {
                        s1 = c;
                    }
                    s2 = random.Next(0, s1);
                }

            }

            if (res == 0)
            {
                int a = random.Next(1, 101);
                //Debug.Write("\n a = " + a);
                if (a <= 70)
                {
                    s2 = random.Next(3);
                    s1 = s2;
                }
                if (a > 70 && a <= 90)
                {
                    s2 = random.Next(4);
                    s1 = s2;
                }
                if (a > 90 && a <= 95)
                {
                    s2 = random.Next(5);
                    s1 = s2;
                }
                if (a > 95)
                {
                    s2 = random.Next(6);
                    s1 = s2;
                }

            }

            if (res == 2)
            {
                c = k2 - k1;

                if (c > 20)
                {
                    c = c - 20;
                    if (c > 1)
                    {
                        s2 = c - 1;
                    }
                    else
                    {
                        s2 = c;
                    }
                    s1 = random.Next(0, s2);
                }
                if (c > 18 && c < 21)
                {
                    c = c - 12;
                    if (c > 1)
                    {
                        s2 = c - 1;
                    }
                    else
                    {
                        s2 = c;
                    }
                    s1 = random.Next(0, s2);
                }
                if (c > 14 && c < 19)
                {
                    c = c - 14;
                    if (c > 1)
                    {
                        s2 = c - 1;
                    }
                    else
                    {
                        s2 = c;
                    }
                    s1 = random.Next(0, s2);
                }
                if (c > 10 && c < 15)
                {
                    c = c - 10;
                    if (c > 1)
                    {
                        s2 = c - 1;
                    }
                    else
                    {
                        s2 = c;
                    }
                    s1 = random.Next(0, s2);
                }
                if (c > 5 && c < 11)
                {
                    c = c / 2;
                    if (c > 1)
                    {
                        s2 = c - 1;
                    }
                    else
                    {
                        s2 = c;
                    }
                    s1 = random.Next(0, s2);
                }
            }


            string itog = "";

            if (s1 + s2 != 0)
            {
                int shag = MatchTime / (s1 + s2 + 1) - 5;
                //MessageBox.Show("шаг: " + shag + ". s1 " + s1 + ". s2 " + s2);
                int sch1 = 0;
                int sch2 = 0;

                for (int i = 1; i <= (s1 + s2); i++)
                {
                    int a = random.Next(1, 100);

                    if (a <= 50)
                    {
                        if (sch1 < s1)
                        {
                            times1[i] = i * shag + random.Next(-shag / 2, shag / 2);
                            //MessageBox.Show("1) i = " + i + ". times[i] = " + times1[i]);
                            sch1++;
                        }
                        else
                        {
                            if (sch2 < s2)
                            {
                                times2[i] = i * shag + random.Next(-shag / 2, shag / 2);
                                //MessageBox.Show("2) i = " + i + ". times[i] = " + times1[i]);
                                sch2++;
                            }
                        }
                    }
                    else
                    {
                        if (sch2 < s2)
                        {
                            times2[i] = i * shag + random.Next(-shag / 2, shag / 2);
                            //MessageBox.Show("2) i = " + i + ". times[i] = " + times1[i]);
                            sch2++;
                        }
                        else
                        {
                            if (sch1 < s1)
                            {
                                times1[i] = i * shag + random.Next(-shag / 2, shag / 2);
                                //MessageBox.Show("2) i = " + i + ". times[i] = " + times1[i]);
                                sch1++;
                            }
                        }
                    }


                }
            }




            if (timing)
            {
                //MessageBox.Show(g1 + "   :    " + g2);


                for (int i = 1; i <= (s1 + s2); i++)
                {
                    if (times1[i] != 0)
                    {
                        itog += times1[i] * 20 / 100 + " мин; ";
                    }
                }

                itog += " :  ";

                for (int i = 1; i <= (s1 + s2); i++)
                {
                    if (times2[i] != 0)
                    {
                        itog += times2[i] * 20 / 100 + " мин; ";
                    }
                }
                MessageBox.Show(itog);
            }

        }

        private void Result()
        { // Определение результата матча
            if (k1 - k2 > 5)
            {
                res = 1;
            }
            else
            {
                if (k2 - k1 > 5)
                {
                    res = 2;
                }
                else
                {
                    res = 0;
                }
            }
        }
        
        public void Disabled()
        {
            Team1.Win.Enabled = false;
            Team1.Win.BackColor = Color.White;
            Team1.Draw.Enabled = false;
            Team1.Draw.BackColor = Color.White;
            Team2.Win.Enabled = false;
            Team2.Win.BackColor = Color.White;
            btnNext.Enabled = false;
        }
    }
}