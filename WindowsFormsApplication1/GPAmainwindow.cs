using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class GPAmainwindow : Form
    {
        static int TotalXuefen = 0;
        static float TotalGPA = 0;
        string jilu = "";
        static string name = "";
        mainwindow mw = null;
        public GPAmainwindow()
        {
            InitializeComponent();
        }
        public GPAmainwindow(mainwindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GPAmainwindow_Closed(object sender, FormClosedEventArgs e)
        {
            mw.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            Userinfo userinfo = new Userinfo(this);
            userinfo.AllGPA.Text = jilu;
            userinfo.NewGPA.Text = GPA.Text;
            userinfo.newXuefen.Text = xuefen.Text;
            userinfo.UserName.Text = name;
            userinfo.Show();
        }

        private void GPAmainwindow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“informationDataSet1.Table”中。您可以根据需要移动或删除它。
            this.tableTableAdapter1.Fill(this.informationDataSet1.Table);
            // TODO: 这行代码将数据加载到表“userDataSet1.Table”中。您可以根据需要移动或删除它。
            this.tableTableAdapter.Fill(this.userDataSet1.Table);
            // TODO: 这行代码将数据加载到表“userInfoDataSet3.Table”中。您可以根据需要移动或删除它。
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (courseName.Text == "")
            {
                courseName.Text = "        ";

            }
            jilu = jilu + "\n" + courseName.Text + "     " + courseGPA.Text + "        " + courseXuefen.Text;
            TotalGPA = (TotalGPA * TotalXuefen + float.Parse(courseGPA.Text) * int.Parse(courseXuefen.Text)) / (int.Parse(courseXuefen.Text) + TotalXuefen);
            TotalXuefen = TotalXuefen + int.Parse(courseXuefen.Text);

            xuefen.Text = Convert.ToString(TotalXuefen);
            GPA.Text = Convert.ToString(TotalGPA);
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            courseName.Text = "";
            courseGPA.Text = "";
            courseXuefen.Text = "";
            GPA.Text = "";
            xuefen.Text = "";
            TotalGPA = 0;
            TotalXuefen = 0;
            name = "";
        }

        private void LeadIn_Click(object sender, EventArgs e)
        {
            List.Visible = !List.Visible;
        }

        private void preCal_Click(object sender, EventArgs e)
        {
            float G1 = float.Parse(oldGPA.Text);
            float G2 = float.Parse(goalGPA.Text);
            float G3 = float.Parse(mayGPA.Text);
            int X1 = int.Parse(oldXuefen.Text);
            double X2 = (X1 * (G1 - G2)) / (G2 - G3);
            string X3 = Math.Round(X2).ToString();
            preJieguo.Text = "大约需要修学分:" + X3 + "分";
            if (int.Parse(X3) > 10)
            {
                preJieguo.Text = preJieguo.Text + "\n所需要的学分较多,请注意!";
            }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = List.IndexFromPoint(e.X, e.Y);
            List.SelectedIndex = index;
            if (List.SelectedIndex != -1)
            {


                DataTable t = new System.Data.DataTable();
                string con = "server=(LocalDB)\\v11.0;database=information;integrated security=true";
                string s = this.List.SelectedValue.ToString();
                name = s;

                try
                {
                    using (SqlConnection myCon = new SqlConnection(con))
                    {
                        myCon.Open();
                        String sql = "select * from [Table] where id ='" + s + "'";
                        SqlCommand cmd = new SqlCommand(sql, myCon);
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                string gpa = sdr.GetString(1);
                                string xuefen2 = sdr.GetString(2);
                                GPA.Text = gpa;
                                xuefen.Text = xuefen2;
                                TotalGPA = float.Parse(gpa);
                                TotalXuefen = int.Parse(xuefen2);
                            }
                            else
                            {
                                MessageBox.Show("gg");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库打开失败，详细信息：" + ex.ToString());
                }
            }
            List.Visible = !List.Visible;
        }
    }
}
