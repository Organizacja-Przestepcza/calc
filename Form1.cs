using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Calc : Form
    {

        public Calc()
        {
            InitializeComponent();
        }

        private long number1, number2, memory;
        private string operation;
        /// <summary>
        /// Handles key presses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            switch (c)
            {
                case '0': Btn0.PerformClick(); break;
                case '1': Btn1.PerformClick(); break;
                case '2': Btn2.PerformClick(); break;
                case '3': Btn3.PerformClick(); break;
                case '4': Btn4.PerformClick(); break;
                case '5': Btn5.PerformClick(); break;
                case '6': Btn6.PerformClick(); break;
                case '7': Btn7.PerformClick(); break;
                case '8': Btn8.PerformClick(); break;
                case '9': Btn9.PerformClick(); break;
                case '+': BtnAdd.PerformClick(); break;
                case '-': BtnSubtract.PerformClick(); break;
                case '*': BtnMultiply.PerformClick(); break;
                case '/': BtnDivide.PerformClick(); break;
                case '%': BtnModulo.PerformClick(); break;
                case '=': BtnEquals.PerformClick(); break;
                case (char)8: BtnDelete.PerformClick(); break;

            }
        }

        /// <summary>
        /// Focuses on BtnEquals
        /// </summary>
        private void InputFocus()
        {
            BtnEquals.Focus();
        }

        private void DeleteInputChar()
        {
            string tmp = DisplayBox.Text;
            if (tmp.Length == 0)
            {
                return;
            }
            if (tmp.Contains("-") && tmp.Length == 2)
            {
                tmp = tmp.Remove(tmp.Length - 1);
            }
            tmp = tmp.Remove(tmp.Length - 1);
            DisplayBox.Text = tmp;
        }

        private long MemOperation()
        {
            if (!long.TryParse(DisplayBox.Text, out long tmp))
            {
                long.TryParse(HistoryBox.Text, out tmp);
            }
            LblMemory.Visible = true;
            InputFocus();
            return tmp;
        }

        private void PlusMinus_Method()
        {
            string numS;
            long.TryParse(DisplayBox.Text, out long num);
            num = -num;
            numS = num.ToString();
            if (!numS.Equals("0"))
                DisplayBox.Text = numS;
        }

        /// <summary>
        /// Click event for all buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (operation == "=" && DisplayBox.Text != string.Empty)
                InputParse();
            switch (btn.Name)
            {
                case "Btn0": DisplayBox.Text += "0"; break;
                case "Btn1": DisplayBox.Text += "1"; break;
                case "Btn2": DisplayBox.Text += "2"; break;
                case "Btn3": DisplayBox.Text += "3"; break;
                case "Btn4": DisplayBox.Text += "4"; break;
                case "Btn5": DisplayBox.Text += "5"; break;
                case "Btn6": DisplayBox.Text += "6"; break;
                case "Btn7": DisplayBox.Text += "7"; break;
                case "Btn8": DisplayBox.Text += "8"; break;
                case "Btn9": DisplayBox.Text += "9"; break;
                case "BtnAdd": AddOperation("+"); break;
                case "BtnSubtract": AddOperation("-"); break;
                case "BtnMultiply": AddOperation("*"); break;
                case "BtnDivide": AddOperation("/"); break;
                case "BtnModulo": AddOperation("%"); break;
                case "BtnSquare": AddOperation("^"); Calculate(); HistoryBox.Text = number1.ToString(); break;
                case "BtnPlusMinus": PlusMinus_Method(); break;
                case "BtnEquals": if (DisplayBox.Text != string.Empty) InputParse(true); HistoryBox.Text = Calculate(); break;
                case "BtnMemGet": DisplayBox.Text = memory.ToString(); break;
                case "BtnMemAdd": memory += MemOperation(); LblMemory.Text = "Memory: " + memory.ToString(); break;
                case "BtnMemSub": memory -= MemOperation(); LblMemory.Text = "Memory: " + memory.ToString(); break;
                case "BtnMemClear": memory = 0; LblMemory.Visible = false; break;
                case "BtnClear": ClearDisplay(); break;
                case "BtnDelete": DeleteInputChar(); break;
            }
            InputFocus();
        }

        private void ClearDisplay()
        {
            if (DisplayBox.Text == string.Empty)
            {
                HistoryBox.Text = string.Empty;
                number1 = 0;
                number2 = 0;
                operation = string.Empty;
            }
            else
                DisplayBox.Text = string.Empty;
        }

        private string Calculate()
        {
            long result;
            if (number2 == 0)
            {
                InputParse(true);
            }
            switch (operation)
            {
                case "+": result = number1 + number2; break;
                case "-": result = number1 - number2; break;
                case "/":
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                    {
                        MessageBox.Show("You can't divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = number1;
                    }
                    break;
                case "*": result = number1 * number2; break;
                case "^": result = number1 * number1; break;
                case "%":
                    if (number2 != 0)
                        result = number1 % number2;
                    else
                    {
                        MessageBox.Show("You can't divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = number1;
                    }
                    break;
                case "=": result = number1;  break;
                default: result = number2; break;

            }
            number1 = result;
            operation= "=";
            DisplayBox.Text = string.Empty;
            string resultStr = result.ToString();
            return resultStr;
        }

        /// <summary>
        /// Parses text from DisplayBox into a <see cref="long"/> number1 or number2 depending on <paramref name="b"/>.
        /// </summary>
        /// <param name="b">If set to <see langword="true"/> outputs to number2, otherwise to number1</param>
        private void InputParse(bool b = false)
        {
            if (b)
                long.TryParse(DisplayBox.Text, out number2);
            else
                long.TryParse(DisplayBox.Text, out number1);
        }

        private void AddOperation(string op)
        {
            if (number1 != 0 && DisplayBox.Text != string.Empty)
            { InputParse(true); Calculate(); }
            operation = op;
            ShowEquation();
            DisplayBox.Text = string.Empty;
        }

        private void ShowEquation()
        {
            string toHistory;
            if (number1 == 0 && DisplayBox.Text != string.Empty)
                InputParse();
            toHistory = number1.ToString() + operation;
            HistoryBox.Text = toHistory;
        }
    }
}
