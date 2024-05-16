using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace n09310011
{
    public partial class FormPassword : Form 
    {
        int min = 0, max = 100;
        int answer;
        public FormPassword()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.answer = r.Next(100);
            System.Windows.MessageBox.Show(answer.ToString());
            label1.Text = "以隨機產生0~100數字,請在下方作答";
            label2.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Int32.Parse(textBox1.Text);
                if(input == this.answer) //答對了
                {
                    System.Windows.MessageBox.Show("恭喜答對!");
                }
                else if(input<this.answer)
                {
                    this.min = input;
                }
                else if(input > this.answer)
                {
                    this.max = input;
                }
                label2.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);
            } catch(Exception e1) {
                System.Windows.MessageBox.Show("輸入錯誤,請重新輸入錯誤");
             }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
