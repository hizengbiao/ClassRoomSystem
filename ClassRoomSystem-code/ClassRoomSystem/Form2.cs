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
    public partial class 注册界面 : Form
    {
        public 注册界面()
        {
            InitializeComponent();

            dbConnection = new SqlConnection(ConnectString);
            lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.Connection = dbConnection;
        }

        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                string no = Convert.ToString(textBox1.Text);
                string name = Convert.ToString(textBox2.Text);
                string sex = Convert.ToString(comboBox1.Text);
                string job = Convert.ToString(comboBox2.Text);
                string keyy = Convert.ToString(textBox3.Text);
                string tel = Convert.ToString(textBox4.Text);
                string sql = String.Format("insert into [people](no,name,sex,job,keyy,tel)" + "values('{0}','{1}','{2}','{3}','{4}','{5}')", no, name, sex, job, keyy, tel);
                //if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null)
                //{
                    lo_cmd.CommandText = sql;
                    int count = lo_cmd.ExecuteNonQuery();
                    if (count > 0 )
                    {
                        MessageBox.Show("恭喜您注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("对不起，注册失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                //}
                //else
                //{ MessageBox.Show("对不起，请输入完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dbConnection.Close();

        }

        private void 注册界面_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox2.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //登录界面 mainForm = new 登录界面();
            //mainForm.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sex_Click(object sender, EventArgs e)
        {

        }
    }
}
