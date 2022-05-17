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
    public class Team
    {
        public string Name { get; set; }
        public int Force { get; set; }
        public Image Logos { get; set; }
        public Button Buttons { get; set; }
        public PictureBox Pboxes { get; set; }
        public Button Win { get; set; }
        public Button Draw { get; set; }
        public Label Score { get; set; }
        public TextBox TxtbSumm { get; set; }
        public Label LblTimer { get; set; } 


        public Team(string name, int force, Image image, Button btn, PictureBox pBox, Button win, Button draw, Label score, TextBox txtbSumm, Label lblTimer)
        {
            Name = name;
            Force = force;
            Logos = image;
            Buttons = btn;
            Pboxes = pBox;
            Win = win;
            Draw = draw;
            Score = score;
            TxtbSumm = txtbSumm;
            LblTimer = lblTimer;
        }

        public Team()
        {
        }

        static public void WriteProps(Team[] t, string f, char wrt)
        {
            f = $"\n\n {f} \n\n";
            for (int i = 1; i < t.Length; i++)
            {
               f += $" Team {i}:  {t[i].Name}; Btn: {t[i].Buttons.Name} - {t[i].Buttons.Text}\n";
            }

            if (wrt == 'm')
            {
                MessageBox.Show(f);
            }
            if (wrt == 'd')
            {
                Debug.Write(f);
            }
        }

        public void WriteTeamProps(Team t, string f, char wrt)
        {
            f = $"\n\n {f}; \n\n";
            
            f += $" Team:  {t.Name}; Btn: {t.Buttons.Name} - {t.Buttons.Text}\n";
            

            if (wrt == 'm')
            {
                MessageBox.Show(f);
            }
            if (wrt == 'd')
            {
                Debug.Write(f);
            }
        }
    }
}
