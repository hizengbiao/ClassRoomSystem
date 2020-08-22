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
    public partial class Form5 : Form
    {
        public Form5(string noo,string namee)
        {
            InitializeComponent();
            name = namee;
            no = noo;
        }
        string name;
        string no;
        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 mainForm = new Form13(no);
            mainForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 mainForm = new Form15(no,name);
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 mainForm = new Form14(no);
            mainForm.Show();
        }
    }
}
