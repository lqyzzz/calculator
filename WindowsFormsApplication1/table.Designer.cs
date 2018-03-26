namespace WindowsFormsApplication1
{
    partial class table
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
            this.variableinput = new System.Windows.Forms.TextBox();
            this.variablex = new System.Windows.Forms.Button();
            this.initial = new System.Windows.Forms.Button();
            this.step = new System.Windows.Forms.Button();
            this.initialvalue = new System.Windows.Forms.TextBox();
            this.stepvalue = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.times = new System.Windows.Forms.Button();
            this.timesvalue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // variableinput
            // 
            this.variableinput.BackColor = System.Drawing.SystemColors.InfoText;
            this.variableinput.Dock = System.Windows.Forms.DockStyle.Top;
            this.variableinput.Font = new System.Drawing.Font("华文新魏", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.variableinput.ForeColor = System.Drawing.SystemColors.Window;
            this.variableinput.Location = new System.Drawing.Point(0, 0);
            this.variableinput.Name = "variableinput";
            this.variableinput.Size = new System.Drawing.Size(578, 49);
            this.variableinput.TabIndex = 0;
            // 
            // variablex
            // 
            this.variablex.BackColor = System.Drawing.SystemColors.Info;
            this.variablex.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.variablex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variablex.Font = new System.Drawing.Font("华文新魏", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.variablex.Location = new System.Drawing.Point(77, 84);
            this.variablex.Name = "variablex";
            this.variablex.Size = new System.Drawing.Size(100, 42);
            this.variablex.TabIndex = 5;
            this.variablex.Text = "X";
            this.variablex.UseVisualStyleBackColor = false;
            this.variablex.Click += new System.EventHandler(this.variablex_Click);
            // 
            // initial
            // 
            this.initial.BackColor = System.Drawing.SystemColors.HighlightText;
            this.initial.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.initial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initial.Font = new System.Drawing.Font("华文新魏", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.initial.Location = new System.Drawing.Point(12, 171);
            this.initial.Name = "initial";
            this.initial.Size = new System.Drawing.Size(100, 43);
            this.initial.TabIndex = 6;
            this.initial.Text = "initial";
            this.initial.UseVisualStyleBackColor = false;
            // 
            // step
            // 
            this.step.BackColor = System.Drawing.SystemColors.HighlightText;
            this.step.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step.Font = new System.Drawing.Font("华文新魏", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.step.Location = new System.Drawing.Point(137, 171);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(100, 43);
            this.step.TabIndex = 7;
            this.step.Text = "step";
            this.step.UseVisualStyleBackColor = false;
            // 
            // initialvalue
            // 
            this.initialvalue.BackColor = System.Drawing.SystemColors.Window;
            this.initialvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialvalue.Location = new System.Drawing.Point(12, 276);
            this.initialvalue.Name = "initialvalue";
            this.initialvalue.Size = new System.Drawing.Size(100, 28);
            this.initialvalue.TabIndex = 1;
            // 
            // stepvalue
            // 
            this.stepvalue.BackColor = System.Drawing.SystemColors.Window;
            this.stepvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepvalue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.stepvalue.Location = new System.Drawing.Point(137, 276);
            this.stepvalue.Name = "stepvalue";
            this.stepvalue.Size = new System.Drawing.Size(100, 28);
            this.stepvalue.TabIndex = 2;
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.Info;
            this.equal.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("华文新魏", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equal.Location = new System.Drawing.Point(213, 84);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(100, 42);
            this.equal.TabIndex = 4;
            this.equal.Text = "equal";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("华文新魏", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(378, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(200, 288);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "result";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Font = new System.Drawing.Font("华文新魏", 14F);
            this.result.Location = new System.Drawing.Point(3, 22);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(194, 263);
            this.result.TabIndex = 0;
            this.result.Text = "";
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.SystemColors.HighlightText;
            this.times.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.times.Font = new System.Drawing.Font("华文新魏", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.times.Location = new System.Drawing.Point(272, 171);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(100, 43);
            this.times.TabIndex = 8;
            this.times.Text = "times";
            this.times.UseVisualStyleBackColor = false;
            // 
            // timesvalue
            // 
            this.timesvalue.BackColor = System.Drawing.SystemColors.Window;
            this.timesvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timesvalue.Location = new System.Drawing.Point(267, 276);
            this.timesvalue.Name = "timesvalue";
            this.timesvalue.Size = new System.Drawing.Size(100, 28);
            this.timesvalue.TabIndex = 3;
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(578, 337);
            this.Controls.Add(this.timesvalue);
            this.Controls.Add(this.times);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.stepvalue);
            this.Controls.Add(this.initialvalue);
            this.Controls.Add(this.step);
            this.Controls.Add(this.initial);
            this.Controls.Add(this.variablex);
            this.Controls.Add(this.variableinput);
            this.Name = "table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.table_Close);
            this.Load += new System.EventHandler(this.table_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox variableinput;
        private System.Windows.Forms.Button variablex;
        private System.Windows.Forms.Button initial;
        private System.Windows.Forms.Button step;
        private System.Windows.Forms.TextBox initialvalue;
        private System.Windows.Forms.TextBox stepvalue;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.TextBox timesvalue;
        private System.Windows.Forms.RichTextBox result;
    }
}