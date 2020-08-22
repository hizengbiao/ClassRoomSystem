using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassRoomSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 mainForm = new Form4();
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 mainForm = new Form10();
            mainForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 mainForm = new Form6();
            mainForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 mainForm = new Form7();
            mainForm.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("谢谢你的使用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close(); 
        }
    }
}
