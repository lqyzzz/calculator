namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddGPA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.courseName = new System.Windows.Forms.TextBox();
            this.courseXuefen = new System.Windows.Forms.TextBox();
            this.courseGPA = new System.Windows.Forms.TextBox();
            this.GPA = new System.Windows.Forms.Label();
            this.xuefen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA快速计算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "科目（可选）";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "学分";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "绩点";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddGPA
            // 
            this.AddGPA.Location = new System.Drawing.Point(489, 114);
            this.AddGPA.Name = "AddGPA";
            this.AddGPA.Size = new System.Drawing.Size(85, 25);
            this.AddGPA.TabIndex = 7;
            this.AddGPA.Text = "添加成绩";
            this.AddGPA.UseVisualStyleBackColor = true;
            this.AddGPA.Click += new System.EventHandler(this.AddGPA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "GPA:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "总学分：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(158, 206);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 10;
            this.cleanButton.Text = "清空";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(321, 206);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 11;
            this.finishButton.Text = "完成";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(91, 114);
            this.courseName.Multiline = true;
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(100, 25);
            this.courseName.TabIndex = 12;
            this.courseName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // courseXuefen
            // 
            this.courseXuefen.Location = new System.Drawing.Point(383, 114);
            this.courseXuefen.Multiline = true;
            this.courseXuefen.Name = "courseXuefen";
            this.courseXuefen.Size = new System.Drawing.Size(100, 25);
            this.courseXuefen.TabIndex = 13;
            // 
            // courseGPA
            // 
            this.courseGPA.Location = new System.Drawing.Point(254, 114);
            this.courseGPA.Multiline = true;
            this.courseGPA.Name = "courseGPA";
            this.courseGPA.Size = new System.Drawing.Size(100, 25);
            this.courseGPA.TabIndex = 14;
            this.courseGPA.TextChanged += new System.EventHandler(this.courseGPA_TextChanged);
            // 
            // GPA
            // 
            this.GPA.AutoSize = true;
            this.GPA.Location = new System.Drawing.Point(233, 161);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(0, 15);
            this.GPA.TabIndex = 15;
            // 
            // xuefen
            // 
            this.xuefen.AutoSize = true;
            this.xuefen.Location = new System.Drawing.Point(396, 161);
            this.xuefen.Name = "xuefen";
            this.xuefen.Size = new System.Drawing.Size(0, 15);
            this.xuefen.TabIndex = 16;
            this.xuefen.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 510);
            this.Controls.Add(this.xuefen);
            this.Controls.Add(this.GPA);
            this.Controls.Add(this.courseGPA);
            this.Controls.Add(this.courseXuefen);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddGPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddGPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.TextBox courseXuefen;
        private System.Windows.Forms.TextBox courseGPA;
        private System.Windows.Forms.Label GPA;
        private System.Windows.Forms.Label xuefen;

    }
}

