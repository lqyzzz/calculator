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
    
        public partial class Form2 : Form
       {  
            Form1 form1 = new Form1();
        
            public Form2(Form1 formFrm)
            {
                form1 = formFrm;
                InitializeComponent();
            }
            public Form2()
            {
                InitializeComponent();
            }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text.Equals(""))
            {
                Form3 form = new Form3(this);
                form.Show();
            }
            else {
                DataTable t = new System.Data.DataTable();
                string con = "server=(LocalDB)\\v11.0;database=information;integrated security=true";

                try
                {
                    using (SqlConnection myCon = new SqlConnection(con))
                    {
                        myCon.Open();                                       
                        String sql =  "update [Table] set gpa = '"+NewGPA.Text+"',xuefen = '"+newXuefen.Text+"' where id = '"+UserName.Text+"'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void label14_Click(object sender, EventArgs e)
        {

        }

        public void NewGPA_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }
    }
}
