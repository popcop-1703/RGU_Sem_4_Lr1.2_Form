using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGU_Sem_4_Lr1._2_Form
{
    public partial class Form5_4 : Form
    {
        public Form5_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "") {
                listBox1.Items.Clear();
                for (int i = 100; i <= 999; i++)
                {
                    int a = i / 100;
                    int b = (i / 10) % 10;
                    int c = i % 10;
                    if (a == b || a == c || b == c)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            else
            {
                int number = int.Parse(textBox1.Text);
                listBox1.Items.Clear();
                for (int i = 100; i <= 999; i++)
                {
                    int a = i / 100;
                    int b = (i / 10) % 10;
                    int c = i % 10;
                    if (a == b || a == c || b == c)
                    {
                        if ((number == a && number == b) || (number == a && number == c) || (number == b && number == c))
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
