using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class mainwindow : Form
    {
        int ans = 0;

        public string calculate(string abc)
        {
            double result = 1;
            double fresult = 0;
            string protype = abc;
            string copy = "";//copy用来计算简单式子，比阶乘和平方低级的运算符
            while (!IsNumber(protype))
            {   
                for (int i = 0; i < protype.Length; i++)
                {
                    if (protype[i].ToString().Equals("!"))
                    {
                        int inx = i - 1;
                        string x = "";

                        while (inx >= 0 && IsNumber(protype[inx].ToString()))
                        {
                            x = protype[inx].ToString() + x;
                            inx = inx - 1;
                        }

                        int num = int.Parse(x);
                        for (int j = 1; j <= num; j++)
                            result *= j;

                        fresult = result;
                        copy = protype.Substring(0, inx + 1);
                        copy = copy + result.ToString();
                        protype = protype.Substring(i + 1);
                        protype = copy + protype;
                        copy = "";
                        result = 1;
                        //string rep = x + "!";
                        //abc.Replace(rep, result.ToString());
                        break;
                    }

                    else if (protype[i].ToString().Equals("^"))
                    {
                        int inx = i - 1;
                        string x = "";
                        while (inx >= 0 && IsNumber(protype[inx].ToString()))
                        {
                            x = protype[inx].ToString() + x;
                            inx = inx - 1;
                        }
                        int num = int.Parse(x);
                        result = num * num;
                        fresult = result;

                        copy = protype.Substring(0, inx + 1);
                        copy = copy + result.ToString();
                        protype = protype.Substring(i + 2);
                        protype = copy + protype;
                        copy = "";
                        result = 1;

                        break;
                    }

                    else
                    {
                        copy += protype[i];
                        if (copy.Equals(protype))
                        {
                            string str = protype;
                            str = operation.Calc(str, '*');
                            str = operation.Calc(str, '/');
                            str = operation.Calc(str, '+');
                            str = operation.Calc(str, '-');
                            fresult = double.Parse(str);
                            protype = fresult.ToString();
                            
                        }
                    }
                }                
            }
            return fresult.ToString();
        }

    public static bool IsNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            const string pattern = "^[0-9]*$";
            Regex rx = new Regex(pattern);

            return rx.IsMatch(s);
        }

    public mainwindow()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "0");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void deg_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "Ans");

            input.Text = s;
            input.SelectionStart = idx + 3;
            input.Focus();
        }

        private void solveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plus1_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "+");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void one_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "1");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void point_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, ".");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void two_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "2");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void three_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "3");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void four_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "4");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void five_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "5");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void six_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "6");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "7");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "8");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "9");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void lbracket_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "(");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void rbracket_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, ")");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void substract1_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "-");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

            private void multiply1_Click(object sender, EventArgs e)
        {
                string s = input.Text;
                int idx = input.SelectionStart;
                s = s.Insert(idx, "×");

                input.Text = s;
                input.SelectionStart = idx + 1;
                input.Focus();
            }

        private void divide1_Click(object sender, EventArgs e)
        {
                string s = input.Text;
                int idx = input.SelectionStart;
                s = s.Insert(idx, "÷");

                input.Text = s;
                input.SelectionStart = idx + 1;
                input.Focus();
            }

        private void equal1_Click(object sender, EventArgs e)
        {
            Stack<string> value = new Stack<string>();            
            string s = input.Text;
            s = s.Replace('×','*');
            s = s.Replace('÷','/');
            output.Text = calculate(s);
            foreach(char index in s)
            {
                if (index.Equals(')')) {

                }else {
                    value.Push(index.ToString());
                }
                
            }

        }

        private void pi_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, Math.PI.ToString());

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void e_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, Math.E.ToString());

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
            
        }

        private void sin_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "sin()");

            input.Text = s;
            input.SelectionStart = idx + 4;
            input.Focus();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "cos()");

            input.Text = s;
            input.SelectionStart = idx + 4;
            input.Focus();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "tan()");

            input.Text = s;
            input.SelectionStart = idx + 4;
            input.Focus();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "!");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void ln_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "ln()");

            input.Text = s;
            input.SelectionStart = idx + 3;
            input.Focus();
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "cos(");

            input.Text = s;
            input.SelectionStart = idx + 1;
            input.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Remove(idx-1, 1);

            input.Text = s;
            input.SelectionStart = idx -1;
            input.Focus();
        }

        private void extract2_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "√()");

            input.Text = s;
            input.SelectionStart = idx + 2;
            input.Focus();
        }

        private void extracty_Click(object sender, EventArgs e)
        {
            string s = input.Text;
            int idx = input.SelectionStart;
            s = s.Insert(idx, "^2");

            input.Text = s;
            input.SelectionStart = idx + 2;
            input.Focus();
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
