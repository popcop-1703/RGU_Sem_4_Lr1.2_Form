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
    public partial class Form4_3 : Form
    {
        public Form4_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            int speed = 0;
            text = textBox1.Text;
            if (text == "а")
            {
                speed = 60;
            }
            else if (text == "в")
            {
                speed = 20;
            }
            else if (text == "м")
            {
                speed = 40;
            }
            else if (text == "с")
            {
                speed = 200;
            }
            else if (text == "п")
            {
                speed = 120;
            }
            else
            {
                label7.Text = "Символ некорректный";
            }
            if (speed != 0)
            {
                label7.Text = text + " скорость = " + speed;
            }
        }
    }
}
