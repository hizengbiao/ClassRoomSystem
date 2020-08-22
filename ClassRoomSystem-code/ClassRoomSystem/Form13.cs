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
    public partial class Form13 : Form
    {
        public Form13(string noo)
        {
            InitializeComponent();
            no = noo;

            dbConnection = new SqlConnection(ConnectString);
            lo_cmd1 = new SqlCommand();   //创建命令对象
            lo_cmd1.Connection = dbConnection;

            lo_cmd4 = new SqlCommand();   //创建命令对象
            lo_cmd5 = new SqlCommand();   //创建命令对象
            lo_cmd6 = new SqlCommand();   //创建命令对象
            lo_cmd2 = new SqlCommand();   //创建命令对象
            lo_cmd3 = new SqlCommand();   //创建命令对象


            lo_cmd4.Connection = dbConnection;
            lo_cmd5.Connection = dbConnection;
            lo_cmd6.Connection = dbConnection;
            lo_cmd2.Connection = dbConnection;
            lo_cmd3.Connection = dbConnection;

            try
            {
                dbConnection.Open();

                lo_cmd1.CommandText = string.Format("select no from people where no={0};",no);
                SqlDataAdapter dbAdapter1 = new SqlDataAdapter(lo_cmd1);
                DataSet ds1 = new DataSet(); //创建数据集对象
                dbAdapter1.Fill(ds1);
                value1 = ds1.Tables[0].Rows[0][0].ToString();

                lo_cmd2.CommandText = string.Format("select name from people where no={0};", no);
                SqlDataAdapter dbAdapter2 = new SqlDataAdapter(lo_cmd2);
                DataSet ds2 = new DataSet(); //创建数据集对象
                dbAdapter2.Fill(ds2);
                value2 = ds2.Tables[0].Rows[0][0].ToString();

                lo_cmd3.CommandText = string.Format("select sex from people where no={0};", no);
                SqlDataAdapter dbAdapter3 = new SqlDataAdapter(lo_cmd3);
                DataSet ds3 = new DataSet(); //创建数据集对象
                dbAdapter3.Fill(ds3);
                value3 = ds3.Tables[0].Rows[0][0].ToString();

                lo_cmd4.CommandText = string.Format("select job from people where no={0};", no);
                SqlDataAdapter dbAdapter4 = new SqlDataAdapter(lo_cmd4);
                DataSet ds4 = new DataSet(); //创建数据集对象
                dbAdapter4.Fill(ds4);
                value4 = ds4.Tables[0].Rows[0][0].ToString();

                lo_cmd5.CommandText = string.Format("select keyy from people where no={0};", no);
                SqlDataAdapter dbAdapter5 = new SqlDataAdapter(lo_cmd5);
                DataSet ds5 = new DataSet(); //创建数据集对象
                dbAdapter5.Fill(ds5);
                value5 = ds5.Tables[0].Rows[0][0].ToString();

                lo_cmd6.CommandText = string.Format("select tel from people where no={0};", no);
                SqlDataAdapter dbAdapter6 = new SqlDataAdapter(lo_cmd6);
                DataSet ds6 = new DataSet(); //创建数据集对象
                dbAdapter6.Fill(ds6);
                value6= ds6.Tables[0].Rows[0][0].ToString();
            }

            catch 
            { }
            dbConnection.Close();
        }

        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd1;
        SqlCommand lo_cmd2;
        SqlCommand lo_cmd3;
        SqlCommand lo_cmd4;
        SqlCommand lo_cmd5;
        SqlCommand lo_cmd6;

        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        string value6 = null;

        string no;
        private void Form13_Load(object sender, EventArgs e)
        {
            textBox1.Text = value1;
            textBox2.Text = value2;
            comboBox1.Text = value3;
            textBox5.Text = value5;
            textBox6.Text = value6;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1;
                dbConnection.Open();
                sql1 = string.Format("update people set no='{0}',name='{1}',sex='{2}',job='{3}',keyy='{4}',tel='{5}' where no='{6}';", textBox1.Text, textBox2.Text, comboBox1.Text, value4, textBox5.Text, textBox6.Text, no);

                lo_cmd1.CommandText = sql1;
                int count = lo_cmd1.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("修改信息成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (textBox1.Text != value1 || textBox5.Text != value5)
                    {
                         this.Close();
                        MessageBox.Show("您已修改了用户名或密码，请重新登录！");
                        //登录界面 mainForm = new 登录界面();
                        //mainForm.Show();
                    }
                    else
                    {
                        Form5 mainForm2 = new Form5(textBox1.Text, textBox2.Text);
                        this.Close();
                        mainForm2.Show();
                    }
                }
                else
                {
                    MessageBox.Show("修改信息失败！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dbConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 mainForm2 = new Form5(value1, value2);
            mainForm2.Show();

        }
    }
}
