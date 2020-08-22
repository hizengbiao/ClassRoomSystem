namespace ClassRoomSystem
{
    partial class 注册界面
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.no = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.keyy = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.立即注册 = new System.Windows.Forms.Button();
            this.返回登录 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(59, 34);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(35, 12);
            this.no.TabIndex = 0;
            this.no.Text = "编号:";
            this.no.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(59, 89);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 12);
            this.name.TabIndex = 0;
            this.name.Text = "姓名:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Location = new System.Drawing.Point(59, 186);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(35, 12);
            this.job.TabIndex = 0;
            this.job.Text = "职务:";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(59, 136);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(35, 12);
            this.sex.TabIndex = 0;
            this.sex.Text = "性别:";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(48, 294);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(59, 12);
            this.tel.TabIndex = 0;
            this.tel.Text = "联系电话:";
            // 
            // keyy
            // 
            this.keyy.AutoSize = true;
            this.keyy.Location = new System.Drawing.Point(59, 235);
            this.keyy.Name = "keyy";
            this.keyy.Size = new System.Drawing.Size(35, 12);
            this.keyy.TabIndex = 0;
            this.keyy.Text = "密码:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 21);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 21);
            this.textBox5.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(147, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 178);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "*";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "*";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(42, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "*";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(42, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "*";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // 立即注册
            // 
            this.立即注册.Location = new System.Drawing.Point(182, 373);
            this.立即注册.Name = "立即注册";
            this.立即注册.Size = new System.Drawing.Size(75, 23);
            this.立即注册.TabIndex = 3;
            this.立即注册.Text = "立即注册";
            this.立即注册.UseVisualStyleBackColor = true;
            this.立即注册.Click += new System.EventHandler(this.button1_Click);
            // 
            // 返回登录
            // 
            this.返回登录.Location = new System.Drawing.Point(61, 373);
            this.返回登录.Name = "返回登录";
            this.返回登录.Size = new System.Drawing.Size(75, 23);
            this.返回登录.TabIndex = 3;
            this.返回登录.Text = "返回登录";
            this.返回登录.UseVisualStyleBackColor = true;
            this.返回登录.Click += new System.EventHandler(this.button1_Click);
            // 
            // 注册界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 454);
            this.Controls.Add(this.返回登录);
            this.Controls.Add(this.立即注册);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.keyy);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.job);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no);
            this.Name = "注册界面";
            this.Text = "注册界面";
            this.Load += new System.EventHandler(this.注册界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label job;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label keyy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button 立即注册;
        private System.Windows.Forms.Button 返回登录;
    }
}