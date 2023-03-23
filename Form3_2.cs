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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
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
    }
}
