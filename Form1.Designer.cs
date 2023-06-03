namespace calc
{
    partial class Calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnModulo = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnPlusMinus = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnMemSub = new System.Windows.Forms.Button();
            this.BtnMemAdd = new System.Windows.Forms.Button();
            this.BtnMemGet = new System.Windows.Forms.Button();
            this.BtnMemClear = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.tbl_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.LblMemory = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.tbl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEquals
            // 
            this.BtnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEquals.Location = new System.Drawing.Point(213, 276);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(64, 59);
            this.BtnEquals.TabIndex = 19;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.Btn_Click);
            this.BtnEquals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // BtnModulo
            // 
            this.BtnModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnModulo.Location = new System.Drawing.Point(143, 36);
            this.BtnModulo.Name = "BtnModulo";
            this.BtnModulo.Size = new System.Drawing.Size(64, 54);
            this.BtnModulo.TabIndex = 18;
            this.BtnModulo.Text = "%";
            this.BtnModulo.UseVisualStyleBackColor = true;
            this.BtnModulo.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn0
            // 
            this.Btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn0.Location = new System.Drawing.Point(73, 276);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(64, 59);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnPlusMinus
            // 
            this.BtnPlusMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPlusMinus.Location = new System.Drawing.Point(3, 276);
            this.BtnPlusMinus.Name = "BtnPlusMinus";
            this.BtnPlusMinus.Size = new System.Drawing.Size(64, 59);
            this.BtnPlusMinus.TabIndex = 16;
            this.BtnPlusMinus.Text = "+/-";
            this.BtnPlusMinus.UseVisualStyleBackColor = true;
            this.BtnPlusMinus.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Location = new System.Drawing.Point(213, 216);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(64, 54);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn3.Location = new System.Drawing.Point(143, 216);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(64, 54);
            this.Btn3.TabIndex = 12;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn2.Location = new System.Drawing.Point(73, 216);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(64, 54);
            this.Btn2.TabIndex = 14;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn1
            // 
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn1.Location = new System.Drawing.Point(3, 216);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(64, 54);
            this.Btn1.TabIndex = 13;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSubtract.Location = new System.Drawing.Point(213, 156);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(64, 54);
            this.BtnSubtract.TabIndex = 11;
            this.BtnSubtract.Text = "\t-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn6
            // 
            this.Btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn6.Location = new System.Drawing.Point(143, 156);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(64, 54);
            this.Btn6.TabIndex = 10;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn5
            // 
            this.Btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn5.Location = new System.Drawing.Point(73, 156);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(64, 54);
            this.Btn5.TabIndex = 9;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn4
            // 
            this.Btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn4.Location = new System.Drawing.Point(3, 156);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(64, 54);
            this.Btn4.TabIndex = 8;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMultiply.Location = new System.Drawing.Point(213, 96);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(64, 54);
            this.BtnMultiply.TabIndex = 7;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn9
            // 
            this.Btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn9.Location = new System.Drawing.Point(143, 96);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(64, 54);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn8
            // 
            this.Btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn8.Location = new System.Drawing.Point(73, 96);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(64, 54);
            this.Btn8.TabIndex = 5;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn7
            // 
            this.Btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn7.Location = new System.Drawing.Point(3, 96);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(64, 54);
            this.Btn7.TabIndex = 4;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDivide.Location = new System.Drawing.Point(213, 36);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(64, 54);
            this.BtnDivide.TabIndex = 3;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSquare.Location = new System.Drawing.Point(73, 36);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(64, 54);
            this.BtnSquare.TabIndex = 1;
            this.BtnSquare.Text = "x^2";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(143, 276);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(64, 59);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Del";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.Location = new System.Drawing.Point(3, 36);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(64, 54);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnMemSub
            // 
            this.BtnMemSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMemSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMemSub.Location = new System.Drawing.Point(213, 3);
            this.BtnMemSub.Name = "BtnMemSub";
            this.BtnMemSub.Size = new System.Drawing.Size(64, 27);
            this.BtnMemSub.TabIndex = 23;
            this.BtnMemSub.Text = "M-";
            this.BtnMemSub.UseVisualStyleBackColor = true;
            this.BtnMemSub.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnMemAdd
            // 
            this.BtnMemAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMemAdd.Location = new System.Drawing.Point(143, 3);
            this.BtnMemAdd.Name = "BtnMemAdd";
            this.BtnMemAdd.Size = new System.Drawing.Size(64, 27);
            this.BtnMemAdd.TabIndex = 22;
            this.BtnMemAdd.Text = "M+";
            this.BtnMemAdd.UseVisualStyleBackColor = true;
            this.BtnMemAdd.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnMemGet
            // 
            this.BtnMemGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMemGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMemGet.Location = new System.Drawing.Point(73, 3);
            this.BtnMemGet.Name = "BtnMemGet";
            this.BtnMemGet.Size = new System.Drawing.Size(64, 27);
            this.BtnMemGet.TabIndex = 21;
            this.BtnMemGet.Text = "MR";
            this.BtnMemGet.UseVisualStyleBackColor = true;
            this.BtnMemGet.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnMemClear
            // 
            this.BtnMemClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMemClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMemClear.Location = new System.Drawing.Point(3, 3);
            this.BtnMemClear.Name = "BtnMemClear";
            this.BtnMemClear.Size = new System.Drawing.Size(64, 27);
            this.BtnMemClear.TabIndex = 20;
            this.BtnMemClear.Text = "MC";
            this.BtnMemClear.UseVisualStyleBackColor = true;
            this.BtnMemClear.Click += new System.EventHandler(this.Btn_Click);
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Controls.Add(this.HistoryBox);
            this.container.Controls.Add(this.tbl_buttons);
            this.container.Controls.Add(this.DisplayBox);
            this.container.Location = new System.Drawing.Point(12, 27);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(280, 402);
            this.container.TabIndex = 2;
            // 
            // HistoryBox
            // 
            this.HistoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HistoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HistoryBox.Location = new System.Drawing.Point(0, 0);
            this.HistoryBox.MaxLength = 64;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.ReadOnly = true;
            this.HistoryBox.Size = new System.Drawing.Size(280, 26);
            this.HistoryBox.TabIndex = 3;
            this.HistoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HistoryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbl_buttons
            // 
            this.tbl_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_buttons.ColumnCount = 4;
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_buttons.Controls.Add(this.BtnEquals, 3, 5);
            this.tbl_buttons.Controls.Add(this.Btn0, 1, 5);
            this.tbl_buttons.Controls.Add(this.BtnPlusMinus, 0, 5);
            this.tbl_buttons.Controls.Add(this.BtnAdd, 3, 4);
            this.tbl_buttons.Controls.Add(this.Btn3, 2, 4);
            this.tbl_buttons.Controls.Add(this.Btn2, 1, 4);
            this.tbl_buttons.Controls.Add(this.Btn1, 0, 4);
            this.tbl_buttons.Controls.Add(this.BtnSubtract, 3, 3);
            this.tbl_buttons.Controls.Add(this.Btn6, 2, 3);
            this.tbl_buttons.Controls.Add(this.Btn5, 1, 3);
            this.tbl_buttons.Controls.Add(this.Btn4, 0, 3);
            this.tbl_buttons.Controls.Add(this.BtnMultiply, 3, 2);
            this.tbl_buttons.Controls.Add(this.Btn9, 2, 2);
            this.tbl_buttons.Controls.Add(this.Btn8, 1, 2);
            this.tbl_buttons.Controls.Add(this.Btn7, 0, 2);
            this.tbl_buttons.Controls.Add(this.BtnDivide, 3, 1);
            this.tbl_buttons.Controls.Add(this.BtnClear, 0, 1);
            this.tbl_buttons.Controls.Add(this.BtnMemSub, 3, 0);
            this.tbl_buttons.Controls.Add(this.BtnMemAdd, 2, 0);
            this.tbl_buttons.Controls.Add(this.BtnMemGet, 1, 0);
            this.tbl_buttons.Controls.Add(this.BtnMemClear, 0, 0);
            this.tbl_buttons.Controls.Add(this.BtnSquare, 1, 1);
            this.tbl_buttons.Controls.Add(this.BtnModulo, 2, 1);
            this.tbl_buttons.Controls.Add(this.BtnDelete, 2, 5);
            this.tbl_buttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbl_buttons.Location = new System.Drawing.Point(0, 64);
            this.tbl_buttons.Name = "tbl_buttons";
            this.tbl_buttons.RowCount = 6;
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbl_buttons.Size = new System.Drawing.Size(280, 338);
            this.tbl_buttons.TabIndex = 2;
            // 
            // DisplayBox
            // 
            this.DisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DisplayBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DisplayBox.Location = new System.Drawing.Point(0, 32);
            this.DisplayBox.MaxLength = 18;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(280, 26);
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DisplayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // LblMemory
            // 
            this.LblMemory.AutoSize = true;
            this.LblMemory.Location = new System.Drawing.Point(12, 9);
            this.LblMemory.MaximumSize = new System.Drawing.Size(280, 15);
            this.LblMemory.MinimumSize = new System.Drawing.Size(280, 15);
            this.LblMemory.Name = "LblMemory";
            this.LblMemory.Size = new System.Drawing.Size(280, 15);
            this.LblMemory.TabIndex = 3;
            this.LblMemory.Text = "Memory: 0";
            this.LblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblMemory.Visible = false;
            // 
            // Calc
            // 
            this.AcceptButton = this.BtnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClear;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.LblMemory);
            this.Controls.Add(this.container);
            this.MaximumSize = new System.Drawing.Size(520, 800);
            this.MinimumSize = new System.Drawing.Size(260, 440);
            this.Name = "Calc";
            this.Text = "Calc";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.tbl_buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnModulo;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnPlusMinus;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnMemSub;
        private System.Windows.Forms.Button BtnMemAdd;
        private System.Windows.Forms.Button BtnMemGet;
        private System.Windows.Forms.Button BtnMemClear;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel tbl_buttons;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.TextBox HistoryBox;
        private System.Windows.Forms.Label LblMemory;
    }
}

