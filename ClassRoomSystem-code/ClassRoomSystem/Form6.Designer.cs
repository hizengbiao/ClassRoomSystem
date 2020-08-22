namespace ClassRoomSystem
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.教室编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.周次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.星期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时段 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请人编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.教室编号,
            this.周次,
            this.星期,
            this.时段,
            this.申请人编号,
            this.用途,
            this.审核状态});
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(658, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 教室编号
            // 
            this.教室编号.HeaderText = "教室编号";
            this.教室编号.Name = "教室编号";
            // 
            // 周次
            // 
            this.周次.FillWeight = 70F;
            this.周次.HeaderText = "周次";
            this.周次.Name = "周次";
            this.周次.Width = 70;
            // 
            // 星期
            // 
            this.星期.FillWeight = 70F;
            this.星期.HeaderText = "星期";
            this.星期.Name = "星期";
            this.星期.Width = 70;
            // 
            // 时段
            // 
            this.时段.FillWeight = 60F;
            this.时段.HeaderText = "时段";
            this.时段.Name = "时段";
            this.时段.Width = 60;
            // 
            // 申请人编号
            // 
            this.申请人编号.HeaderText = "申请人编号";
            this.申请人编号.Name = "申请人编号";
            // 
            // 用途
            // 
            this.用途.HeaderText = "用途";
            this.用途.Name = "用途";
            this.用途.Width = 120;
            // 
            // 审核状态
            // 
            this.审核状态.HeaderText = "审核状态";
            this.审核状态.Name = "审核状态";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(579, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "返回";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "审核通过";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(456, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "审核拒绝";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教室申请审核";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教室编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 周次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 星期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时段;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请人编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核状态;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}