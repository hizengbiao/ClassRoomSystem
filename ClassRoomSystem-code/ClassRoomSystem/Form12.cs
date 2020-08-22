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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
            public Form12(string value1, string value2, string value3, string value4, string value5, string value6)
        {
            InitializeComponent(); 
            dbConnection = new SqlConnection(ConnectString);
            lo_cmd1 = new SqlCommand();   //创建命令对象
            lo_cmd1.Connection = dbConnection;
            textBox1.Text = value1;
            noo = value1;
            textBox2.Text = value2;
            textBox3.Text = value3;
            textBox4.Text = value4;
            aa = Convert.ToInt32(textBox4.Text);
            comboBox1.Text = value5;
            textBox6.Text = value6;
        }

        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd1;

        string sql1 = null;
        string noo = null;
        int aa;

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                dbConnection.Open();
                sql1 = string.Format("update cr set no='{0}',building='{1}',room='{2}',capacity={3},damage='{4}',manageno='{5}' where no='{6}';", textBox1.Text, textBox2.Text, textBox3.Text, aa, comboBox1.Text, textBox6.Text, noo);

                lo_cmd1.CommandText = sql1;
                int count = lo_cmd1.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("修改信息成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
        }
    }
}
