namespace SearchAndWatch
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeFileTxtbox = new System.Windows.Forms.TextBox();
            this.DownBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.SearchTxtbox = new System.Windows.Forms.TextBox();
            this.AllSearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchStartNumTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchEndNumTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchEndNumTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SearchStartNumTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChangeFileTxtbox);
            this.groupBox1.Controls.Add(this.DownBtn);
            this.groupBox1.Controls.Add(this.UpBtn);
            this.groupBox1.Controls.Add(this.SearchTxtbox);
            this.groupBox1.Controls.Add(this.AllSearchBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作栏";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "关键字：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "文件路径：";
            // 
            // ChangeFileTxtbox
            // 
            this.ChangeFileTxtbox.Location = new System.Drawing.Point(7, 107);
            this.ChangeFileTxtbox.Multiline = true;
            this.ChangeFileTxtbox.Name = "ChangeFileTxtbox";
            this.ChangeFileTxtbox.Size = new System.Drawing.Size(406, 21);
            this.ChangeFileTxtbox.TabIndex = 4;
            this.ChangeFileTxtbox.Text = "双击选文件";
            this.ChangeFileTxtbox.DoubleClick += new System.EventHandler(this.ChangeFileTxtbox_DoubleClick);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(338, 71);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 3;
            this.DownBtn.Text = "下一个";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(338, 25);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpBtn.TabIndex = 2;
            this.UpBtn.Text = "上一个";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // SearchTxtbox
            // 
            this.SearchTxtbox.Location = new System.Drawing.Point(6, 46);
            this.SearchTxtbox.Name = "SearchTxtbox";
            this.SearchTxtbox.Size = new System.Drawing.Size(296, 21);
            this.SearchTxtbox.TabIndex = 1;
            // 
            // AllSearchBtn
            // 
            this.AllSearchBtn.Location = new System.Drawing.Point(338, 168);
            this.AllSearchBtn.Name = "AllSearchBtn";
            this.AllSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.AllSearchBtn.TabIndex = 0;
            this.AllSearchBtn.Text = "全文搜索";
            this.AllSearchBtn.UseVisualStyleBackColor = true;
            this.AllSearchBtn.Click += new System.EventHandler(this.AllSearchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(793, 804);
            this.textBox1.TabIndex = 1;
            // 
            // SearchStartNumTxtBox
            // 
            this.SearchStartNumTxtBox.Location = new System.Drawing.Point(137, 140);
            this.SearchStartNumTxtBox.Name = "SearchStartNumTxtBox";
            this.SearchStartNumTxtBox.Size = new System.Drawing.Size(100, 21);
            this.SearchStartNumTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "搜索关键字前字符数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "搜索关键字后字符数：";
            // 
            // SearchEndNumTxtBox
            // 
            this.SearchEndNumTxtBox.Location = new System.Drawing.Point(137, 170);
            this.SearchEndNumTxtBox.Name = "SearchEndNumTxtBox";
            this.SearchEndNumTxtBox.Size = new System.Drawing.Size(100, 21);
            this.SearchEndNumTxtBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 839);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "搜索文本并显示关键信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangeFileTxtbox;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.TextBox SearchTxtbox;
        private System.Windows.Forms.Button AllSearchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SearchEndNumTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchStartNumTxtBox;
    }
}

