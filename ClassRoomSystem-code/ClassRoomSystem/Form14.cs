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
    public partial class Form14 : Form
    {
        public Form14(string noo)
        {
            InitializeComponent();
            no = noo;

            dbConnection = new SqlConnection(ConnectString);
            lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.Connection = dbConnection;
        }

        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd;

        string no=null;

        public void ShowDeptResult()
        {
            int a, b;
            a=Convert.ToInt32(comboBox1.Text);
            b=Convert.ToInt32(comboBox2.Text);
            dbConnection.Open();   //打开数据库连接
            string sql = String.Format("select no from cr where no  not in (select no from cruse where cruse.rest=0 and cruse.week={0}  and cruse.weekday={1} and cruse.period ='{2}') and  no  not in(select no from crapply where crapply.week={0}  and crapply.weekday={1} and crapply.period ='{2}' and crapply.applyno='{3}');", a, b, comboBox3.Text,no);
        //    string sql2 = "select no from cr where no  not like 'admin%';";
            //返回查询结果
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdpt = new SqlDataAdapter(sql, dbConnection);  //执行查询
            dataAdpt.Fill(ds);

            dataGridView1.Rows.Clear();  //清空原有datagridview列表

            //将SQL的查询结果显示在datagridview中
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(/*i + 1, */ds.Tables[0].Rows[i][0]);
            }
            dbConnection.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ShowDeptResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                string sql = String.Format("insert into [crapply](no,week,weekday,period,applyno,usee,condition)" + "values('{0}',{1},{2},'{3}','{4}','自习','等待')", textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, no);
                lo_cmd.CommandText = sql;
                int count = lo_cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("恭喜您提交成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("对不起，提交失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dbConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
