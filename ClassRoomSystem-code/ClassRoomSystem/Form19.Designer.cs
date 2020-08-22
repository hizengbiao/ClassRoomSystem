namespace ClassRoomSystem
{
    partial class Form19
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
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.教室编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.周次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.星期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时段 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(412, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "返回";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.教室编号,
            this.周次,
            this.星期,
            this.时段,
            this.用途,
            this.申请状态});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(603, 140);
            this.dataGridView1.TabIndex = 6;
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
            this.时段.HeaderText = "时段";
            this.时段.Name = "时段";
            // 
            // 用途
            // 
            this.用途.HeaderText = "用途";
            this.用途.Name = "用途";
            // 
            // 申请状态
            // 
            this.申请状态.HeaderText = "申请状态";
            this.申请状态.Name = "申请状态";
            this.申请状态.Width = 120;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 261);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "已申请教室";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教室编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 周次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 星期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时段;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请状态;
    }
}