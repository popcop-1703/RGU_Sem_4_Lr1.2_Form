using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RGU_Sem_4_Lr1._2_Form
{
    public partial class Form3_2 : Form
    {
        public Form3_2()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\for_lab.PNG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y = 0;
            try
            {
                if (!double.TryParse(textBox1.Text, out double a_) ||
                !double.TryParse(textBox2.Text, out double b_))
                {
                    MessageBox.Show("Пожалуйста, введите числовые значения!", "Ошибка");
                    return;
                }

                if (textBox1.Text == "")
                {
                    x = 0;
                }
                else
                {
                    x = double.Parse(textBox1.Text);
                }

                if (textBox2.Text == "")
                {
                    y = 0;
                }
                else
                {
                    y = double.Parse(textBox2.Text);
                }

                String a = "";
                if ((x > -15 && x < 0) && (y < 0 && y > -15))
                {
                    a = "Нет";
                }
                else if (((x >= -15 && x <= 0) && (y == 0 || y == -15)) || ((x == 0 || x == -15) && (y <= 0 && y >= -15)))
                {
                    a = "на границе";
                }
                else
                {
                    a = "да";
                }
                label4.Text = "Ответ: " + a;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
           

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-' && number != ',') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-' && number != ',') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
