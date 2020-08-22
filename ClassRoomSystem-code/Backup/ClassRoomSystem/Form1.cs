using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace ClassRoomSystem
{
    public partial class 登录界面 : Form
    {
     
        public 登录界面()
        {
            InitializeComponent();
        }

        private void 注册_Click(object sender, EventArgs e)
        {
            注册界面 mainForm = new 注册界面();
            mainForm.Show();
            this.Hide();
        }

        private void 登录_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string PassWord = textBox2.Text;
            string keyyy = null;
            string jobb = null;
            string namee = null;

            SqlCommand lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.CommandText = string.Format("select keyy from people where no={0};",UserName);

            SqlDataAdapter dbAdapter = new SqlDataAdapter(lo_cmd); 
            DataSet ds = new DataSet(); //创建数据集对象
            dbAdapter.Fill(ds); 
            keyyy=ds.Tables[0].ToString();



            SqlCommand lo_cmd2 = new SqlCommand();   //创建命令对象
            lo_cmd2.CommandText = string.Format("select job from people where no={0};", UserName);

            SqlDataAdapter dbAdapter2 = new SqlDataAdapter(lo_cmd2);
            DataSet ds2 = new DataSet(); //创建数据集对象
            dbAdapter2.Fill(ds2);
            jobb = ds2.Tables[0].ToString(); 



            SqlCommand lo_cmd3 = new SqlCommand();   //创建命令对象
            lo_cmd3.CommandText = string.Format("select name from people where no={0};", UserName);

            SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd3);
            DataSet ds3 = new DataSet(); //创建数据集对象
            dbAdapter3.Fill(ds3);
            namee = ds3.Tables[0].ToString(); 


            if (PassWord == keyyy)
            {
                if (jobb == "学生")
                {
                    string message;
                    message = string.Format("{0}同学你好！欢迎进入点菜管理系统！", namee);
                    MessageBox.Show(message, "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form2 mainForm = new Form2();
                    //mainForm.Show();
                    //this.Hide();
                }
                else if (jobb == "教师")
                {
                    string message;
                    message = string.Format("{0}老师你好！欢迎进入点菜管理系统！", namee);
                    MessageBox.Show(message, "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form2 mainForm = new Form2();
                    //mainForm.Show();
                    //this.Hide();
                }
                else if (jobb == "负责人")
                {
                    string message;
                    message = string.Format("{0}你好！欢迎进入点菜管理系统！", namee);
                    MessageBox.Show(message, "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form2 mainForm = new Form2();
                    //mainForm.Show();
                    //this.Hide();
                }
                else
                {
                    string message;
                    message = string.Format("尊敬的管理员{0}，欢迎进入点菜管理系统！", namee);
                    MessageBox.Show(message, "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form2 mainForm = new Form2();
                    //mainForm.Show();
                    //this.Hide();
                }


            }
            else
            {
                MessageBox.Show("您输入的用户名或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
