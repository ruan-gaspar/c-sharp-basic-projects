namespace CP01_DotNet;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtDisplay = new TextBox();
        lblOperation = new Label();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btnClear = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btn7 = new Button();
        btn9 = new Button();
        btn8 = new Button();
        btnDivide = new Button();
        btnMultiply = new Button();
        btnSubtract = new Button();
        btnAdd = new Button();
        btn0 = new Button();
        btnDecimalPoint = new Button();
        btnSquareRoot = new Button();
        btnExponent = new Button();
        btnEquals = new Button();
        SuspendLayout();
        // 
        // txtDisplay
        // 
        txtDisplay.BackColor = SystemColors.MenuHighlight;
        txtDisplay.ForeColor = Color.Yellow;
        txtDisplay.Location = new Point(33, 12);
        txtDisplay.Name = "txtDisplay";
        txtDisplay.ReadOnly = true;
        txtDisplay.Size = new Size(214, 35);
        txtDisplay.TabIndex = 0;
        txtDisplay.TextAlign = HorizontalAlignment.Right;
        txtDisplay.TextChanged += textBox1_TextChanged;
        // 
        // lblOperation
        // 
        lblOperation.AutoSize = true;
        lblOperation.BackColor = SystemColors.Highlight;
        lblOperation.ForeColor = Color.Yellow;
        lblOperation.Location = new Point(33, 15);
        lblOperation.Name = "lblOperation";
        lblOperation.Size = new Size(0, 30);
        lblOperation.TabIndex = 1;
        // 
        // btn1
        // 
        btn1.BackColor = SystemColors.ActiveCaptionText;
        btn1.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn1.ForeColor = Color.Yellow;
        btn1.Location = new Point(33, 370);
        btn1.Name = "btn1";
        btn1.Size = new Size(49, 70);
        btn1.TabIndex = 2;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = false;
        btn1.Click += btn1_Click;
        // 
        // btn2
        // 
        btn2.BackColor = SystemColors.ActiveCaptionText;
        btn2.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn2.ForeColor = Color.Yellow;
        btn2.Location = new Point(88, 370);
        btn2.Name = "btn2";
        btn2.Size = new Size(49, 70);
        btn2.TabIndex = 3;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = false;
        btn2.Click += btn2_Click;
        // 
        // btn3
        // 
        btn3.BackColor = SystemColors.ActiveCaptionText;
        btn3.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn3.ForeColor = Color.Yellow;
        btn3.Location = new Point(143, 370);
        btn3.Name = "btn3";
        btn3.Size = new Size(49, 70);
        btn3.TabIndex = 4;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = false;
        btn3.Click += btn3_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = SystemColors.ActiveCaptionText;
        btnClear.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnClear.ForeColor = Color.Yellow;
        btnClear.Location = new Point(143, 66);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(104, 70);
        btnClear.TabIndex = 5;
        btnClear.Text = "C";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // btn4
        // 
        btn4.BackColor = SystemColors.ActiveCaptionText;
        btn4.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn4.ForeColor = Color.Yellow;
        btn4.Location = new Point(33, 294);
        btn4.Name = "btn4";
        btn4.Size = new Size(49, 70);
        btn4.TabIndex = 6;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = false;
        btn4.Click += btn4_Click;
        // 
        // btn5
        // 
        btn5.BackColor = SystemColors.ActiveCaptionText;
        btn5.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn5.ForeColor = Color.Yellow;
        btn5.Location = new Point(88, 294);
        btn5.Name = "btn5";
        btn5.Size = new Size(49, 70);
        btn5.TabIndex = 7;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = false;
        btn5.Click += btn5_Click;
        // 
        // btn6
        // 
        btn6.BackColor = SystemColors.ActiveCaptionText;
        btn6.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn6.ForeColor = Color.Yellow;
        btn6.Location = new Point(143, 294);
        btn6.Name = "btn6";
        btn6.Size = new Size(49, 70);
        btn6.TabIndex = 8;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = false;
        btn6.Click += btn6_Click;
        // 
        // btn7
        // 
        btn7.BackColor = SystemColors.ActiveCaptionText;
        btn7.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn7.ForeColor = Color.Yellow;
        btn7.Location = new Point(33, 218);
        btn7.Name = "btn7";
        btn7.Size = new Size(49, 70);
        btn7.TabIndex = 9;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = false;
        btn7.Click += btn7_Click;
        // 
        // btn9
        // 
        btn9.BackColor = SystemColors.ActiveCaptionText;
        btn9.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn9.ForeColor = Color.Yellow;
        btn9.Location = new Point(143, 218);
        btn9.Name = "btn9";
        btn9.Size = new Size(49, 70);
        btn9.TabIndex = 10;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = false;
        btn9.Click += btn9_Click;
        // 
        // btn8
        // 
        btn8.BackColor = SystemColors.ActiveCaptionText;
        btn8.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn8.ForeColor = Color.Yellow;
        btn8.Location = new Point(88, 218);
        btn8.Name = "btn8";
        btn8.Size = new Size(49, 70);
        btn8.TabIndex = 11;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = false;
        btn8.Click += btn8_Click;
        // 
        // btnDivide
        // 
        btnDivide.BackColor = SystemColors.ActiveCaptionText;
        btnDivide.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDivide.ForeColor = Color.Yellow;
        btnDivide.Location = new Point(33, 142);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new Size(49, 70);
        btnDivide.TabIndex = 12;
        btnDivide.Text = "/";
        btnDivide.UseVisualStyleBackColor = false;
        btnDivide.Click += btnDivide_Click;
        // 
        // btnMultiply
        // 
        btnMultiply.BackColor = SystemColors.ActiveCaptionText;
        btnMultiply.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnMultiply.ForeColor = Color.Yellow;
        btnMultiply.Location = new Point(88, 142);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new Size(49, 70);
        btnMultiply.TabIndex = 13;
        btnMultiply.Text = "*";
        btnMultiply.UseVisualStyleBackColor = false;
        btnMultiply.Click += btnMultiply_Click;
        // 
        // btnSubtract
        // 
        btnSubtract.BackColor = SystemColors.ActiveCaptionText;
        btnSubtract.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSubtract.ForeColor = Color.Yellow;
        btnSubtract.Location = new Point(143, 142);
        btnSubtract.Name = "btnSubtract";
        btnSubtract.Size = new Size(49, 70);
        btnSubtract.TabIndex = 14;
        btnSubtract.Text = "-";
        btnSubtract.UseVisualStyleBackColor = false;
        btnSubtract.Click += btnSubtract_Click;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = SystemColors.ActiveCaptionText;
        btnAdd.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAdd.ForeColor = Color.Yellow;
        btnAdd.Location = new Point(198, 218);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(49, 146);
        btnAdd.TabIndex = 15;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btn0
        // 
        btn0.BackColor = SystemColors.ActiveCaptionText;
        btn0.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn0.ForeColor = Color.Yellow;
        btn0.Location = new Point(33, 446);
        btn0.Name = "btn0";
        btn0.Size = new Size(104, 70);
        btn0.TabIndex = 17;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = false;
        btn0.Click += btn0_Click;
        // 
        // btnDecimalPoint
        // 
        btnDecimalPoint.BackColor = SystemColors.ActiveCaptionText;
        btnDecimalPoint.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDecimalPoint.ForeColor = Color.Yellow;
        btnDecimalPoint.Location = new Point(143, 446);
        btnDecimalPoint.Name = "btnDecimalPoint";
        btnDecimalPoint.Size = new Size(49, 70);
        btnDecimalPoint.TabIndex = 18;
        btnDecimalPoint.Text = ",";
        btnDecimalPoint.UseVisualStyleBackColor = false;
        btnDecimalPoint.Click += btnDecimalPoint_Click;
        // 
        // btnSquareRoot
        // 
        btnSquareRoot.BackColor = SystemColors.ActiveCaptionText;
        btnSquareRoot.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSquareRoot.ForeColor = Color.Yellow;
        btnSquareRoot.Location = new Point(198, 142);
        btnSquareRoot.Name = "btnSquareRoot";
        btnSquareRoot.Size = new Size(49, 70);
        btnSquareRoot.TabIndex = 20;
        btnSquareRoot.Text = "√";
        btnSquareRoot.UseVisualStyleBackColor = false;
        btnSquareRoot.Click += btnSquareRoot_Click;
        // 
        // btnExponent
        // 
        btnExponent.BackColor = SystemColors.ActiveCaptionText;
        btnExponent.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnExponent.ForeColor = Color.Yellow;
        btnExponent.Location = new Point(33, 66);
        btnExponent.Name = "btnExponent";
        btnExponent.Size = new Size(104, 70);
        btnExponent.TabIndex = 21;
        btnExponent.Text = "x²";
        btnExponent.UseVisualStyleBackColor = false;
        btnExponent.Click += btnExponent_Click;
        // 
        // btnEquals
        // 
        btnEquals.BackColor = SystemColors.ActiveCaptionText;
        btnEquals.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEquals.ForeColor = Color.Yellow;
        btnEquals.Location = new Point(198, 370);
        btnEquals.Name = "btnEquals";
        btnEquals.Size = new Size(49, 146);
        btnEquals.TabIndex = 22;
        btnEquals.Text = "=";
        btnEquals.UseVisualStyleBackColor = false;
        btnEquals.Click += btnEquals_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkSlateGray;
        ClientSize = new Size(284, 539);
        Controls.Add(btnEquals);
        Controls.Add(btnExponent);
        Controls.Add(btnSquareRoot);
        Controls.Add(btnDecimalPoint);
        Controls.Add(btn0);
        Controls.Add(btnAdd);
        Controls.Add(btnSubtract);
        Controls.Add(btnMultiply);
        Controls.Add(btnDivide);
        Controls.Add(btn8);
        Controls.Add(btn9);
        Controls.Add(btn7);
        Controls.Add(btn6);
        Controls.Add(btn5);
        Controls.Add(btn4);
        Controls.Add(btnClear);
        Controls.Add(btn3);
        Controls.Add(btn2);
        Controls.Add(btn1);
        Controls.Add(lblOperation);
        Controls.Add(txtDisplay);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculadora";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtDisplay;
    private Label lblOperation;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnClear;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btn7;
    private Button btn9;
    private Button btn8;
    private Button btnDivide;
    private Button btnMultiply;
    private Button btnSubtract;
    private Button btnAdd;
    private Button btn0;
    private Button btnDecimalPoint;
    private Button btnSquareRoot;
    private Button btnExponent;
    private Button btnEquals;
}
