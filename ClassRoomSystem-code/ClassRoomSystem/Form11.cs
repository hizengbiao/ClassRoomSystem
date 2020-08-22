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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            dbConnection = new SqlConnection(ConnectString);
            lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.Connection = dbConnection;
        }

        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                int aa;
                string no = Convert.ToString(textBox1.Text);
                string name = Convert.ToString(textBox2.Text);
                string sex = Convert.ToString(textBox3.Text);
                string job = Convert.ToString(textBox4.Text);
                aa = Convert.ToInt32(job);

                string keyy = Convert.ToString(comboBox1.Text);
                string tel = Convert.ToString(textBox6.Text);
                string sql = String.Format("insert into [cr](no,building,room,capacity,damage,manageno)" + "values('{0}','{1}','{2}',{3},'{4}','{5}')", no, name, sex, job, keyy, tel);
                lo_cmd.CommandText = sql;
                int count = lo_cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
