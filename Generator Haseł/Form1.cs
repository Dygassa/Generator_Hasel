using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Generator_Haseł
{
    public partial class Form1 : Form
    {
        public string[] tabL = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        public string[] tabS = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m" };
        public string[] tabB = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };

        /*public string[] tabSp = {"~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "{", "[", "}", "]", "\\", "|", ";", ":", "'", "\"", ",", "<", ".", ">" };
*/      //      , . + = _ & # @ !
        public string[] tabSp = { ",", ".", "+", "=", "_", "&", "#", "@", "!" };
        string TablicaZnakow(int x)
        {
            return "";
        }
        public Form1()
        {
            InitializeComponent();
            var y1 = this.Size.Height;
            var screens = System.Windows.Forms.Screen.AllScreens;
            var bounds = screens[0].Bounds;
            var y2 = bounds.Height;
            var pointY = new System.Drawing.Point(0, y2 - y1 - 50);
            this.Location = pointY;
        }
        public bool checkMatch(string haslo, string[] tab)
        {
            for (int i = 0; i < haslo.Length; i++)
            {
                for (int j = 0; j < tabL.Length; j++)
                {
                    if (Convert.ToString(haslo[i]) == Convert.ToString(tab[j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
            if (checkBoxBig.Checked is false && checkBoxLiczby.Checked is false && checkBoxSmall.Checked is false && checkBoxSpecial.Checked is false)
            {
                MessageBox.Show("Zaznacz chociaż jeden zbiór znaków");
            }
            else
            {
                int L = 71, Ltmp = 0;
                if (checkBoxLiczby.Checked is false)
                {
                    L -= 10;
                }
                if (checkBoxSmall.Checked is false)
                {
                    L -= 26;
                }
                if (checkBoxBig.Checked is false)
                {
                    L -= 26;
                }
                if (checkBoxSpecial.Checked is false)
                {
                    L -= 9;
                }
                string[] tab = new string[L];
                if (checkBoxLiczby.Checked is true)
                {
                    for (int i = Ltmp; i < Ltmp + 10; i++)
                    {
                        tab[i] = tabL[i - Ltmp];
                    }
                    Ltmp += 10;
                }
                if (checkBoxSmall.Checked is true)
                {
                    for (int i = Ltmp; i < Ltmp + 26; i++)
                    {
                        tab[i] = tabS[i - Ltmp];
                    }
                    Ltmp += 26;
                }
                if (checkBoxBig.Checked is true)
                {
                    for (int i = Ltmp; i < Ltmp + 26; i++)
                    {
                        tab[i] = tabB[i - Ltmp];
                    }
                    Ltmp += 26;
                }
                if (checkBoxSpecial.Checked is true)
                {
                    for (int i = Ltmp; i < Ltmp + 9; i++)
                    {
                        tab[i] = tabSp[i - Ltmp];
                    }
                    Ltmp += 9;
                }
                try
                {
                    String haslo = "";
                    int Lhasła = Convert.ToInt32(IloscSymboli.Text);
                    if (Lhasła != 0)
                    {
                        Random r = new Random();
                        if (Lhasła <= 100000)
                        {
                            for (int i = 0; i < Lhasła; i++)
                            {
                                haslo = haslo + tab[r.Next(0, tab.Length)];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Za duża ilość znaków");
                        }
                        Haslo.Text = haslo;
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawna ilość symboli");
                    }
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Niepoprawna ilość symboli");
                }
            }
        }

        private void StartCopyButton_Click(object sender, EventArgs e)
        {
            StartButton_Click(sender, e);
            try
            {
                Clipboard.SetText(Haslo.Text);
            }
            catch (System.ArgumentNullException)
            {
                Clipboard.SetText(" ");
            }
        }

        private void alwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = alwaysTop.Checked;
        }
    }
}