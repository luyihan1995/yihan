﻿using System;
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
    public partial class FormTimer : Form
    {
        int second;
        public FormTimer()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
        }
    }
}
