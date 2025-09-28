    using System.Linq.Expressions;

    namespace CP01_DotNet;

    public partial class Form1 : Form
    {
        private Operation operationSelected { get; set; } = Operation.None;
        private double Result { get; set; }
        private double Value { get; set; }
        private enum Operation
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Exponent,
            SquareRoot
        }
        private bool waitForNewNumber = false;

        private void setOperation(Operation op, string displaySymbol)
        { 
            if (!double.TryParse(txtDisplay.Text, out double number))
        
                return;
            if (waitForNewNumber)
                return;
            operationSelected = op;
            Value = number;
            txtDisplay.Text = "";
            lblOperation.Text = displaySymbol;  
            waitForNewNumber = true;
        }
        private void AppendDigit(string digit)
        {
            if(waitForNewNumber)
            {
                txtDisplay.Text = "";
                waitForNewNumber = false;
            }
            txtDisplay.Text += digit;
        }
        private void btn0_Click(object sender, EventArgs e) => AppendDigit("0");
        private void btn1_Click(object sender, EventArgs e) => AppendDigit("1");
        private void btn2_Click(object sender, EventArgs e) => AppendDigit("2");
        private void btn3_Click(object sender, EventArgs e) => AppendDigit("3");
        private void btn4_Click(object sender, EventArgs e) => AppendDigit("4");
        private void btn5_Click(object sender, EventArgs e) => AppendDigit("5");
        private void btn6_Click(object sender, EventArgs e) => AppendDigit("6");
        private void btn7_Click(object sender, EventArgs e) => AppendDigit("7");
        private void btn8_Click(object sender, EventArgs e) => AppendDigit("8");
        private void btn9_Click(object sender, EventArgs e) => AppendDigit("9");
        private void btnAdd_Click(object sender, EventArgs e) => setOperation(Operation.Add, "+");
        private void btnSubtract_Click(object sender, EventArgs e) => setOperation(Operation.Subtract, "-");
        private void btnMultiply_Click(object sender, EventArgs e) => setOperation(Operation.Multiply, "x");
        private void btnDivide_Click(object sender, EventArgs e) => setOperation(Operation.Divide, "/");
        private void btnExponent_Click(object sender, EventArgs e) => setOperation(Operation.Exponent, "x²");
        private void btnSquareRoot_Click(object sender, EventArgs e) => setOperation(Operation.SquareRoot, "√");

    public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            lblOperation.Text = "";
            Value = 0;
            Result = 0;
            operationSelected = 0;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e) // Decimal point alterado para comma no formato BR
        {
            if (waitForNewNumber)
            {
                txtDisplay.Text = "0,";
                waitForNewNumber = false;
                return;
            }
            if (!txtDisplay.Text.Contains(','))
            {
                if (String.IsNullOrEmpty(txtDisplay.Text))
                    txtDisplay.Text += "0,";
                else
                    txtDisplay.Text += ",";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out double currentNumber))
                return;

            switch (operationSelected)
            {
                case Operation.Add:
                    Result = Value + currentNumber;
                    break;
                case Operation.Subtract:
                    Result = Value - currentNumber;
                    break;
                case Operation.Multiply:
                    Result = Value * currentNumber;
                    break;
                case Operation.Divide:
                    Result = Value / currentNumber;
                    break;
                case Operation.Exponent:
                    Result = Math.Pow(Value, currentNumber);
                    break;
                case Operation.SquareRoot:
                    Result = Math.Sqrt(currentNumber);
                    break;
            }
            txtDisplay.Text = Result.ToString();
            lblOperation.Text = "=";
            operationSelected = Operation.None;
            waitForNewNumber = false;
            Value = Result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

