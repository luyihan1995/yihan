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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tmp = textBox1.Text;
            
            int c = Int32.Parse(tmp);
            //int result = c* (9 / 5) + 32;
            double result = c * 1.8 + 32;

            label3.Text = result.ToString();
        }
    }
}
