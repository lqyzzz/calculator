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
using System.Configuration;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Form2 form = new Form2();

        public Form3(Form2 formFrm)
        {
            form = formFrm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string userid = Convert.ToString(userID.Text);
             string usergpa = Convert.ToString(form.NewGPA.Text);
             string userxuefen = Convert.ToString(form.newXuefen.Text);

             DataTable t = new System.Data.DataTable();
             string con = "server=(LocalDB)\\v11.0;database=information;integrated security=true";

             try
             {
                 using (SqlConnection myCon = new SqlConnection(con))
                 {
                     myCon.Open();
                     String sql = "insert into  [Table](id,gpa,xuefen) values('"+userid+"','"+usergpa+"','"+userxuefen+"')";
                     try
                     {
                         using (SqlCommand cmd = new SqlCommand(sql, myCon))
                         {
                             cmd.ExecuteNonQuery();
                             myCon.Close();
                             MessageBox.Show("成绩保存成功!");
                         }
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
             this.Close();
             form.Close();
        }
    }
}

        
   