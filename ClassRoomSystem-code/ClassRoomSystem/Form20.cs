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
    public partial class Form20 : Form
    {
        public Form20(string UserName, string namee)
        {
            InitializeComponent();
            no = UserName;
            name = namee;
            dbConnection = new SqlConnection(ConnectString);
            lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.Connection = dbConnection;
            ShowDeptResult();
        }
        string no = null;
        string name = null;



        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd;

        public void ShowDeptResult()
        {
            dbConnection.Open();   //打开数据库连接

            string sql = string.Format("select no,building,room,capacity,damage from cr where manageno={0};",no);
            //返回查询结果
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdpt = new SqlDataAdapter(sql, dbConnection);  //执行查询
            dataAdpt.Fill(ds);

            dataGridView1.Rows.Clear();  //清空原有datagridview列表

            //将SQL的查询结果显示在datagridview中
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(/*i + 1, */ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1], ds.Tables[0].Rows[i][2], ds.Tables[0].Rows[i][3], ds.Tables[0].Rows[i][4]);
            }
            dbConnection.Close();

        }
        string value3 = "";
        string value1 = "";
        string value2 = "";
        string value4 = "";
        string value5 = "";

        private void Form20_Load(object sender, EventArgs e)
        {
            label1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDeptResult();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //ShowDeptResult();
            //  pnlBottom.Enabled = true;

            //获得当前选中的行 
            int rowindex = e.RowIndex;
            //string bb;
            //bb = rowindex.ToString();
            //MessageBox.Show(bb);

            try
            {
                //获得当前行的第一列的值 
                value1 = dataGridView1.Rows[rowindex].Cells[0].Value.ToString().Trim();

                //获得当前行的第二列的值 
                value2 = dataGridView1.Rows[rowindex].Cells[1].Value.ToString().Trim();

                //获得当前行的第3列的值 
                value3 = dataGridView1.Rows[rowindex].Cells[2].Value.ToString().Trim();

                //获得当前行的第4列的值 
                value4 = dataGridView1.Rows[rowindex].Cells[3].Value.ToString().Trim();

                //获得当前行的第5列的值 
                value5 = dataGridView1.Rows[rowindex].Cells[4].Value.ToString().Trim();

                //   MessageBox.show("第0列的值：{0};第一列的值：{1};第二列的值:{2}", value0, value1, value2);
            }
            catch/* (Exception exc)*/ {  /*MessageBox.Show(exc.Message); */}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            登录界面 mainForm = new 登录界面();
            mainForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1;
                dbConnection.Open();
                sql1 = string.Format("update cr set damage='未损坏' where no='{0}';", value1);
                if (value5 == "未损坏")
                {
                    MessageBox.Show("无需修改！");                 
                 }
                else
                {
                    lo_cmd.CommandText = sql1;
                    int count = lo_cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("修改信息成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("修改信息失败！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
