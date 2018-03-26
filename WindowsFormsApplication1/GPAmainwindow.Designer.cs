namespace WindowsFormsApplication1
{
    partial class GPAmainwindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LeadIn = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.oldGPA = new System.Windows.Forms.TextBox();
            this.oldXuefen = new System.Windows.Forms.TextBox();
            this.goalGPA = new System.Windows.Forms.TextBox();
            this.mayGPA = new System.Windows.Forms.TextBox();
            this.preCal = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.TextBox();
            this.courseGPA = new System.Windows.Forms.TextBox();
            this.courseXuefen = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.GPA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.xuefen = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.AddGPA = new System.Windows.Forms.Button();
            this.preJieguo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 244);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GPACalculator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage2.Controls.Add(this.preJieguo);
            this.tabPage2.Controls.Add(this.preCal);
            this.tabPage2.Controls.Add(this.flowLayoutPanel3);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CreditHelper";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.List);
            this.splitContainer1.Panel1.Controls.Add(this.LeadIn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.finishButton);
            this.splitContainer1.Panel2.Controls.Add(this.cleanButton);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel5);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(564, 203);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // LeadIn
            // 
            this.LeadIn.BackColor = System.Drawing.SystemColors.Info;
            this.LeadIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.LeadIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeadIn.Location = new System.Drawing.Point(2, 8);
            this.LeadIn.Margin = new System.Windows.Forms.Padding(0);
            this.LeadIn.Name = "LeadIn";
            this.LeadIn.Size = new System.Drawing.Size(107, 34);
            this.LeadIn.TabIndex = 0;
            this.LeadIn.Text = "Lead-in";
            this.LeadIn.UseVisualStyleBackColor = false;
            this.LeadIn.Click += new System.EventHandler(this.LeadIn_Click);
            // 
            // List
            // 
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.Font = new System.Drawing.Font("华文新魏", 14F);
            this.List.FormattingEnabled = true;
            this.List.HorizontalScrollbar = true;
            this.List.ItemHeight = 29;
            this.List.Location = new System.Drawing.Point(2, 42);
            this.List.Margin = new System.Windows.Forms.Padding(0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(107, 145);
            this.List.TabIndex = 1;
            this.List.Visible = false;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(564, 76);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "existing credit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(139, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "total credit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(275, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "target GPA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(411, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "credit needed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.oldGPA);
            this.flowLayoutPanel3.Controls.Add(this.oldXuefen);
            this.flowLayoutPanel3.Controls.Add(this.goalGPA);
            this.flowLayoutPanel3.Controls.Add(this.mayGPA);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 79);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(564, 72);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // oldGPA
            // 
            this.oldGPA.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldGPA.Location = new System.Drawing.Point(3, 3);
            this.oldGPA.Name = "oldGPA";
            this.oldGPA.Size = new System.Drawing.Size(130, 39);
            this.oldGPA.TabIndex = 0;
            // 
            // oldXuefen
            // 
            this.oldXuefen.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldXuefen.Location = new System.Drawing.Point(139, 3);
            this.oldXuefen.Name = "oldXuefen";
            this.oldXuefen.Size = new System.Drawing.Size(130, 39);
            this.oldXuefen.TabIndex = 1;
            // 
            // goalGPA
            // 
            this.goalGPA.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goalGPA.Location = new System.Drawing.Point(275, 3);
            this.goalGPA.Name = "goalGPA";
            this.goalGPA.Size = new System.Drawing.Size(130, 39);
            this.goalGPA.TabIndex = 2;
            // 
            // mayGPA
            // 
            this.mayGPA.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mayGPA.Location = new System.Drawing.Point(411, 3);
            this.mayGPA.Name = "mayGPA";
            this.mayGPA.Size = new System.Drawing.Size(130, 39);
            this.mayGPA.TabIndex = 3;
            // 
            // preCal
            // 
            this.preCal.BackColor = System.Drawing.SystemColors.Info;
            this.preCal.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.preCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preCal.Location = new System.Drawing.Point(152, 156);
            this.preCal.Name = "preCal";
            this.preCal.Size = new System.Drawing.Size(120, 45);
            this.preCal.TabIndex = 2;
            this.preCal.Text = "calculate";
            this.preCal.UseVisualStyleBackColor = false;
            this.preCal.Click += new System.EventHandler(this.preCal_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(447, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.courseName);
            this.flowLayoutPanel4.Controls.Add(this.courseGPA);
            this.flowLayoutPanel4.Controls.Add(this.courseXuefen);
            this.flowLayoutPanel4.Controls.Add(this.AddGPA);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(447, 51);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label);
            this.flowLayoutPanel5.Controls.Add(this.GPA);
            this.flowLayoutPanel5.Controls.Add(this.label10);
            this.flowLayoutPanel5.Controls.Add(this.xuefen);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(447, 51);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "subject";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(114, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "singleGPA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(225, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 50);
            this.label7.TabIndex = 3;
            this.label7.Text = "credit";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("华文新魏", 17F);
            this.courseName.Location = new System.Drawing.Point(3, 3);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(105, 43);
            this.courseName.TabIndex = 1;
            // 
            // courseGPA
            // 
            this.courseGPA.Font = new System.Drawing.Font("华文新魏", 17F);
            this.courseGPA.Location = new System.Drawing.Point(114, 3);
            this.courseGPA.Name = "courseGPA";
            this.courseGPA.Size = new System.Drawing.Size(105, 43);
            this.courseGPA.TabIndex = 2;
            // 
            // courseXuefen
            // 
            this.courseXuefen.Font = new System.Drawing.Font("华文新魏", 17F);
            this.courseXuefen.Location = new System.Drawing.Point(225, 3);
            this.courseXuefen.Name = "courseXuefen";
            this.courseXuefen.Size = new System.Drawing.Size(105, 43);
            this.courseXuefen.TabIndex = 3;
            // 
            // label
            // 
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 45);
            this.label.TabIndex = 2;
            this.label.Text = "GPA";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPA
            // 
            this.GPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPA.Location = new System.Drawing.Point(114, 0);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(105, 45);
            this.GPA.TabIndex = 3;
            this.GPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(225, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 45);
            this.label10.TabIndex = 4;
            this.label10.Text = "totalcredit";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xuefen
            // 
            this.xuefen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xuefen.Location = new System.Drawing.Point(336, 0);
            this.xuefen.Name = "xuefen";
            this.xuefen.Size = new System.Drawing.Size(105, 45);
            this.xuefen.TabIndex = 5;
            this.xuefen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.SystemColors.Info;
            this.cleanButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton.Location = new System.Drawing.Point(114, 156);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(100, 42);
            this.cleanButton.TabIndex = 3;
            this.cleanButton.Text = "clear";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.SystemColors.Info;
            this.finishButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishButton.Location = new System.Drawing.Point(229, 156);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(100, 42);
            this.finishButton.TabIndex = 4;
            this.finishButton.Text = "finish";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.Finish_Click);
            // 
            // AddGPA
            // 
            this.AddGPA.BackColor = System.Drawing.SystemColors.Info;
            this.AddGPA.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.AddGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGPA.Location = new System.Drawing.Point(336, 3);
            this.AddGPA.Name = "AddGPA";
            this.AddGPA.Size = new System.Drawing.Size(100, 42);
            this.AddGPA.TabIndex = 4;
            this.AddGPA.Text = "add";
            this.AddGPA.UseVisualStyleBackColor = false;
            this.AddGPA.Click += new System.EventHandler(this.Add_Click);
            // 
            // preJieguo
            // 
            this.preJieguo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preJieguo.Font = new System.Drawing.Font("华文新魏", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.preJieguo.Location = new System.Drawing.Point(282, 156);
            this.preJieguo.Name = "preJieguo";
            this.preJieguo.Size = new System.Drawing.Size(280, 45);
            this.preJieguo.TabIndex = 3;
            this.preJieguo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GPAmainwindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(578, 244);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Name = "GPAmainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPAmainwindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GPAmainwindow_Closed);
            this.Load += new System.EventHandler(this.GPAmainwindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button LeadIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button preCal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox oldGPA;
        private System.Windows.Forms.TextBox oldXuefen;
        private System.Windows.Forms.TextBox goalGPA;
        private System.Windows.Forms.TextBox mayGPA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label GPA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label xuefen;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.TextBox courseGPA;
        private System.Windows.Forms.TextBox courseXuefen;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button AddGPA;
        private System.Windows.Forms.Label preJieguo;
    }
}