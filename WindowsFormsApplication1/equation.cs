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
    public partial class equation : Form
    {
        public equation()
        {
            InitializeComponent();
        }
        mainwindow cal = null;
        public equation(mainwindow cal)
        {
            InitializeComponent();
            this.cal = cal;
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            if (!a.Text.Any() || !b.Text.Any() || !c.Text.Any())
            {
                num.Text = "invalid input!";
                return;
            }
            double a1 = double.Parse(a.Text);
            double b1 = double.Parse(b.Text);
            double c1 = double.Parse(c.Text);
            if (Math.Pow(b1, 2) - 4 * a1 * c1 < 0)
                num.Text = "solution doesn't exisit!";
            else if (Math.Pow(b1, 2) - 4 * a1 * c1 == 0)
                num.Text = (-b1 / (2 * a1)).ToString("0.0000");
            else
                num.Text = ((-b1 + Math.Sqrt(Math.Pow(b1, 2) - 4 * a1 * c1)) / (2 * a1)).ToString("0.0000")
                    + " and " + ((-b1 - Math.Sqrt(Math.Pow(b1, 2) - 4 * a1 * c1)) / (2 * a1)).ToString("0.0000");
        }

        private void equation_Load(object sender, EventArgs e)
        {

        }

        private void equation_Closed(object sender, FormClosedEventArgs e)
        {
            cal.WindowState = System.Windows.Forms.FormWindowState.Normal;          
        }
    }
}
