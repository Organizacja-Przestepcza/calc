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

        private int number1, number2;
        private string operation;

        #region Clear Buttons Click

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(DisplayBox.Text.Length>0)
            {
                DisplayBox.Text = DisplayBox.Text.Remove(DisplayBox.Text.Length-1);
            }
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
            AddOperationComplex("*");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            AddOperationComplex("/");
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            if(DisplayBox.Text==string.Empty)
            {

            }
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
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
            int result = 0;
            if(number2==0)
            {
                int.TryParse(DisplayBox.Text, out number2);
            }
            switch(operation)
            {
                case "+": result = number1 + number2; break;
                case "-": result = number1 - number2; break;
                case "/": Division(); break;
                case "*": result = number1 * number2; break;
            }
            number1 = result;
            DisplayBox.Text=string.Empty;
            string resultStr = result.ToString();
            return resultStr;
        }

        private void AddOperationSimple(string op)
        {
            int.TryParse(DisplayBox.Text, out number1);

            operation = op;
            ShowEquation();
            DisplayBox.Text = string.Empty;
        }

        private void AddOperationComplex(string op)
        {

        }

        private void ShowEquation()
        {
            string toHistory = number1.ToString() + operation;
            HistoryBox.Text=toHistory;
        }

        private void Division()
        {
            if(number1%number2==0)
            {
                return;
            }
        }

        #endregion

    }
}
