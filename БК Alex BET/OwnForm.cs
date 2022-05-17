using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using БК_Alex_BET.Properties;

namespace БК_Alex_BET
{
    public partial class OwnForm : Form
    {
        public OwnForm()
        {
            InitializeComponent();
        }


        Random random = new Random();
        int i, j, k1, k2, time, c, s1, s2, res, t1, t2, min, summ, win = 0;
        int MatchTime = 450;
        bool results = true, kofs = true, timing = true;
        Button btn = new Button();

        public int bal;

        int[] times1 = new int[11];
        int[] times2 = new int[11];

        double[] kofsB = new double[7];
        double[] kofsM = new double[8];



        string[] team = new string[17];

        int[] force = new int[17];
        
        Image[] logos = new Image[17];

     

        private void OwnForm_Load(object sender, EventArgs e)
        {
           

            team[1] = "Амкар";              force[1] = 75;       logos[1] = Resources.Амкар;
            team[2] = "Анжи";               force[2] = 76;       logos[2] = Resources.Анжи;
            team[3] = "Арсенал Тула";       force[3] = 75;       logos[3] = Resources.Арсенал;
            team[4] = "Динамо";             force[4] = 78;       logos[4] = Resources.Динамо;
            team[5] = "Зенит";              force[5] = 85;       logos[5] = Resources.Зенит;
            team[6] = "Краснодар";          force[6] = 84;       logos[6] = Resources.Краснодар;
            team[7] = "Локомотив";          force[7] = 85;       logos[7] = Resources.Локомотив;
            team[8] = "Ростов";             force[8] = 77;       logos[8] = Resources.Ростов;
            team[9] = "Рубин";              force[9] = 80;       logos[9] = Resources.Рубин;
            team[10] = "СКА-Хабаровск";     force[10] = 72;      logos[10] = Resources.СКА;
            team[11] = "Спартак";           force[11] = 84;      logos[11] = Resources.Спартак;
            team[12] = "Терек";             force[12] = 76;      logos[12] = Resources.Терек;
            team[13] = "Тосно";             force[13] = 75;      logos[13] = Resources.Тосно;
            team[14] = "Урал";              force[14] = 75;      logos[14] = Resources.Урал;
            team[15] = "Уфа";               force[15] = 78;      logos[15] = Resources.Уфа;
            team[16] = "ЦСКА";              force[16] = 85;      logos[16] = Resources.ЦСКА;

            for (int i = 1; i < 17; i++)
            {
                txtbRaiting.Text += "\r\n" + team[i] + " --- " + force[i].ToString();
            }
           

            //  btnTtlB:
            //  2 - 0.5
            //  3 - 1
            //  4 - 2
            //  5 - 3
            //  6 - 5
            //  7 - 10

            kofsB[1] = 10;
            kofsB[2] = 0.5;
            kofsB[3] = 1;
            kofsB[4] = 2;
            kofsB[5] = 3;
            kofsB[6] = 5;

            //  btnTtlM:
            //  7 - 0.25
            //  6 - 0.5
            //  5 - 1
            //  4 - 1.5
            //  3 - 2
            //  2 - 3
            //  1 - 5

            kofsM[7] = 0.25;
            kofsM[6] = 0.5;
            kofsM[5] = 1;
            kofsM[4] = 1.5;
            kofsM[3] = 2;
            kofsM[2] = 3;
            kofsM[1] = 5;

            btnKofsB.Text = "Коэффициенты для тоталов\nТотал больше:";

            for (int i = 2; i < 7; i++)
            {
                btnKofsB.Text += "\n " + i + " - " + kofsB[i];
            }

            btnKofsB.Text += "\nИначе - 10";

            btnKofsM.Text = "Коэффициенты для тоталов\nТотал меньше:";
            for (int i = 7; i >= 1; i--)
            {
                btnKofsM.Text += "\n " + i + " - " + kofsM[i];
            }

            Generation();

            lblCash.Text = bal.ToString();
        }



