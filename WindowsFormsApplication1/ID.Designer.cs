namespace WindowsFormsApplication1
{
    partial class ID
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDstring = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please input your id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDstring
            // 
            this.IDstring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDstring.Dock = System.Windows.Forms.DockStyle.Top;
            this.IDstring.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDstring.Location = new System.Drawing.Point(0, 93);
            this.IDstring.Name = "IDstring";
            this.IDstring.Size = new System.Drawing.Size(278, 46);
            this.IDstring.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.Info;
            this.Save.Dock = System.Windows.Forms.DockStyle.Top;
            this.Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Save.Location = new System.Drawing.Point(0, 139);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(278, 72);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ID
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(278, 214);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.IDstring);
            this.Controls.Add(this.label1);
            this.Name = "ID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ID";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ID_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDstring;
        private System.Windows.Forms.Button Save;
    }
}