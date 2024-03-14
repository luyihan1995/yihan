using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310011
{
    public partial class 你按到人家了 : Form
    {
        public 你按到人家了()
        {
            InitializeComponent();
        }

        private void Formbutton_Load(object sender, EventArgs e)
        {
            if (b2.Text == "按我")
                b2.Text = "你按到人家了";
            else if (b2.Text == "你按到人家了")
                    b2.Text = "按我";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
