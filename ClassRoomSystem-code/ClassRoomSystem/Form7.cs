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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            dbConnection = new SqlConnection(ConnectString);
            lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.Connection = dbConnection;
            ShowDeptResult();
        }



        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd;


        public void ShowDeptResult()
        {
            dbConnection.Open();   //打开数据库连接

            string sql = "select * from cruse;";
            //返回查询结果
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdpt = new SqlDataAdapter(sql, dbConnection);  //执行查询
            dataAdpt.Fill(ds);

            dataGridView1.Rows.Clear();  //清空原有datagridview列表

            //将SQL的查询结果显示在datagridview中
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(/*i + 1, */ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1], ds.Tables[0].Rows[i][2], ds.Tables[0].Rows[i][3], ds.Tables[0].Rows[i][4], ds.Tables[0].Rows[i][5]);
            }
            dbConnection.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ShowDeptResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
