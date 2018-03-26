namespace WindowsFormsApplication1
{
    partial class mainwindow
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
            this.output = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.constellationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.input = new System.Windows.Forms.TextBox();
            this.operator1 = new System.Windows.Forms.GroupBox();
            this.equal1 = new System.Windows.Forms.Button();
            this.divide1 = new System.Windows.Forms.Button();
            this.multiply1 = new System.Windows.Forms.Button();
            this.substract1 = new System.Windows.Forms.Button();
            this.plus1 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.GroupBox();
            this.rbracket = new System.Windows.Forms.Button();
            this.lbracket = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.formula = new System.Windows.Forms.GroupBox();
            this.transform = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.extract2 = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.deg = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.powerofy = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.gPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menu.SuspendLayout();
            this.operator1.SuspendLayout();
            this.number.SuspendLayout();
            this.formula.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.output);
            this.splitContainer1.Panel1.Controls.Add(this.menu);
            this.splitContainer1.Panel1.Controls.Add(this.input);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainer1.Panel2.Controls.Add(this.operator1);
            this.splitContainer1.Panel2.Controls.Add(this.number);
            this.splitContainer1.Panel2.Controls.Add(this.formula);
            this.splitContainer1.Size = new System.Drawing.Size(718, 544);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Cursor = System.Windows.Forms.Cursors.Default;
            this.output.Font = new System.Drawing.Font("宋体", 28F);
            this.output.ForeColor = System.Drawing.SystemColors.Window;
            this.output.Location = new System.Drawing.Point(0, 130);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(718, 64);
            this.output.TabIndex = 3;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Font = new System.Drawing.Font("华文新魏", 10F);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constellationToolStripMenuItem,
            this.gPAToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(718, 29);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // constellationToolStripMenuItem
            // 
            this.constellationToolStripMenuItem.Name = "constellationToolStripMenuItem";
            this.constellationToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.constellationToolStripMenuItem.Text = "CONSTELLATION";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.InfoText;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Font = new System.Drawing.Font("宋体", 28F);
            this.input.ForeColor = System.Drawing.SystemColors.Window;
            this.input.Location = new System.Drawing.Point(0, 50);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(718, 64);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // operator1
            // 
            this.operator1.Controls.Add(this.equal1);
            this.operator1.Controls.Add(this.divide1);
            this.operator1.Controls.Add(this.multiply1);
            this.operator1.Controls.Add(this.substract1);
            this.operator1.Controls.Add(this.plus1);
            this.operator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.operator1.Font = new System.Drawing.Font("华文新魏", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.operator1.Location = new System.Drawing.Point(612, 0);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(106, 348);
            this.operator1.TabIndex = 2;
            this.operator1.TabStop = false;
            this.operator1.Text = "operator";
            // 
            // equal1
            // 
            this.equal1.BackColor = System.Drawing.Color.Orange;
            this.equal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.equal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal1.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equal1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.equal1.Location = new System.Drawing.Point(3, 282);
            this.equal1.Margin = new System.Windows.Forms.Padding(0);
            this.equal1.Name = "equal1";
            this.equal1.Size = new System.Drawing.Size(100, 65);
            this.equal1.TabIndex = 19;
            this.equal1.Text = "=";
            this.equal1.UseVisualStyleBackColor = false;
            this.equal1.Click += new System.EventHandler(this.equal1_Click);
            // 
            // divide1
            // 
            this.divide1.BackColor = System.Drawing.Color.Orange;
            this.divide1.Dock = System.Windows.Forms.DockStyle.Top;
            this.divide1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide1.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divide1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.divide1.Location = new System.Drawing.Point(3, 217);
            this.divide1.Margin = new System.Windows.Forms.Padding(0);
            this.divide1.Name = "divide1";
            this.divide1.Size = new System.Drawing.Size(100, 65);
            this.divide1.TabIndex = 18;
            this.divide1.Text = "÷";
            this.divide1.UseVisualStyleBackColor = false;
            this.divide1.Click += new System.EventHandler(this.divide1_Click);
            // 
            // multiply1
            // 
            this.multiply1.BackColor = System.Drawing.Color.Orange;
            this.multiply1.Dock = System.Windows.Forms.DockStyle.Top;
            this.multiply1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply1.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.multiply1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.multiply1.Location = new System.Drawing.Point(3, 152);
            this.multiply1.Margin = new System.Windows.Forms.Padding(0);
            this.multiply1.Name = "multiply1";
            this.multiply1.Size = new System.Drawing.Size(100, 65);
            this.multiply1.TabIndex = 17;
            this.multiply1.Text = "×";
            this.multiply1.UseVisualStyleBackColor = false;
            this.multiply1.Click += new System.EventHandler(this.multiply1_Click);
            // 
            // substract1
            // 
            this.substract1.BackColor = System.Drawing.Color.Orange;
            this.substract1.Dock = System.Windows.Forms.DockStyle.Top;
            this.substract1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.substract1.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.substract1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.substract1.Location = new System.Drawing.Point(3, 87);
            this.substract1.Margin = new System.Windows.Forms.Padding(0);
            this.substract1.Name = "substract1";
            this.substract1.Size = new System.Drawing.Size(100, 65);
            this.substract1.TabIndex = 16;
            this.substract1.Text = "-";
            this.substract1.UseVisualStyleBackColor = false;
            this.substract1.Click += new System.EventHandler(this.substract1_Click);
            // 
            // plus1
            // 
            this.plus1.BackColor = System.Drawing.Color.Orange;
            this.plus1.Dock = System.Windows.Forms.DockStyle.Top;
            this.plus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus1.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plus1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plus1.Location = new System.Drawing.Point(3, 22);
            this.plus1.Margin = new System.Windows.Forms.Padding(0);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(100, 65);
            this.plus1.TabIndex = 15;
            this.plus1.Text = "+";
            this.plus1.UseVisualStyleBackColor = false;
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.SystemColors.HighlightText;
            this.number.Controls.Add(this.rbracket);
            this.number.Controls.Add(this.lbracket);
            this.number.Controls.Add(this.clear);
            this.number.Controls.Add(this.nine);
            this.number.Controls.Add(this.eight);
            this.number.Controls.Add(this.seven);
            this.number.Controls.Add(this.six);
            this.number.Controls.Add(this.two);
            this.number.Controls.Add(this.three);
            this.number.Controls.Add(this.four);
            this.number.Controls.Add(this.five);
            this.number.Controls.Add(this.point);
            this.number.Controls.Add(this.zero);
            this.number.Controls.Add(this.one);
            this.number.Dock = System.Windows.Forms.DockStyle.Left;
            this.number.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number.Font = new System.Drawing.Font("华文新魏", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.Location = new System.Drawing.Point(303, 0);
            this.number.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(309, 348);
            this.number.TabIndex = 1;
            this.number.TabStop = false;
            this.number.Text = "number";
            // 
            // rbracket
            // 
            this.rbracket.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbracket.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.rbracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbracket.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbracket.Location = new System.Drawing.Point(208, 24);
            this.rbracket.Margin = new System.Windows.Forms.Padding(0);
            this.rbracket.Name = "rbracket";
            this.rbracket.Size = new System.Drawing.Size(101, 65);
            this.rbracket.TabIndex = 14;
            this.rbracket.Text = ")";
            this.rbracket.UseVisualStyleBackColor = false;
            this.rbracket.Click += new System.EventHandler(this.rbracket_Click);
            // 
            // lbracket
            // 
            this.lbracket.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbracket.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.lbracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbracket.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbracket.Location = new System.Drawing.Point(107, 24);
            this.lbracket.Margin = new System.Windows.Forms.Padding(0);
            this.lbracket.Name = "lbracket";
            this.lbracket.Size = new System.Drawing.Size(101, 65);
            this.lbracket.TabIndex = 13;
            this.lbracket.Text = "(";
            this.lbracket.UseVisualStyleBackColor = false;
            this.lbracket.Click += new System.EventHandler(this.lbracket_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear.Location = new System.Drawing.Point(6, 24);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(101, 65);
            this.clear.TabIndex = 12;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nine.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nine.Location = new System.Drawing.Point(208, 89);
            this.nine.Margin = new System.Windows.Forms.Padding(0);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(101, 65);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.eight.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eight.Location = new System.Drawing.Point(107, 89);
            this.eight.Margin = new System.Windows.Forms.Padding(0);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(101, 65);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.seven.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.seven.Location = new System.Drawing.Point(6, 89);
            this.seven.Margin = new System.Windows.Forms.Padding(0);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(101, 65);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.six.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.six.Location = new System.Drawing.Point(208, 154);
            this.six.Margin = new System.Windows.Forms.Padding(0);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(101, 65);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.two.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.two.Location = new System.Drawing.Point(107, 219);
            this.two.Margin = new System.Windows.Forms.Padding(0);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(101, 65);
            this.two.TabIndex = 7;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.three.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.three.Location = new System.Drawing.Point(208, 219);
            this.three.Margin = new System.Windows.Forms.Padding(0);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(101, 65);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.four.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.four.Location = new System.Drawing.Point(6, 154);
            this.four.Margin = new System.Windows.Forms.Padding(0);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(101, 65);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.five.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.five.Location = new System.Drawing.Point(107, 154);
            this.five.Margin = new System.Windows.Forms.Padding(0);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(101, 65);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.point.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.point.Location = new System.Drawing.Point(208, 283);
            this.point.Margin = new System.Windows.Forms.Padding(0);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(101, 65);
            this.point.TabIndex = 3;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.zero.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zero.Location = new System.Drawing.Point(7, 283);
            this.zero.Margin = new System.Windows.Forms.Padding(0);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(201, 65);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.one.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.one.Location = new System.Drawing.Point(6, 219);
            this.one.Margin = new System.Windows.Forms.Padding(0);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(101, 65);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // formula
            // 
            this.formula.Controls.Add(this.transform);
            this.formula.Controls.Add(this.table);
            this.formula.Controls.Add(this.equation);
            this.formula.Controls.Add(this.delete);
            this.formula.Controls.Add(this.square);
            this.formula.Controls.Add(this.ln);
            this.formula.Controls.Add(this.extract2);
            this.formula.Controls.Add(this.sin);
            this.formula.Controls.Add(this.cos);
            this.formula.Controls.Add(this.factorial);
            this.formula.Controls.Add(this.deg);
            this.formula.Controls.Add(this.e);
            this.formula.Controls.Add(this.pi);
            this.formula.Controls.Add(this.tan);
            this.formula.Controls.Add(this.powerofy);
            this.formula.Dock = System.Windows.Forms.DockStyle.Left;
            this.formula.Font = new System.Drawing.Font("华文新魏", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formula.Location = new System.Drawing.Point(0, 0);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(303, 348);
            this.formula.TabIndex = 0;
            this.formula.TabStop = false;
            this.formula.Text = "formula";
            // 
            // transform
            // 
            this.transform.BackColor = System.Drawing.SystemColors.Info;
            this.transform.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transform.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.transform.Location = new System.Drawing.Point(202, 24);
            this.transform.Margin = new System.Windows.Forms.Padding(0);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(101, 65);
            this.transform.TabIndex = 16;
            this.transform.Text = "S=D";
            this.transform.UseVisualStyleBackColor = false;
            this.transform.Click += new System.EventHandler(this.transform_Click);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.SystemColors.Info;
            this.table.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.table.Location = new System.Drawing.Point(101, 24);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(101, 65);
            this.table.TabIndex = 15;
            this.table.Text = "table";
            this.table.UseVisualStyleBackColor = false;
            this.table.Click += new System.EventHandler(this.table_Click);
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.SystemColors.Info;
            this.equation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.equation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equation.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equation.Location = new System.Drawing.Point(0, 24);
            this.equation.Margin = new System.Windows.Forms.Padding(0);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(101, 65);
            this.equation.TabIndex = 14;
            this.equation.Text = "equation";
            this.equation.UseVisualStyleBackColor = false;
            this.equation.Click += new System.EventHandler(this.equation_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Info;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.Location = new System.Drawing.Point(101, 89);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 65);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.Info;
            this.square.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.square.Location = new System.Drawing.Point(202, 89);
            this.square.Margin = new System.Windows.Forms.Padding(0);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(101, 65);
            this.square.TabIndex = 12;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.extracty_Click);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.SystemColors.Info;
            this.ln.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ln.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln.Location = new System.Drawing.Point(101, 154);
            this.ln.Margin = new System.Windows.Forms.Padding(0);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(101, 65);
            this.ln.TabIndex = 11;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // extract2
            // 
            this.extract2.BackColor = System.Drawing.SystemColors.Info;
            this.extract2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.extract2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extract2.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.extract2.Location = new System.Drawing.Point(0, 89);
            this.extract2.Margin = new System.Windows.Forms.Padding(0);
            this.extract2.Name = "extract2";
            this.extract2.Size = new System.Drawing.Size(101, 65);
            this.extract2.TabIndex = 10;
            this.extract2.Text = "√";
            this.extract2.UseVisualStyleBackColor = false;
            this.extract2.Click += new System.EventHandler(this.extract2_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.SystemColors.Info;
            this.sin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sin.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sin.Location = new System.Drawing.Point(0, 219);
            this.sin.Margin = new System.Windows.Forms.Padding(0);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(101, 65);
            this.sin.TabIndex = 9;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.SystemColors.Info;
            this.cos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cos.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cos.Location = new System.Drawing.Point(101, 219);
            this.cos.Margin = new System.Windows.Forms.Padding(0);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(101, 65);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.SystemColors.Info;
            this.factorial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorial.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.factorial.Location = new System.Drawing.Point(0, 154);
            this.factorial.Margin = new System.Windows.Forms.Padding(0);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(101, 65);
            this.factorial.TabIndex = 7;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // deg
            // 
            this.deg.BackColor = System.Drawing.SystemColors.Info;
            this.deg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deg.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deg.Location = new System.Drawing.Point(0, 284);
            this.deg.Margin = new System.Windows.Forms.Padding(0);
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(101, 65);
            this.deg.TabIndex = 6;
            this.deg.Text = "Ans";
            this.deg.UseVisualStyleBackColor = false;
            this.deg.Click += new System.EventHandler(this.deg_Click);
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.SystemColors.Info;
            this.e.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.e.Location = new System.Drawing.Point(101, 284);
            this.e.Margin = new System.Windows.Forms.Padding(0);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(101, 65);
            this.e.TabIndex = 5;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = false;
            this.e.Click += new System.EventHandler(this.e_Click);
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.SystemColors.Info;
            this.pi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pi.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pi.Location = new System.Drawing.Point(202, 284);
            this.pi.Margin = new System.Windows.Forms.Padding(0);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(101, 65);
            this.pi.TabIndex = 4;
            this.pi.Text = "π";
            this.pi.UseVisualStyleBackColor = false;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // tan
            // 
            this.tan.BackColor = System.Drawing.SystemColors.Info;
            this.tan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tan.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tan.Location = new System.Drawing.Point(202, 219);
            this.tan.Margin = new System.Windows.Forms.Padding(0);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(101, 65);
            this.tan.TabIndex = 3;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = false;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // powerofy
            // 
            this.powerofy.BackColor = System.Drawing.SystemColors.Info;
            this.powerofy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.powerofy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerofy.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.powerofy.Location = new System.Drawing.Point(202, 154);
            this.powerofy.Margin = new System.Windows.Forms.Padding(0);
            this.powerofy.Name = "powerofy";
            this.powerofy.Size = new System.Drawing.Size(101, 65);
            this.powerofy.TabIndex = 2;
            this.powerofy.Text = "x^y";
            this.powerofy.UseVisualStyleBackColor = false;
            this.powerofy.Click += new System.EventHandler(this.reciprocal_Click);
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Top;
            this.plus.Location = new System.Drawing.Point(3, 24);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(101, 65);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // subtract
            // 
            this.subtract.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtract.Location = new System.Drawing.Point(3, 89);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(101, 65);
            this.subtract.TabIndex = 1;
            this.subtract.Text = "_";
            this.subtract.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Dock = System.Windows.Forms.DockStyle.Top;
            this.multiply.Location = new System.Drawing.Point(3, 154);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(101, 65);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Dock = System.Windows.Forms.DockStyle.Top;
            this.divide.Location = new System.Drawing.Point(3, 219);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(101, 65);
            this.divide.TabIndex = 3;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.equal.Dock = System.Windows.Forms.DockStyle.Top;
            this.equal.Location = new System.Drawing.Point(3, 284);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(101, 65);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // gPAToolStripMenuItem
            // 
            this.gPAToolStripMenuItem.Name = "gPAToolStripMenuItem";
            this.gPAToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.gPAToolStripMenuItem.Text = "GPA";
            this.gPAToolStripMenuItem.Click += new System.EventHandler(this.gPAToolStripMenuItem_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(718, 544);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.operator1.ResumeLayout(false);
            this.number.ResumeLayout(false);
            this.formula.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox @operator;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.GroupBox formula;
        private System.Windows.Forms.Button transform;
        private System.Windows.Forms.Button table;
        private System.Windows.Forms.Button equation;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button extract2;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button deg;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button powerofy;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem constellationToolStripMenuItem;
        private System.Windows.Forms.GroupBox operator1;
        private System.Windows.Forms.Button equal1;
        private System.Windows.Forms.Button divide1;
        private System.Windows.Forms.Button multiply1;
        private System.Windows.Forms.Button substract1;
        private System.Windows.Forms.Button plus1;
        private System.Windows.Forms.GroupBox number;
        private System.Windows.Forms.Button rbracket;
        private System.Windows.Forms.Button lbracket;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        protected System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.ToolStripMenuItem gPAToolStripMenuItem;
    }

}