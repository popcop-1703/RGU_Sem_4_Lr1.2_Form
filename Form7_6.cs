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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RGU_Sem_4_Lr1._2_Form
{
    public partial class Form7_6 : Form
    {
        public Form7_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            h = double.Parse(textBox3.Text);
            double y;
            int i = 1;
            label9.Text = "";
            label9.Text += "#   " + "x   " + "f(x) " + "\n";
            for (double x = a; x <= b; x += h, ++i)
            {
                if ((x + 2) <= 1)
                {
                    y = Math.Pow(x, 2);
                }
                else if ((x + 2) > 1 && (x + 2) < 10)
                {
                    y = 1 / (x + 2);
                }
                else
                {
                    y = x + 2;
                }

                label9.Text += i + "   " + x + "   " + Math.Round(y,3) + "\n";
            }
        }
    }
}
