using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double n1, n2,result;
        string pro;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_result_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n2=Convert.ToDouble(lb_result.Text);
            if (pro == "+")
            {
                result = n1 + n2;
                lb_result.Text=Convert.ToString(result);
            }
            if (pro == "-")
            {
                result = n1 - n2;
                lb_result.Text = Convert.ToString(result);
            }
            if (pro == "/")
            {
                result = n1 / n2;
                lb_result.Text = Convert.ToString(result);
            }
            if (pro == "*")
            {
                result = n1 * n2;
                lb_result.Text = Convert.ToString(result);
            }
            lb_calculating.Text = ""; 
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            lb_result.Text = "";
            lb_calculating.Text = "";


        }

        private void pro_click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            n1=Convert.ToDouble(lb_result.Text );
            pro = btn.Text;
            if(lb_calculating.Text != "")
            {
                lb_calculating.Text = lb_calculating.Text + pro;

            }
            else
            {
                lb_calculating.Text = lb_result.Text + pro;

            }
            lb_result.Text = "";
        }



        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lb_result.Text=="0")
            {
                lb_result.Text = "";
                lb_result.Text = lb_result.Text + btn.Text;


            }
            else
            {
                lb_result.Text = lb_result.Text + btn.Text;

            }
            if (lb_calculating.Text != "")
            {
                lb_calculating.Text = lb_calculating.Text + btn.Text;
            }
            else
            {
                lb_calculating.Text = lb_result.Text;
            }

        }
    }
}
