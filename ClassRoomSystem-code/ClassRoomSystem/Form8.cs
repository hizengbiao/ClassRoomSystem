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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            dbConnection = new SqlConnection(ConnectString);
            lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.Connection = dbConnection;
        }

        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd;
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string keyy = Convert.ToString(textBox5.Text);
                string tel = Convert.ToString(textBox6.Text);
                string sql = String.Format("insert into [people](no,name,sex,job,keyy,tel)" + "values('{0}','{1}','{2}','{3}','{4}','{5}')", no, name, sex, job, keyy, tel);
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
    }
}
