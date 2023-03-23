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
    public partial class Form6_5 : Form
    {
        public Form6_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            int n = 5;
            int two = 2;
            int three = 2;
            for (int i = n; i >= 1; --i)
            {
                for (int j = 1; j <= i; j++)
                {
                    label3.Text += Convert.ToString(two) + " ";
                }
                label3.Text += "\n";
                for (int k = 1; k <= i; k++)
                {
                    label3.Text += Convert.ToString(three + k) + " ";
                }
                three--;
                label3.Text += "\n";
            }
        }
    }
}
