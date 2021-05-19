using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double a = rnd.NextDouble();
            double[] p = new double[6] { 0.1666, 0.1666, 0.1666, 0.1666, 0.1666, 0.1666 };
            double A = a;
            int k = 0;
            int pl1 = 0, pl2 = 0;
            int[] x = new int[6] { 1, 2, 3, 4, 5, 6 };
            while (true)
            {
                A = A - p[k];
                if (A <= 0)
                {
                    break;
                }
                k++;
            }
            textBox1.Text = x[k].ToString();
            pl1 = x[k];
            a = rnd.NextDouble();
            A = a;
            k = 0;
            while (true)
            {
                A = A - p[k];
                if (A <= 0)
                {
                    break;
                }
                k++;
            }
            textBox2.Text = x[k].ToString();
            pl2 = x[k];
            if (pl1 > pl2)
            {
                textBox3.Text = "Player 1";
            }
            else if (pl1 == pl2)
            {
                textBox3.Text = "Both or none";
            }
            else
            {
                textBox3.Text = "Player 2";
            }
        }
    }
}