        private void btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b.Name == "btnWin1" || b.Name == "btnWin2" || b.Name == "btnDraw" || b.Name == "btnBoth")
            {
                if (Convert.ToInt32(txtbSumm.Text) > 0 && Convert.ToInt32(txtbSumm.Text) <= bal)
                {
                    bal -= Convert.ToInt32(txtbSumm.Text);
                    lblCash.Text = Convert.ToString(bal);

                    DisAbled();

                    Button butn = sender as Button;
                    summ = Convert.ToInt32(txtbSumm.Text);

                    int f1 = random.Next(1, 11);
                    int f2 = random.Next(1, 11);


                    k1 = random.Next(force[i] - f1, force[i] + f1 + 1);
                    k2 = random.Next(force[j] - f2, force[j] + f2 + 1);

                    if (kofs)
                    {
                        tm1.Text = tm1.Text + "(" + Convert.ToString(k1) + ")";
                        tm2.Text = tm2.Text + "(" + Convert.ToString(k2) + ")";
                    }

                    lblS1.Text = "0";
                    lblS2.Text = "0";

                    Result();
                    Playing();
                    btn = butn;
                    timerPlaying.Enabled = true;
                }
                else
                {
                    if (Convert.ToInt32(txtbSumm.Text) <= 0)
                    {
                        MessageBox.Show("Вы ничего не поставили!");
                    }

                    if (Convert.ToInt32(txtbSumm.Text) > bal)
                    {
                        MessageBox.Show("У вас нет такой суммы!");
                    }
                    
                }
            }

