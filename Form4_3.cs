using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RGU_Sem_4_Lr1._2_Form
{
    public partial class Form4_3 : Form
    {
        public Form4_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "";
                int speed = 0;
                text = textBox1.Text;
                if (text == "а" || text == "a")
                {
                    speed = 160;
                }
                else if (text == "в")
                {
                    speed = 25;
                }
                else if (text == "м" || text == "m")
                {
                    speed = 200;
                }
                else if (text == "с" || text == "c")
                {
                    speed = 1500;
                }
                else if (text == "п")
                {
                    speed = 200;
                }
                else
                {
                    MessageBox.Show("Некорректный символ. \nСимвол вводится согласно условию", "Ошибка");
                }
                if (speed != 0)
                {
                    label7.Text = text + " скорость = " + speed;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
           
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
