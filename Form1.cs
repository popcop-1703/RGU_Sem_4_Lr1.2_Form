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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_1 newForm2 = new Form2_1();
            newForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3_2 newForm3 = new Form3_2();
            newForm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4_3 newForm4 = new Form4_3();
            newForm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5_4 newForm5 = new Form5_4();
            newForm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6_5 newForm6 = new Form6_5();
            newForm6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7_6 newForm7 = new Form7_6();
            newForm7.Show();
        }
    }
}
