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
    public partial class calc : Form
    {
  
        public calc()
        {
            InitializeComponent();
        }

        #region Operations
        private void btn_clear_Click(object sender, EventArgs e)
        {
            displayBox.Text=string.Empty;
        }
        #endregion
        #region Numbers

        #endregion
    }
}
