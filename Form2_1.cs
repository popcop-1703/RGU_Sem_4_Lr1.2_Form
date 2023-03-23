using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double x = double.Parse(textBox1.Text);
            double y = 0;
            y = Math.Log(Math.Abs(x - 2));
            label2.Text = "Ответ: " + y;

        }
    }
}
