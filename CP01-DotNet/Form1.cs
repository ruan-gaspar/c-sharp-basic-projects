using System.Linq.Expressions;

namespace CP01_DotNet;

public partial class Form1 : Form
{
    private Operation operationSelected { get; set; }
    private float Result { get; set; }
    private float Value { get; set; }
    private enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Exponent,
        SquareRoot
    }
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn0_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "0";
    }

    private void btn1_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "1";
    }

    private void btn2_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "2";
    }

    private void btn3_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "3";
    }

    private void btn4_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "4";
    }

    private void btn5_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "5";
    }

    private void btn6_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "6";
    }

    private void btn7_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "7";
    }

    private void btn8_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "8";
    }

    private void btn9_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "9";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDisplay.Text = "";
        lblOperation.Text = "";
    }

    private void btnExponent_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(txtDisplay.Text, out float number))
        {
            return;
        }
        operationSelected = Operation.Exponent;
        Value = Convert.ToSingle(txtDisplay.Text);
        txtDisplay.Text = "";
        lblOperation.Text = "x²";
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(txtDisplay.Text, out float number))
        {
            return;
        }
        operationSelected = Operation.Divide;
        Value = Convert.ToSingle(txtDisplay.Text);
        txtDisplay.Text = "";
        lblOperation.Text = "/";
    }

    private void btnMultiply_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(txtDisplay.Text, out float number))
        {
            return;
        }
        operationSelected = Operation.Multiply;
        Value = Convert.ToSingle(txtDisplay.Text);
        txtDisplay.Text = "";
        lblOperation.Text = "x";
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(txtDisplay.Text, out float number))
        {
            return;
        }
        operationSelected = Operation.Subtract;
        Value = Convert.ToSingle(txtDisplay.Text);
        txtDisplay.Text = "";
        lblOperation.Text = "-";
    }

    private void btnSquareRoot_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(txtDisplay.Text, out float number))
        {
            return;
        }
        operationSelected = Operation.SquareRoot;
        Value = Convert.ToSingle(txtDisplay.Text);
        txtDisplay.Text = "";
        lblOperation.Text = "√";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(txtDisplay.Text, out float number))
        {
            return;
        }
        operationSelected = Operation.Add;
        Value = Convert.ToSingle(txtDisplay.Text);
        txtDisplay.Text = "";
        lblOperation.Text = "+";
    }

    private void btnDecimalPoint_Click(object sender, EventArgs e)
    {
        if (!txtDisplay.Text.Contains('.'))
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
                txtDisplay.Text += "0.";
            else
                txtDisplay.Text += ".";
        }
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
        switch (operationSelected)
        {
            case Operation.Add:
                Result = Value + Convert.ToSingle(txtDisplay.Text);
                break;
            case Operation.Subtract:
                Result = Value - Convert.ToSingle(txtDisplay.Text);
                break;
            case Operation.Multiply:
                Result = Value * Convert.ToSingle(txtDisplay.Text);
                break;
            case Operation.Divide:
                Result = Value / Convert.ToSingle(txtDisplay.Text);
                break;
            case Operation.Exponent:
                Result = MathF.Pow(Value, Convert.ToSingle(txtDisplay.Text));
                break;
            case Operation.SquareRoot:
                Result = MathF.Sqrt(Convert.ToSingle(txtDisplay.Text));
                break;
        }
        txtDisplay.Text = Result.ToString();
        lblOperation.Text = "=";
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
