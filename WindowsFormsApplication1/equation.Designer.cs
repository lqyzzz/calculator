namespace WindowsFormsApplication1
{
    partial class equation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.result);
            this.splitContainer1.Panel2.Controls.Add(this.num);
            this.splitContainer1.Size = new System.Drawing.Size(478, 244);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.a);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.b);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.c);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 53);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.SystemColors.Window;
            this.a.Font = new System.Drawing.Font("华文新魏", 12F);
            this.a.Location = new System.Drawing.Point(3, 3);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(60, 32);
            this.a.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "x^2+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("华文新魏", 12F);
            this.b.Location = new System.Drawing.Point(170, 3);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(60, 32);
            this.b.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(236, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "x+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("华文新魏", 12F);
            this.c.Location = new System.Drawing.Point(290, 3);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(60, 32);
            this.c.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(356, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "=0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.HighlightText;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.result.Font = new System.Drawing.Font("华文新魏", 14F);
            this.result.Location = new System.Drawing.Point(46, 18);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(126, 50);
            this.result.TabIndex = 0;
            this.result.Text = "calculate";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // num
            // 
            this.num.AutoEllipsis = true;
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(242, 27);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(0, 33);
            this.num.TabIndex = 1;
            // 
            // equation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "equation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "equation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.equation_Closed);
            this.Load += new System.EventHandler(this.equation_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label4;
    }
}