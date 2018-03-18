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
            this.gPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.input = new System.Windows.Forms.TextBox();
            this.formula = new System.Windows.Forms.GroupBox();
            this.transform = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.extracty = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.extract2 = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.deg = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.lbracket = new System.Windows.Forms.Button();
            this.rbracket = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.GroupBox();
            this.plus1 = new System.Windows.Forms.Button();
            this.substract1 = new System.Windows.Forms.Button();
            this.multiply1 = new System.Windows.Forms.Button();
            this.divide1 = new System.Windows.Forms.Button();
            this.equal1 = new System.Windows.Forms.Button();
            this.operator1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menu.SuspendLayout();
            this.formula.SuspendLayout();
            this.number.SuspendLayout();
            this.operator1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.output);
            this.splitContainer1.Panel1.Controls.Add(this.menu);
            this.splitContainer1.Panel1.Controls.Add(this.input);
            // 
            // splitContainer1.Panel2
            // 
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
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.output.Location = new System.Drawing.Point(0, 130);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(718, 51);
            this.output.TabIndex = 3;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constellationToolStripMenuItem,
            this.gPAToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(718, 32);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // constellationToolStripMenuItem
            // 
            this.constellationToolStripMenuItem.Name = "constellationToolStripMenuItem";
            this.constellationToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.constellationToolStripMenuItem.Text = "CONSTELLATION";
            // 
            // gPAToolStripMenuItem
            // 
            this.gPAToolStripMenuItem.Name = "gPAToolStripMenuItem";
            this.gPAToolStripMenuItem.Size = new System.Drawing.Size(59, 28);
            this.gPAToolStripMenuItem.Text = "GPA";
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input.Location = new System.Drawing.Point(0, 50);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(718, 51);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // formula
            // 
            this.formula.Controls.Add(this.transform);
            this.formula.Controls.Add(this.table);
            this.formula.Controls.Add(this.equation);
            this.formula.Controls.Add(this.delete);
            this.formula.Controls.Add(this.extracty);
            this.formula.Controls.Add(this.ln);
            this.formula.Controls.Add(this.extract2);
            this.formula.Controls.Add(this.sin);
            this.formula.Controls.Add(this.cos);
            this.formula.Controls.Add(this.factorial);
            this.formula.Controls.Add(this.deg);
            this.formula.Controls.Add(this.e);
            this.formula.Controls.Add(this.pi);
            this.formula.Controls.Add(this.tan);
            this.formula.Controls.Add(this.reciprocal);
            this.formula.Dock = System.Windows.Forms.DockStyle.Left;
            this.formula.Location = new System.Drawing.Point(0, 0);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(303, 348);
            this.formula.TabIndex = 0;
            this.formula.TabStop = false;
            this.formula.Text = "formula";
            // 
            // transform
            // 
            this.transform.Location = new System.Drawing.Point(202, 24);
            this.transform.Margin = new System.Windows.Forms.Padding(0);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(101, 65);
            this.transform.TabIndex = 16;
            this.transform.Text = "S=D";
            this.transform.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.Location = new System.Drawing.Point(101, 24);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(101, 65);
            this.table.TabIndex = 15;
            this.table.Text = "table";
            this.table.UseVisualStyleBackColor = true;
            // 
            // equation
            // 
            this.equation.Location = new System.Drawing.Point(0, 24);
            this.equation.Margin = new System.Windows.Forms.Padding(0);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(101, 65);
            this.equation.TabIndex = 14;
            this.equation.Text = "equation";
            this.equation.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(101, 89);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 65);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // extracty
            // 
            this.extracty.Location = new System.Drawing.Point(202, 89);
            this.extracty.Margin = new System.Windows.Forms.Padding(0);
            this.extracty.Name = "extracty";
            this.extracty.Size = new System.Drawing.Size(101, 65);
            this.extracty.TabIndex = 12;
            this.extracty.Text = "x^2";
            this.extracty.UseVisualStyleBackColor = true;
            this.extracty.Click += new System.EventHandler(this.extracty_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(101, 154);
            this.ln.Margin = new System.Windows.Forms.Padding(0);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(101, 65);
            this.ln.TabIndex = 11;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // extract2
            // 
            this.extract2.Location = new System.Drawing.Point(0, 89);
            this.extract2.Margin = new System.Windows.Forms.Padding(0);
            this.extract2.Name = "extract2";
            this.extract2.Size = new System.Drawing.Size(101, 65);
            this.extract2.TabIndex = 10;
            this.extract2.Text = "√";
            this.extract2.UseVisualStyleBackColor = true;
            this.extract2.Click += new System.EventHandler(this.extract2_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(0, 219);
            this.sin.Margin = new System.Windows.Forms.Padding(0);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(101, 65);
            this.sin.TabIndex = 9;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(101, 219);
            this.cos.Margin = new System.Windows.Forms.Padding(0);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(101, 65);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(0, 154);
            this.factorial.Margin = new System.Windows.Forms.Padding(0);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(101, 65);
            this.factorial.TabIndex = 7;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // deg
            // 
            this.deg.Location = new System.Drawing.Point(0, 284);
            this.deg.Margin = new System.Windows.Forms.Padding(0);
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(101, 65);
            this.deg.TabIndex = 6;
            this.deg.Text = "Ans";
            this.deg.UseVisualStyleBackColor = true;
            this.deg.Click += new System.EventHandler(this.deg_Click);
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(101, 284);
            this.e.Margin = new System.Windows.Forms.Padding(0);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(101, 65);
            this.e.TabIndex = 5;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.e_Click);
            // 
            // pi
            // 
            this.pi.Location = new System.Drawing.Point(202, 284);
            this.pi.Margin = new System.Windows.Forms.Padding(0);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(101, 65);
            this.pi.TabIndex = 4;
            this.pi.Text = "π";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(202, 219);
            this.tan.Margin = new System.Windows.Forms.Padding(0);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(101, 65);
            this.tan.TabIndex = 3;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.Location = new System.Drawing.Point(202, 154);
            this.reciprocal.Margin = new System.Windows.Forms.Padding(0);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(101, 65);
            this.reciprocal.TabIndex = 2;
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.reciprocal_Click);
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
            // one
            // 
            this.one.Location = new System.Drawing.Point(6, 219);
            this.one.Margin = new System.Windows.Forms.Padding(0);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(101, 65);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(7, 283);
            this.zero.Margin = new System.Windows.Forms.Padding(0);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(201, 65);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(208, 283);
            this.point.Margin = new System.Windows.Forms.Padding(0);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(101, 65);
            this.point.TabIndex = 3;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(107, 154);
            this.five.Margin = new System.Windows.Forms.Padding(0);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(101, 65);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(6, 154);
            this.four.Margin = new System.Windows.Forms.Padding(0);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(101, 65);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(208, 219);
            this.three.Margin = new System.Windows.Forms.Padding(0);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(101, 65);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(107, 219);
            this.two.Margin = new System.Windows.Forms.Padding(0);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(101, 65);
            this.two.TabIndex = 7;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(208, 154);
            this.six.Margin = new System.Windows.Forms.Padding(0);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(101, 65);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(6, 89);
            this.seven.Margin = new System.Windows.Forms.Padding(0);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(101, 65);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(107, 89);
            this.eight.Margin = new System.Windows.Forms.Padding(0);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(101, 65);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(208, 89);
            this.nine.Margin = new System.Windows.Forms.Padding(0);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(101, 65);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(6, 24);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(101, 65);
            this.clear.TabIndex = 12;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // lbracket
            // 
            this.lbracket.Location = new System.Drawing.Point(107, 24);
            this.lbracket.Margin = new System.Windows.Forms.Padding(0);
            this.lbracket.Name = "lbracket";
            this.lbracket.Size = new System.Drawing.Size(101, 65);
            this.lbracket.TabIndex = 13;
            this.lbracket.Text = "(";
            this.lbracket.UseVisualStyleBackColor = true;
            this.lbracket.Click += new System.EventHandler(this.lbracket_Click);
            // 
            // rbracket
            // 
            this.rbracket.Location = new System.Drawing.Point(208, 24);
            this.rbracket.Margin = new System.Windows.Forms.Padding(0);
            this.rbracket.Name = "rbracket";
            this.rbracket.Size = new System.Drawing.Size(101, 65);
            this.rbracket.TabIndex = 14;
            this.rbracket.Text = ")";
            this.rbracket.UseVisualStyleBackColor = true;
            this.rbracket.Click += new System.EventHandler(this.rbracket_Click);
            // 
            // number
            // 
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
            this.number.Location = new System.Drawing.Point(303, 0);
            this.number.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(309, 348);
            this.number.TabIndex = 1;
            this.number.TabStop = false;
            this.number.Text = "number";
            // 
            // plus1
            // 
            this.plus1.Dock = System.Windows.Forms.DockStyle.Top;
            this.plus1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plus1.Location = new System.Drawing.Point(3, 24);
            this.plus1.Margin = new System.Windows.Forms.Padding(0);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(100, 65);
            this.plus1.TabIndex = 15;
            this.plus1.Text = "+";
            this.plus1.UseVisualStyleBackColor = true;
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // substract1
            // 
            this.substract1.Dock = System.Windows.Forms.DockStyle.Top;
            this.substract1.Location = new System.Drawing.Point(3, 89);
            this.substract1.Margin = new System.Windows.Forms.Padding(0);
            this.substract1.Name = "substract1";
            this.substract1.Size = new System.Drawing.Size(100, 65);
            this.substract1.TabIndex = 16;
            this.substract1.Text = "-";
            this.substract1.UseVisualStyleBackColor = true;
            this.substract1.Click += new System.EventHandler(this.substract1_Click);
            // 
            // multiply1
            // 
            this.multiply1.Dock = System.Windows.Forms.DockStyle.Top;
            this.multiply1.Location = new System.Drawing.Point(3, 154);
            this.multiply1.Margin = new System.Windows.Forms.Padding(0);
            this.multiply1.Name = "multiply1";
            this.multiply1.Size = new System.Drawing.Size(100, 65);
            this.multiply1.TabIndex = 17;
            this.multiply1.Text = "×";
            this.multiply1.UseVisualStyleBackColor = true;
            this.multiply1.Click += new System.EventHandler(this.multiply1_Click);
            // 
            // divide1
            // 
            this.divide1.Dock = System.Windows.Forms.DockStyle.Top;
            this.divide1.Location = new System.Drawing.Point(3, 219);
            this.divide1.Margin = new System.Windows.Forms.Padding(0);
            this.divide1.Name = "divide1";
            this.divide1.Size = new System.Drawing.Size(100, 65);
            this.divide1.TabIndex = 18;
            this.divide1.Text = "÷";
            this.divide1.UseVisualStyleBackColor = true;
            this.divide1.Click += new System.EventHandler(this.divide1_Click);
            // 
            // equal1
            // 
            this.equal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.equal1.Location = new System.Drawing.Point(3, 284);
            this.equal1.Margin = new System.Windows.Forms.Padding(0);
            this.equal1.Name = "equal1";
            this.equal1.Size = new System.Drawing.Size(100, 65);
            this.equal1.TabIndex = 19;
            this.equal1.Text = "=";
            this.equal1.UseVisualStyleBackColor = true;
            this.equal1.Click += new System.EventHandler(this.equal1_Click);
            // 
            // operator1
            // 
            this.operator1.Controls.Add(this.equal1);
            this.operator1.Controls.Add(this.divide1);
            this.operator1.Controls.Add(this.multiply1);
            this.operator1.Controls.Add(this.substract1);
            this.operator1.Controls.Add(this.plus1);
            this.operator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.operator1.Location = new System.Drawing.Point(612, 0);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(106, 348);
            this.operator1.TabIndex = 2;
            this.operator1.TabStop = false;
            this.operator1.Text = "operator";
            // 
            // mainwindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(718, 544);
            this.Controls.Add(this.splitContainer1);
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainwindow";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.formula.ResumeLayout(false);
            this.number.ResumeLayout(false);
            this.operator1.ResumeLayout(false);
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
        private System.Windows.Forms.Button extracty;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button extract2;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button deg;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem constellationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPAToolStripMenuItem;
        private System.Windows.Forms.TextBox output;
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
    }

}