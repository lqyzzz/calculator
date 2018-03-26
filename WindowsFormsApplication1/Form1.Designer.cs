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
            this.components = new System.ComponentModel.Container();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.oldGPA = new System.Windows.Forms.TextBox();
            this.oldXuefen = new System.Windows.Forms.TextBox();
            this.goalGPA = new System.Windows.Forms.TextBox();
            this.mayGPA = new System.Windows.Forms.TextBox();
            this.preCal = new System.Windows.Forms.Button();
            this.preJieguo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.help = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.informationDataSet1 = new WindowsFormsApplication1.informationDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet1 = new WindowsFormsApplication1.UserDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.userDataSet = new WindowsFormsApplication1.UserDataSet();
            this.userDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApplication1.UserDataSet1TableAdapters.TableTableAdapter();
            this.tableTableAdapter1 = new WindowsFormsApplication1.informationDataSet1TableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(100, 96);
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
            this.label4.Location = new System.Drawing.Point(275, 96);
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
            this.courseName.Location = new System.Drawing.Point(97, 116);
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
            this.courseGPA.Location = new System.Drawing.Point(242, 114);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "刷分小助手";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "现有GPA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "总学分";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "目标GPA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(409, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "预测得分";
            // 
            // oldGPA
            // 
            this.oldGPA.Location = new System.Drawing.Point(55, 348);
            this.oldGPA.Name = "oldGPA";
            this.oldGPA.Size = new System.Drawing.Size(100, 25);
            this.oldGPA.TabIndex = 22;
            this.oldGPA.TextChanged += new System.EventHandler(this.oldGPA_TextChanged);
            // 
            // oldXuefen
            // 
            this.oldXuefen.Location = new System.Drawing.Point(174, 348);
            this.oldXuefen.Name = "oldXuefen";
            this.oldXuefen.Size = new System.Drawing.Size(75, 25);
            this.oldXuefen.TabIndex = 23;
            // 
            // goalGPA
            // 
            this.goalGPA.Location = new System.Drawing.Point(278, 348);
            this.goalGPA.Name = "goalGPA";
            this.goalGPA.Size = new System.Drawing.Size(100, 25);
            this.goalGPA.TabIndex = 24;
            // 
            // mayGPA
            // 
            this.mayGPA.Location = new System.Drawing.Point(399, 348);
            this.mayGPA.Name = "mayGPA";
            this.mayGPA.Size = new System.Drawing.Size(100, 25);
            this.mayGPA.TabIndex = 25;
            // 
            // preCal
            // 
            this.preCal.Location = new System.Drawing.Point(237, 392);
            this.preCal.Name = "preCal";
            this.preCal.Size = new System.Drawing.Size(75, 23);
            this.preCal.TabIndex = 26;
            this.preCal.Text = "计算";
            this.preCal.UseVisualStyleBackColor = true;
            this.preCal.Click += new System.EventHandler(this.preCal_Click);
            // 
            // preJieguo
            // 
            this.preJieguo.AutoSize = true;
            this.preJieguo.Location = new System.Drawing.Point(219, 442);
            this.preJieguo.Name = "preJieguo";
            this.preJieguo.Size = new System.Drawing.Size(31, 15);
            this.preJieguo.TabIndex = 27;
            this.preJieguo.Text = "111";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.Location = new System.Drawing.Point(12, 9);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(22, 15);
            this.help.TabIndex = 28;
            this.help.Text = "？";
            this.toolTip1.SetToolTip(this.help, "这是一个帮助文本\r\n");
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tableBindingSource1;
            this.listBox1.DisplayMember = "id";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(79, 94);
            this.listBox1.TabIndex = 29;
            this.listBox1.ValueMember = "id";
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.informationDataSet1;
            // 
            // informationDataSet1
            // 
            this.informationDataSet1.DataSetName = "informationDataSet1";
            this.informationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.userDataSet1;
            // 
            // userDataSet1
            // 
            this.userDataSet1.DataSetName = "UserDataSet1";
            this.userDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "导入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataSetBindingSource
            // 
            this.userDataSetBindingSource.DataSource = this.userDataSet;
            this.userDataSetBindingSource.Position = 0;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.preJieguo);
            this.Controls.Add(this.preCal);
            this.Controls.Add(this.mayGPA);
            this.Controls.Add(this.goalGPA);
            this.Controls.Add(this.oldXuefen);
            this.Controls.Add(this.oldGPA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox oldGPA;
        private System.Windows.Forms.TextBox oldXuefen;
        private System.Windows.Forms.TextBox goalGPA;
        private System.Windows.Forms.TextBox mayGPA;
        private System.Windows.Forms.Button preCal;
        private System.Windows.Forms.Label preJieguo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource userDataSetBindingSource;
        private UserDataSet userDataSet;
        private UserDataSet1 userDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private UserDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private informationDataSet1 informationDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private informationDataSet1TableAdapters.TableTableAdapter tableTableAdapter1;

    }
}

