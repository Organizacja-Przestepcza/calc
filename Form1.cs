using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        #region Operations Click
        private void BtnClear_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = string.Empty;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(DisplayBox.Text.Length>0)
            {
                DisplayBox.Text = DisplayBox.Text.Remove(DisplayBox.Text.Length-1);
            }
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

    }
}