            if (b.Name == "btnTtlB" || b.Name == "btnTtlM")
            {
              
                if (Convert.ToInt32(txtbSumm.Text) > 0 && Convert.ToInt32(txtbSumm.Text) <= bal && ((Convert.ToInt32(txtbB.Text) > 1 && Convert.ToInt32(txtbB.Text) < 13) || (Convert.ToInt32(txtbM.Text) > 0 && Convert.ToInt32(txtbM.Text) < 8)))
                {
                    bal -= Convert.ToInt32(txtbSumm.Text);
                    lblCash.Text = Convert.ToString(bal);

                    DisAbled();

                    Button butn = sender as Button;
                    summ = Convert.ToInt32(txtbSumm.Text);

                    int f1 = random.Next(1, 11);
                    int f2 = random.Next(1, 11);


                    k1 = random.Next(force[i] - f1, force[i] + f1 + 1);
                    k2 = random.Next(force[j] - f2, force[j] + f2 + 1);


                    if (kofs)
                    {
                        tm1.Text = tm1.Text + "(" + Convert.ToString(k1) + ")";
                        tm2.Text = tm2.Text + "(" + Convert.ToString(k2) + ")";
                    }

                    lblS1.Text = "0";
                    lblS2.Text = "0";

                    Result();
                    Playing();
                    btn = butn;
                    timerPlaying.Enabled = true;
                }
                else
                {
                    if (Convert.ToInt32(txtbSumm.Text) <= 0)
                    {
                        MessageBox.Show("Вы ничего не поставили!");
                    }

                    if (Convert.ToInt32(txtbSumm.Text) > bal )
                    {
                        MessageBox.Show("У вас нет такой суммы!");
                    }



                    if (Convert.ToInt32(txtbB.Text) < 2 && b.Name == "btnTtlB")
                    {
                        MessageBox.Show("Больший тотал должен быть больше 1!");
                    }
                    if (Convert.ToInt32(txtbB.Text) > 12 && b.Name == "btnTtlB")
                    {
                        MessageBox.Show("Больший тотал должен быть меньше 13!");
                    }

                    if (Convert.ToInt32(txtbM.Text) > 7 && b.Name == "btnTtlM")
                    {
                        MessageBox.Show("Меньший тотал должен быть меньше 8!");
                    }

                    if (Convert.ToInt32(txtbM.Text) < 1 && b.Name == "btnTtlM")
                    {
                        MessageBox.Show("Меньший тотал должен быть больше 0!");
                    }
                }
            }
        }


        private void DisAbled()
        {
            btnWin1.Enabled = false;
            btnWin2.Enabled = false;
            btnDraw.Enabled = false;
            btnTtlB.Enabled = false;
            btnBoth.Enabled = false;
            btnTtlM.Enabled = false;
            btnNext.Enabled = false;
            btnMinus.Enabled = false;
            btnPlus.Enabled = false;
            btnD2.Enabled = false;
            btnX2.Enabled = false;
            txtbB.Enabled = false;
            txtbM.Enabled = false;
            txtbSumm.Enabled = false;
            btnExit.Enabled = false;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            /*int c1 = random.Next(0, 256);
            int c2 = random.Next(0, 256);
            int c3 = random.Next(0, 256);
            btnNext.BackColor = Color.FromArgb(c1,c2,c3);
            */

            btnWin1.Enabled = true;
            btnWin2.Enabled = true;
            btnDraw.Enabled = true;
            btnTtlB.Enabled = true;
            btnBoth.Enabled = true;
            btnMinus.Enabled = true;
            btnPlus.Enabled = true;
            btnD2.Enabled = true;
            btnX2.Enabled = true;
            btnTtlM.Enabled = true;
            btnNext.Enabled = false;
            txtbB.Enabled = true;
            txtbM.Enabled = true;
            txtbSumm.Enabled = true;
            btnNext.Enabled = false;

            lblS1.Text = "-";
            lblS2.Text = "-";
            lblTimer.Text = "00:00";
            min = 0;
            s1 = 0;
            s2 = 0;
            t1 = 0;
            t2 = 0;
            win = 0;


            Generation();
        }


      




        private void timerPlaying_Tick(object sender, EventArgs e)
        {
           
            time++;
            min += 20;
            if (min < 1000)
            {
                lblTimer.Text = Convert.ToString("0" + min / 100 + ":" + min % 100);
            }
            else
            {
                lblTimer.Text = Convert.ToString(min / 100 + ":" + min % 100);
            }
            


            if (time < MatchTime)
            {
                for (int i = 1; i <= (s1 + s2); i++)
                {
                    if (time == times1[i])
                    {
                        t1++;
                        lblS1.Text = Convert.ToString(t1);
                        times1[i] = 0;
                    }
                    if (time == times2[i])
                    {
                        t2++;
                        lblS2.Text = Convert.ToString(t2);
                        times2[i] = 0;
                    }
                }

            }
            else
            {
                timerPlaying.Enabled = false;
                lblTimer.Text = "90:00";
                Win(btn);
                time = 0;
                btnNext.Enabled = true;
                btnExit.Enabled = true;
            }


        }


        private void Win(Button button)
        {
          
            if (button.Name == "btnWin1")
            {
                if (res == 1)
                {
                    if (results)
                    {
                        MessageBox.Show("Поздравляю! Вы выйграли! Команда " + team[i] + " смогла победить команду " + team[j] + ". Вы выиграли " + summ);
                    }
                    win = summ * 2;
                }
                if (res == 2)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[i] + " потерпела поражение от команды " + team[j] + ". Вы проиграли " + summ);
                    }
                    win = 0;
                }
                if (res == 0)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[i] + " сыграла вничью с командой " + team[j] + ". Вы проиграли " + summ);
                    }
                    win = 0;
                }
                
            }

            if (button.Name == "btnWin2")
            {
                if (res == 1)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[j] + " потерпела поражение от команды " + team[i] + ". Вы проиграли " + summ);
                    }
                    win = 0;
                }
                if (res == 2)
                {
                    if (results)
                    {
                        MessageBox.Show("Поздравяю! Вы выйграли! Команда " + team[j] + " смогла победить команду " + team[i] + ". Вы выиграли " + summ);
                    }
                    win = summ * 2;
                }
                if (res == 0)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[j] + " сыграла вничью с командой " + team[i] + ". Вы проиграли " + summ);
                    }
                    win = 0;
                }
                
            }

            if (button.Name == "btnDraw")
            {
                if (res == 1)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[i] + " смогла победить команду " + team[j] + ". Вы проиграли " + summ);
                    }
                    win = 0;
                }
                if (res == 2)
                {
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[j] + " смогла победить команду " + team[i] + ". Вы проиграли " + summ);
                    }
                    win = 0;
                }
                if (res == 0)
                {
                    if (results)
                    {
                        MessageBox.Show("Поздравляю! Вы выйграли! Команда " + team[i] + " сыграла вничью с командой " + team[j] + ". Вы выиграли " + summ);
                    }
                    win = summ * 2;
                }

            }

            if (button.Name == "btnTtlB")
            {
               
                //  btnTtlB:
                //  2 - 0.5
                //  3 - 1
                //  4 - 2
                //  5 - 3
                //  6 - 5
                //  7 - 10

                
                int a = Convert.ToInt32(txtbB.Text);
                int b = Convert.ToInt32(lblS1.Text) + Convert.ToInt32(lblS2.Text);

                if (a < b)
                {
                    if (a > 6)
                    {
                        win = win = Convert.ToInt32(Convert.ToDouble(summ) * kofsB[1]);
                    }
                    else
                    {
                        win = Convert.ToInt32(Convert.ToDouble(summ) * kofsB[a]);
                    }
                    

                    if (results)
                    {
                        MessageBox.Show("Поздравляю! Вы выйграли! Итоговый тотал оказался больше " + a + ". По коэффициенту ставки вы выиграли " + win);
                    }
                    win += summ;
                }
                else
                {
                    win = 0;
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли!  Итоговый тотал оказался равен " + b + ". Вы проиграли " + summ);
                    }
                }

              
            }
            
            if (button.Name == "btnTtlM")
            {
               


                int a = Convert.ToInt32(txtbM.Text);
                int b = Convert.ToInt32(lblS1.Text) + Convert.ToInt32(lblS2.Text);

                if (a > b)
                {

                    if (a > 7)
                    {
                        win = Convert.ToInt32(Convert.ToDouble(summ) * 0.25);
                    }
                    else
                    {
                        win = Convert.ToInt32(Convert.ToDouble(summ) * kofsM[a]);
                    }

                    if (results)
                    {
                        MessageBox.Show("Поздравляю! Вы выйграли! Итоговый тотал оказался меньше " + a + ". По коэффициенту ставки вы выиграли " + win);
                    }
                    win += summ;

                }
                else
                {
                    win = 0;
                    if (results)
                    {
                        MessageBox.Show("Сожалею! Вы проиграли!  Итоговый тотал оказался равен " + b + ". Вы проиграли " + summ);
                    }
                }


            }

            if (button.Name == "btnBoth")
            {
                if (s1 != 0 && s2 != 0)
                {
                    win += summ*2;
                    if (results)
                    {
                        MessageBox.Show("Поздравляю! Обе команды забили! Вы выиграли " + summ); 
                    }

                }
                else
                {
                    if (results)
                    {
                        if (s1 == 0 && s2 != 0)
                        {
                            MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[i] + " не смогла забить! Вы проиграли " + summ);
                        }
                        else
                        {
                            if (s1 != 0 && s2 == 0)
                            {
                                MessageBox.Show("Сожалею! Вы проиграли! Команда " + team[j] + " не смогла забить! Вы проиграли " + summ);
                            }
                            else
                            {
                                MessageBox.Show("Сожалею! Вы проиграли! Ни одна из команд не смогла забить! Вы проиграли " + summ);
                            }
                        }
                    }
                    win = 0;
                }


            }



            if (win > 0)
            {

                int start = txtbResults.TextLength;
                txtbResults.AppendText("▲  " + (win - summ) + "\n");
                int fimish = txtbResults.TextLength;

                txtbResults.Select(start, fimish);

                txtbResults.SelectionColor = Color.Lime;
            }
            else
            {

                int start = txtbResults.TextLength;
                txtbResults.AppendText("▼  " + summ + "\n");
                int fimish = txtbResults.TextLength;

                txtbResults.Select(start, fimish);

                txtbResults.SelectionColor = Color.Red;
            }

            bal += win;
            lblCash.Text = Convert.ToString(bal);
        }

        private void Playing()
        {
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
                if (a <= 70)
                {
                    s2 = random.Next(0, 3);
                    s1 = s2;
                }
                if (a > 70 && a <= 90)
                {
                    s2 = random.Next(0, 4);
                    s1 = s2;
                }
                if (a > 90 && a <= 95)
                {
                    s2 = random.Next(0, 5);
                    s1 = s2;
                }
                if (a > 95)
                {
                    s2 = random.Next(0, 6);
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

            if (s1 + s2 == 0)
            {
            }
            else
            {
                int shag = MatchTime / (s1 + s2 + 1) - 5;
                //MessageBox.Show("шаг: " + shag + ". s1 " + s1 + ". s2 " + s2);
                int sch1 = 0;
                int sch2 = 0;

                for (int i = 1; i <= (s1+s2); i++)
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
        {
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
        

        private void Generation()
        {

            do
            {
                i = random.Next(1, 17);
                j = random.Next(1, 17);

            } while (i == j);

            tm1.Text = team[i];
            tm2.Text = team[j];
            k1 = force[i];
            k2 = force[j];
            pBoxTm1.BackgroundImage = logos[i];
            pBoxTm2.BackgroundImage = logos[j];
        }
        
        


        private void btnMinusPlusUmn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name;

            Label[] lbls = new Label[10];

            lbls[0] = sum1;
            lbls[1] = sum2;
            lbls[2] = sum3;
            lbls[3] = sum4;
            lbls[4] = sum5;
            lbls[5] = sum6;
            lbls[6] = sum7;
            lbls[7] = sum8;
            lbls[8] = sum9;

            
            if (name == "btnPlus")
            {
                txtbSumm.Text = Convert.ToString(Convert.ToInt32(txtbSumm.Text) + Convert.ToInt32(lbls[trBarSumm.Value].Text));
            }
            if (name == "btnMinus")
            {
                if (Convert.ToInt32(txtbSumm.Text) - Convert.ToInt32(lbls[trBarSumm.Value].Text) >= 0)
                {
                    txtbSumm.Text = Convert.ToString(Convert.ToInt32(txtbSumm.Text) - Convert.ToInt32(lbls[trBarSumm.Value].Text));
                }
                else
                {
                    txtbSumm.Text = "0";
                }
                if (Convert.ToInt32(txtbSumm.Text) < 0)
                {
                }
            }

            if (name == "btnX2")
            {
                txtbSumm.Text = Convert.ToString(Convert.ToInt32(txtbSumm.Text) * 2);
            }

            if (name == "btnD2")
            {
                txtbSumm.Text = Convert.ToString(Convert.ToInt32(txtbSumm.Text) / 2);
            }
        }


        private void chB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;


            if (box.Name == "chBResults")
            {
               results = box.Checked;
            }

            if (box.Name == "chBKofs")
            {
                kofs = box.Checked;
            }


            if (box.Name == "chBTiming")
            {
                timing = box.Checked;
            }

        }



        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;


            switch (btn.Name)
            {
                case "btnWin1":
                    btn.BackColor = Color.Lime;
                    break;
                case "btnWin2":
                    btn.BackColor = Color.Lime;
                    break;
                case "btnDraw":
                    btn.BackColor = Color.Gold;
                    break;
                case "btnTtlB":
                    btn.BackColor = Color.Green;
                    break;
                case "btnBoth":
                    btn.BackColor = Color.YellowGreen;
                    break;
                case "btnTtlM":
                    btn.BackColor = Color.Tomato;
                    break;
            }

           
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

        private void OwnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ModeForm mF = new ModeForm();
            mF.bal = bal;
            mF.Show();
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.LightGray;
            
        }

       
       
    }
}