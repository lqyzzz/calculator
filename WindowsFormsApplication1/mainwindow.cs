using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Media;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class mainwindow : Form
    {
        static string ans = "";
        static Stack<char> sck = new Stack<char>();
        static equation eq = null;
        static table tb = null;
        static GPAmainwindow gpa = null;
        /*public string calculate(string abc)
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
                        while (inx >= 0 && (IsNumber(protype[inx].ToString()) || protype[inx].Equals('.')))
                        {
                            x = protype[inx].ToString() + x;
                            inx = inx - 1;
                        }
                        double num = double.Parse(x);
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
                            /*string str = protype;
                            str = operation.Calc(str, '*');
                            str = operation.Calc(str, '/');
                            str = operation.Calc(str, '+');
                            str = operation.Calc(str, '-');//
                            DataTable table = new DataTable();
                            
                            fresult = double.Parse(table.Compute(copy, "").ToString());
                            protype = fresult.ToString();
                            
                        }
                    }
                }                
            }
            return fresult.ToString();
        }*/

        public static double Calculate(string s)
        {
            double num = 0;//存储递归回来的数
            //double result = 0;//存储结果
            int len = s.Length;
            string copy = "";//存储进入递归之后的字符串
            string cal = "";//存储从栈弹出的字符串
            int i = 0;//跟字符串s比较长度
            while (i < len)
            {
                if (s[i].Equals('('))
                {
                    sck.Push('(');
                    copy = s.Substring(i + 1);
                    num = Calculate(copy);
                    ComplexOp(num);//计算函数
                    i = i + 1;
                    while (i < len && !s[i].Equals(')'))
                        i ++;
                    i++;
                    continue;
                }
                else if (!s[i].Equals(')'))
                {
                    sck.Push(s[i]);
                    i++;
                }
                else
                {
                    while (sck.Peek() != '(')
                    {
                        cal = sck.Pop() + cal;
                        if (!sck.Any()) break;
                    }
                    if(!sck.Any()) break;
                    else sck.Pop();
                    num = SimpleOp(cal);
                    return num;
                }
            }
            if(i == len)//当表达式带有括号时
            {
                string temp = "";
                while (sck.Count > 0)
                    temp = sck.Pop() + temp;
                return SimpleOp(temp);
            }       
            return num;
        }

        public static void ComplexOp(double num)
        {
            string cal = "";
            double result = 0;
            if (sck.Peek() == '^')
            {
                sck.Pop();
                while (sck.Peek() != '+' && sck.Peek() != '-' && sck.Peek() != '*' && sck.Peek() != '/' && sck.Peek() != '(')
                {
                    cal = sck.Pop() + cal;
                    if (!sck.Any()) break;/////???
                }
                result = double.Parse(cal);
                foreach (char j in Math.Pow(result,num).ToString())
                    sck.Push(j);
            }
            else if (sck.Peek() == '√')
            {
                sck.Pop();
                foreach (char j in Math.Sqrt(num).ToString())
                    sck.Push(j);
            }
            else if (sck.Peek() == 's')
            {
                sck.Pop(); sck.Pop(); sck.Pop();
                foreach (char j in Math.Cos(num).ToString())
                    sck.Push(j);
            }
            else
            {
                sck.Pop();
                if (sck.Peek() == 'i')
                {
                    sck.Pop(); sck.Pop();
                    foreach (char j in Math.Sin(num).ToString())
                        sck.Push(j);
                }
                else if (sck.Peek() == 'a')
                {
                    sck.Pop(); sck.Pop();
                    foreach (char j in Math.Tan(num).ToString())
                        sck.Push(j);
                }
                else
                {
                    sck.Pop();
                    foreach (char j in Math.Log(num).ToString())
                        sck.Push(j);
                }
            }
        }

        public static double SimpleOp(string s)
        {
            Stack<char> stack = new Stack<char>();
            string copy = s;           
            double result = 0;
            int len = copy.Length;
            if (s.Contains('^') || s.Contains('!'))
            {
                //while (true)
                //{     
                string sty = "";
                for(int i = 0; i < len; i++)
                    {
                        string tem = "";
                        if (!copy[i].Equals('^') && !copy[i].Equals('!'))
                        {
                            stack.Push(copy[i]);
                        }
                        else if(copy[i].Equals('^'))
                        {
                            while (stack.Peek() != '+' && stack.Peek() != '-' && stack.Peek() != '*' && stack.Peek() != '/')
                            {
                                tem = stack.Pop() + tem;
                                if (!stack.Any()) break;
                            }
                            double num = Math.Pow(double.Parse(tem), 2);
                            foreach(char j in num.ToString())
                                stack.Push(j);
                            i = i + 1;
                            continue;
                        }
                        else if(copy[i].Equals('!'))
                        {
                            while (stack.Peek() != '+' && stack.Peek() != '-' && stack.Peek() != '*' && stack.Peek() != '/')
                            {
                                tem = stack.Pop() + tem;
                                if (!stack.Any()) break;
                            }
                            int Int = int.Parse(tem);
                            int temp = 1;//作为阶乘的临时变量
                            for (int k = 1; k <= Int; k++)
                                temp *= k;
                            foreach (char m in temp.ToString())
                                stack.Push(m);                            
                            continue;
                        }
                    }
                //}
                while (stack.Any())
                    sty = stack.Pop() + sty;
                DataTable table = new DataTable();
                result = double.Parse(table.Compute(sty, "").ToString());
            }
            else
            {
                if (!s.Any())  //3.22添加，防止直接点击=错误
                    return 0;
                else
                {
                    DataTable table = new DataTable();
                    result = double.Parse(table.Compute(copy, "").ToString());
                }
                               
            }
              return result;
        }

        public static bool IsNumberOrFormula(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            const string patternfloat = "^[0-9]+(.[0-9]+)?$";
            Regex rx = new Regex(patternfloat);

            const string patternint = "^[0-9]+$";
            Regex rx2 = new Regex(patternint);

            const string patternfo = "[+-*/]";
            Regex rx3 = new Regex(patternfo);

            return rx.IsMatch(s) || rx2.IsMatch(s) || rx3.IsMatch(s);
        }

        /*public bool IsNumber(string str)
        {
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int len = str.Length;
            for (int i = 0; i<len;i++)    {
                if (ch[i] < 46 || ch[i] > 57 || ch[i] == 47)
                    return false;
                else if (str.Equals(')')) ?
            }
            return true;
        }*/

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
            string ans = output.Text;
            mainwindow.ans = ans;
            input.Text = "Ans";
            int idx = input.SelectionStart;

            input.SelectionStart = 3;
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
            string s = input.Text;
            s = s.Replace('×','*');
            s = s.Replace('÷','/');
            s = s.Replace("Ans", mainwindow.ans);
            s = Calculate(s).ToString();
            output.Text = s;

            /*while (s.IndexOf('(')!=-1)
            {
                int len = s.Length;
                string str = "";
                for (int i = 0; i< len; i++) {
                    
                    if (s[i].Equals(')'))
                    {
                        for (int j = i-1; j >= 0; j--)
                        {
                            if (!s[j].Equals('('))
                            {
                                str = s[j] + str;
                            }
                            else break; 
                        }
                    }

                }
                string newstr = calculate(str);
                str = "(" + str + ")";
                s.Replace(str, newstr);
                break;
            }
            s = calculate(s);
            output.Text = s;*/
            /*string s = input.Text;
            s = s.Replace('×', '*');
            s = s.Replace('÷', '/');
            output.Text = Calculate(s).ToString();*/
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
            s = s.Insert(idx, "^()");

            input.Text = s;
            input.SelectionStart = idx + 2;
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

        private void equation_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            if (eq == null || eq.IsDisposed)
                eq = new equation(this);
            if (!eq.Created)
            {
                eq.Show();
                eq.Activate();
            }

        }

        private void transform_Click(object sender, EventArgs e)//暂无考虑无限循环小数
            //和(0.不循环数+循环数)
        {
            if (!output.Text.Any())
                output.Text = "";
            else
            {
                double outtext = double.Parse(output.Text);
                double intnum = Math.Floor(outtext);
                double point = outtext - intnum;
                int numerator = 0;
                int denominator = 0;
                if (output.Text.IndexOf('.') == -1)
                    output.Text = output.Text;
                string s = output.Text.Substring(output.Text.IndexOf('.'));
                int len = s.Length;

                denominator = (int)Math.Pow(10, len);
                numerator = (int)(Math.Pow(10, len) * point);

                int maxdivisor = gcd(numerator, denominator);

                output.Text = "";

                if ((int)(outtext - intnum) == 0)
                {
                    output.Text = (numerator / maxdivisor).ToString()
                    + "/" + (denominator / maxdivisor).ToString();
                }
                else
                {
                    output.Text = (outtext - intnum).ToString() + "+" + (numerator / maxdivisor).ToString()
                    + "/" + (denominator / maxdivisor).ToString();
                }
            }
            
        }
        private int gcd(int numerator, int denominator)
        {
            int temp = 0;
            for( temp = denominator % numerator; temp != 0;temp = denominator % numerator)
            {
                denominator = numerator;
                numerator = temp;
            }
            return numerator;
        }

        private void table_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            if (tb == null || tb.IsDisposed)
                tb = new table(this);
            if (!tb.Created)
            {
                tb.Show();
                tb.Activate();
            }
        }

        private void gPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            if (gpa == null || gpa.IsDisposed)
                gpa = new GPAmainwindow(this);
            if (!gpa.Created)
            {
                gpa.Show();
                gpa.Activate();
            }
        }
    }
}
