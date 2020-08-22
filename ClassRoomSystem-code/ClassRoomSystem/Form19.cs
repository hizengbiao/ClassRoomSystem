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
    public partial class Form19 : Form
    {
        public Form19(string noo,string namee)
        {
            InitializeComponent();
            no = noo;
            name = namee;
            dbConnection = new SqlConnection(ConnectString);
            lo_cmd = new SqlCommand();   //创建命令对象
            lo_cmd.Connection = dbConnection;
            ShowDeptResult();
        }

        string ConnectString = "Data Source=HIZENGBIAO\\SQLEXPRESS;Initial Catalog=classroomsystem;User ID=sa;password=54hizengbiao";
        SqlConnection dbConnection;
        SqlCommand lo_cmd;

        string no = null;
        string name = null;

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDeptResult();
        }
        public void ShowDeptResult()
        {
            dbConnection.Open();   //打开数据库连接

            string sql = string.Format("select no,week,weekday,period,usee,condition from crapply where applyno='{0}';", no);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                lo_cmd.CommandText = string.Format("delete from crapply where no='{0}' and week={1} and weekday={2} and period='{3}' and applyno='{4}';", value1, value22, value33, value4, no);
                int count = lo_cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("删除信息成功！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除信息失败！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dbConnection.Close();
            ShowDeptResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form16 mainForm = new Form16(no, name);
            mainForm.Show();
            this.Close();
        }

        string value1 = null;
        string value2 = null;
        int value22, value33;
        string value3 = null;
        string value4 = null;

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
                value22 = Convert.ToInt32(value2);
                //获得当前行的第3列的值 
                value3 = dataGridView1.Rows[rowindex].Cells[2].Value.ToString().Trim();
                value33 = Convert.ToInt32(value3);
                //获得当前行的第4列的值 
                value4 = dataGridView1.Rows[rowindex].Cells[3].Value.ToString().Trim();
                //   MessageBox.show("第0列的值：{0};第一列的值：{1};第二列的值:{2}", value0, value1, value2);
            }
            catch/* (Exception exc)*/ {  /*MessageBox.Show(exc.Message); */}
        }



    }
}
