using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class table : Form
    {
        mainwindow mw = null;
        public table()
        {
            InitializeComponent();
        }
        public table(mainwindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void table_Load(object sender, EventArgs e)
        {

        }

        private void variablex_Click(object sender, EventArgs e)
        {
            string s = variableinput.Text;
            int idx = variableinput.SelectionStart;
            s = s.Insert(idx, "X");

            variableinput.Text = s;
            variableinput.SelectionStart = idx + 1;
            variableinput.Focus();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (!variableinput.Text.Any())
                result.Text = "null input!";
            else
            {
                string s = variableinput.Text;
                string temp = "";
                double init = double.Parse(initialvalue.Text);
                double st = double.Parse(stepvalue.Text);
                int time = int.Parse(timesvalue.Text);
                for(int i = 0;i < time;i++)
                {

                    temp = s.Replace("X", init.ToString());
                    result.Text += mainwindow.Calculate(temp).ToString("F6") + "\r\n";
                    init += st;
                }

            }

        }

        private void table_Close(object sender, FormClosedEventArgs e)
        {
            mw.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
