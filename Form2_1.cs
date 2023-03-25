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
    public partial class Form2_1 : Form
    {
        public Form2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (!double.TryParse(textBox1.Text, out double a))
                {
                    MessageBox.Show("Пожалуйста, введите числовое значение!", "Ошибка");
                    return;
                }
                double x = double.Parse(textBox1.Text);
                double y = 0;
                y = Math.Log(Math.Abs(x - 2));
                label2.Text = "Ответ: " + y;
            }
            catch 
            {
                MessageBox.Show("Ошибка!");
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
    }
}
