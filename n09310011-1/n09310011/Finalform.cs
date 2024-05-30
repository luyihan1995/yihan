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
    public partial class Finalform : Form
    {
        public Finalform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        MessageBox.Show (chk.Text);
                    }
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        MessageBox.Show(chk.Text);
                    }
                }
            }
        }
    }
 }