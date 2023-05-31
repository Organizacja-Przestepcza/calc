﻿using System;
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

        private void BtnPercent_Click(object sender, EventArgs e)
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

        #endregion

        #region Calculations
        /// <summary>
        /// Adds string from DisplayBox to HistoryBox
        /// </summary>
        /// <param name="op">String to be added at the end</param>
        private void HistoryUpdate(string op="")
        {
            var history = HistoryBox.Text;
            
            if (history == string.Empty)
            {
                history = DisplayBox.Text;
                if (!int.TryParse(history, out number1))
                    return;
            }
            else if (DisplayBox.Text == string.Empty)
                history = history.Remove(history.Length - 1, 1);

            history += op;
            HistoryBox.Text = history;
            // usuwa input
            DisplayBox.Text = string.Empty;
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
            }
            else
                DisplayBox.Text = string.Empty;
        }

        private void Calculate()
        {

        }

        #endregion

    }
}
