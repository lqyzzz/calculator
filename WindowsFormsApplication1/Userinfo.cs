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
    public partial class Userinfo : Form
    {
        GPAmainwindow gpa = null;
        public Userinfo()
        {
            InitializeComponent();
        }
        public Userinfo(GPAmainwindow gpa)
        {
            InitializeComponent();
            this.gpa = gpa;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Userinfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            if (UserName.Text.Equals(""))
            {
                ID form = new ID(this);
                form.Show();
            }
            else
            {
                DataTable t = new System.Data.DataTable();
                string con = "server=(LocalDB)\\v11.0;database=information;integrated security=true";

                try
                {
                    using (SqlConnection myCon = new SqlConnection(con))
                    {
                        myCon.Open();
                        String sql = "update [Table] set gpa = '" + NewGPA.Text + "',xuefen = '" + newXuefen.Text + "' where id = '" + UserName.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, myCon);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            myCon.Close();
                            MessageBox.Show("成绩更新成功!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("{0} Exception caught.", ex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库打开失败，详细信息：" + ex.ToString());
                }
            }
        }

        private void CourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Userinfo_Closed(object sender, FormClosedEventArgs e)
        {
            gpa.WindowState = FormWindowState.Normal;
        }
    }
}
