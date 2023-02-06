using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inText = textBox1.Text;
            textBox3.Text = Convert.ToString(inText.Length);
            textBox5.Text = Convert.ToString((5 - (inText.Length % 5)) == 5? 0 : (5 - inText.Length % 5));



            string str = "";
            bool flag = true;
            foreach (char i in inText)
            {
                flag = true;
                foreach (char sym in str)
                {
                    if (i == sym)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    str += i;
                }
            }
            int[] count = new int[str.Length];
            char symbol;
            for (int i = 0; i < str.Length; i++)
            {
                symbol = str[i];
                count[i] = 0;
                foreach(char j in inText)
                {
                    if (j == symbol)
                    {
                        count[i]++;
                    }
                }
            }
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    textBox6.Text += "Пробел";
                }
                else
                {
                    textBox6.Text += str[i];
                }
                textBox6.Text += "\t" + count[i] + Environment.NewLine;
            }


            int tmp = 5 - inText.Length % 5;
            if (tmp != 5)
            {
                for (int i = 0; i < tmp; i++)
                {
                    inText += ' ';
                }
            }
            string outText = "";

            int l = 0;
            for (int i=0; i < inText.Length / 5; i++)
            {
                outText += inText[l+2];
                outText += inText[l + 4];
                outText += inText[l];
                outText += inText[l + 3];
                outText += inText[l + 1];
                l += 5;
            }
            textBox2.Text = outText;
            for (int i = 0; i < str.Length; i++)
            {
                symbol = str[i];
                count[i] = 0;
                foreach (char j in outText)
                {
                    if (j == symbol)
                    {
                        count[i]++;
                    }

                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    textBox7.Text += "Пробел";
                }
                else
                {
                    textBox7.Text += str[i];
                }
                textBox7.Text += "\t" + count[i] + Environment.NewLine;
            }
            if (tmp == 5)
            {
                textBox8.Text = "совпадают";
            }
            else
            {
                textBox8.Text = "не совпадают";
            }
            textBox9.Text = inText + "->" + outText;

        }

       
    }
}
    

