using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Calc : Form
    {

        public Calc()
        {
            InitializeComponent();
        }

        private long number1, number2;
        private string operation;

        #region Clear Buttons Click

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string tmp = DisplayBox.Text;
            if (tmp.Length == 0)
            {
                return;
            }
            if (tmp.Contains("-") && tmp.Length==2)
            {
                tmp = tmp.Remove(tmp.Length - 1);
            }
            tmp = tmp.Remove(tmp.Length - 1);
            DisplayBox.Text = tmp;
        }

        private void BtnMemClear_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = number1.ToString()+operation;
        }
        #endregion

        #region Operations Click

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddOperationSimple("+");
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            AddOperationSimple("-");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            AddOperationSimple("*");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            AddOperationSimple("/");
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            AddOperationSimple("^");
            Calculate();
            HistoryBox.Text = number1.ToString();
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            AddOperationSimple("%");
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            string numS = DisplayBox.Text;
            long num;
            long.TryParse(DisplayBox.Text, out num);
            num = -num;
            numS = num.ToString();
            if (!numS.Equals("0"))
                DisplayBox.Text = numS;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text!=string.Empty)
            {
                InputParse(true);
            }
            HistoryBox.Text = Calculate();
        }

        #endregion

        #region Numbers Click

        private void Btn0_Click(object sender, EventArgs e) => DisplayBox.Text += "0";

        private void Btn1_Click(object sender, EventArgs e) => DisplayBox.Text += "1";

        private void Btn2_Click(object sender, EventArgs e) => DisplayBox.Text += "2";

        private void Btn3_Click(object sender, EventArgs e) => DisplayBox.Text += "3";

        private void Btn4_Click(object sender, EventArgs e) => DisplayBox.Text += "4";

        private void Btn5_Click(object sender, EventArgs e) => DisplayBox.Text += "5";

        private void Btn6_Click(object sender, EventArgs e) => DisplayBox.Text += "6";

        private void Btn7_Click(object sender, EventArgs e) => DisplayBox.Text += "7";

        private void Btn8_Click(object sender, EventArgs e) => DisplayBox.Text += "8";

        private void Btn9_Click(object sender, EventArgs e) => DisplayBox.Text += "9";

        #endregion

        #region Calculations

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
            long result = 0;
            if (number2==0)
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
                        MessageBox.Show("You can't divide by zero","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = number1;
                    }
                    break;
                    /*string resultDivStr;
                    if (number1 % number2 != 0)
                    {
                        float resultF = (float) number1/number2;
                        resultDivStr = resultF.ToString();
                    }
                    else
                    {
                        int resultI = number1/number2;
                        resultDivStr = resultI.ToString();
                        number1 = result;
                    }
                    DisplayBox.Text = string.Empty;
                    return resultDivStr;*/
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
                    
            }
            number1 = result;
            DisplayBox.Text = string.Empty;
            string resultStr = result.ToString();
            return resultStr;
        }

        /// <summary>
        /// Parses text from DisplayBox into an <see cref="long"/> <see cref="number1"/> or <see cref="number2"/> depending on <paramref name="b"/>.
        /// </summary>
        /// <param name="b">If set to <see langword="true"/> outputs to number2, otherwise to number1</param>
        private void InputParse(bool b=false)
        {
            if (b)
                long.TryParse(DisplayBox.Text, out number2);
            else
                long.TryParse(DisplayBox.Text, out number1);
        }

        private void AddOperationSimple(string op)
        {
            operation = op;
            ShowEquation();
            DisplayBox.Text = string.Empty;
        }

        private void ShowEquation()
        {
            if(number1 == 0)
                InputParse();
            string toHistory = number1.ToString() + operation;
            HistoryBox.Text=toHistory;
        }

        /// <summary>
        /// Switches sign of a number in a string
        /// </summary>
        /// <param name="num">Number to be multiplied by -1</param>
        private string ReverseSignString(long num)
        {
            num = -num;
            string numStr = num.ToString();
            return numStr;
        }

        #endregion

    }
}
