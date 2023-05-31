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

        private bool floatOperation = false;

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

        }
        #endregion

        #region Operations Click

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            HistoryUpdate("+");
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            HistoryUpdate("-");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            HistoryUpdate("*");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            HistoryUpdate("/");
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            string result = "";
            Calculate();
            HistoryUpdate("=" + result);
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

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!DisplayBox.Text.Contains("."))
            {
                DisplayBox.Text += ".";
            }
        }
        #endregion

        #region Calculations
        /// <summary>
        /// Adds string from DisplayBox to HistoryBox
        /// </summary>
        /// <param name="op">String to be added at the end</param>
        private void HistoryUpdate(string op="")
        {
            var history = HistoryBox.Text;
            // jeśli równanie gotowe to usuwa historie i daje rezultat
            if (history != string.Empty)
            {
                if (!char.IsDigit(history.Last()))
                {
                    history = ClearHistoryWithResult();
                }

                // zamienia ostatni znak jeśli nie dostał liczby
                else if (DisplayBox.Text == string.Empty)
                    history = history.Remove(history.Length - 1, 1);
            }
            history += CheckForFloat();
            
            
            // jak history pusty to nic nie pisze
            if(history != string.Empty)
                history += op;
            HistoryBox.Text = history;
            // usuwa input
            DisplayBox.Text = string.Empty;
        }

        /// <summary>
        /// Checks if the input is a float and formats it
        /// </summary>
        /// <returns><see cref="string"/> with formatted number</returns>
        private string CheckForFloat()
        {
            var number = DisplayBox.Text;
            if(number == string.Empty)
            {
                return number;
            }
            if(number.Contains('.'))
            {
                floatOperation = true;
                string mantise = number.Substring(number.IndexOf('.'));
                if (mantise.Length <= 0)
                    number = number.Remove(number.Length - 1, 1);
                else
                {
                    for (int i = 0; i < mantise.Length; i++)
                    {
                        var ind = mantise.Length - 1 - i;
                        if ((mantise[ind] == '0') || (mantise[ind] == '.'))
                            number = number.Remove(number.Length - 1, 1);
                        else
                            break;
                    }
                }
            }
            return number;
        }

        private string ClearHistoryWithResult()
        {
            var result = HistoryBox.Text.Substring(HistoryBox.Text.IndexOf('=')+1);
            HistoryBox.Text = string.Empty;
            return result;
        }

        private void ClearDisplay()
        {
            if (DisplayBox.Text == string.Empty)
            {
                HistoryBox.Text = string.Empty;
                floatOperation = false;
            }
            else
                DisplayBox.Text = string.Empty;
        }

        private void Calculate()
        {
            if(floatOperation)
            {

            }
            else
            {

            }
        }

        #endregion

    }
}
