using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n09310011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "請按我一下")
               button1.Text = "我已經被按過了";

            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
            label1.Text = "按鈕被按過了";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String count = label2.Text;
            int sum = Int32.Parse(count) + 1;
            label2.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String count = label2.Text;
            int sum = Int32.Parse(count) - 1;
            label2.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new FormTimer();
            form.Show();
        }
    }
    
}
