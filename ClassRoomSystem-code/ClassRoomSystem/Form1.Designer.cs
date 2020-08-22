namespace ClassRoomSystem
{
    partial class 登录界面
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.登录编号 = new System.Windows.Forms.Label();
            this.登录密码 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.注册 = new System.Windows.Forms.Button();
            this.登录 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 登录编号
            // 
            this.登录编号.AutoSize = true;
            this.登录编号.Location = new System.Drawing.Point(47, 59);
            this.登录编号.Name = "登录编号";
            this.登录编号.Size = new System.Drawing.Size(41, 12);
            this.登录编号.TabIndex = 0;
            this.登录编号.Text = "编号：";
            // 
            // 登录密码
            // 
            this.登录密码.AutoSize = true;
            this.登录密码.Location = new System.Drawing.Point(47, 128);
            this.登录密码.Name = "登录密码";
            this.登录密码.Size = new System.Drawing.Size(41, 12);
            this.登录密码.TabIndex = 1;
            this.登录密码.Text = "密码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 21);
            this.textBox2.TabIndex = 3;
            // 
            // 注册
            // 
            this.注册.Location = new System.Drawing.Point(49, 205);
            this.注册.Name = "注册";
            this.注册.Size = new System.Drawing.Size(75, 23);
            this.注册.TabIndex = 4;
            this.注册.Text = "注册";
            this.注册.UseVisualStyleBackColor = true;
            this.注册.Click += new System.EventHandler(this.注册_Click);
            // 
            // 登录
            // 
            this.登录.Location = new System.Drawing.Point(174, 205);
            this.登录.Name = "登录";
            this.登录.Size = new System.Drawing.Size(75, 23);
            this.登录.TabIndex = 5;
            this.登录.Text = "登录";
            this.登录.UseVisualStyleBackColor = true;
            this.登录.Click += new System.EventHandler(this.登录_Click);
            // 
            // 登录界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.登录);
            this.Controls.Add(this.注册);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.登录密码);
            this.Controls.Add(this.登录编号);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "登录界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.登录界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 登录编号;
        private System.Windows.Forms.Label 登录密码;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button 注册;
        private System.Windows.Forms.Button 登录;
    }
}

