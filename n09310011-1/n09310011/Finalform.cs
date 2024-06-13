using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace n09310011
{
    public partial class Finalform : Form
    {
        public Finalform()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配餐\n", Encoding.UTF8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string main="", drinking = "";
            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        main+=chk.Text+" ";
                        //MessageBox.Show (chk.Text);
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
                        drinking+=chk.Text+" ";
                        //MessageBox.Show(chk.Text);
                    }
                }
            }
            main=main.Remove(main.Length-1, 1);
            drinking=drinking.Remove(drinking.Length-1, 1);

            DateTime currentDateTime = DateTime.Now;
            String orderTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");

            File.AppendAllText("OrderData.csv",orderTime+","+main+","+drinking+"\n");
            MessageBox.Show("點餐完成");
        }
    }
 }