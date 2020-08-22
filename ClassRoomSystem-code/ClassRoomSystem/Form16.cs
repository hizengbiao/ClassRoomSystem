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
    public partial class Form16 : Form
    {
        public Form16(string UserName,string namee)
        {
            InitializeComponent();
            no = UserName;
            name = namee;
        }

        string no = null;
        string name = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Form18 mainForm = new Form18(no);
            mainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 mainForm = new Form17(no);
            mainForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form19 mainForm = new Form19(no, name);
            mainForm.Show();
            this.Hide();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            label1.Text = name;
        }
    }
}
