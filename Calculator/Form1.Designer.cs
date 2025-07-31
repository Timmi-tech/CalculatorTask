namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDec = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnCE = new Button();
            button2 = new Button();
            btnSub = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btnAdd = new Button();
            btnPM = new Button();
            btn0 = new Button();
            btnEqu = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnC = new Button();
            button8 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btnBackSpace = new Button();
            txtDisplay = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnDec);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btnCE);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSub);
            panel1.Controls.Add(btnDiv);
            panel1.Controls.Add(btnMult);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnPM);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btnEqu);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btnC);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btnBackSpace);
            panel1.Controls.Add(txtDisplay);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 481);
            panel1.TabIndex = 0;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDec.Location = new Point(92, 390);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(77, 76);
            btnDec.TabIndex = 1;
            btnDec.Text = ".";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(92, 308);
            btn2.Name = "btn2";
            btn2.Size = new Size(77, 76);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button1_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(92, 226);
            btn5.Name = "btn5";
            btn5.Size = new Size(77, 76);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button1_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(92, 144);
            btn8.Name = "btn8";
            btn8.Size = new Size(77, 76);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button1_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCE.Location = new Point(92, 62);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(77, 76);
            btnCE.TabIndex = 1;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += BtnClear_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(92, 62);
            button2.Name = "button2";
            button2.Size = new Size(77, 76);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(258, 226);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(77, 76);
            btnSub.TabIndex = 1;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += button1_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(258, 390);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(77, 76);
            btnDiv.TabIndex = 1;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += button1_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMult.Location = new Point(258, 308);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(77, 76);
            btnMult.TabIndex = 1;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(258, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 76);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPM.Location = new Point(258, 62);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(77, 76);
            btnPM.TabIndex = 1;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += button1_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(9, 390);
            btn0.Name = "btn0";
            btn0.Size = new Size(77, 76);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button1_Click;
            // 
            // btnEqu
            // 
            btnEqu.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqu.Location = new Point(175, 390);
            btnEqu.Name = "btnEqu";
            btnEqu.Size = new Size(77, 76);
            btnEqu.TabIndex = 1;
            btnEqu.Text = "=";
            btnEqu.UseVisualStyleBackColor = true;
            btnEqu.Click += BtnEqual_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(175, 308);
            btn3.Name = "btn3";
            btn3.Size = new Size(77, 76);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button1_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(175, 226);
            btn6.Name = "btn6";
            btn6.Size = new Size(77, 76);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button1_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(175, 144);
            btn9.Name = "btn9";
            btn9.Size = new Size(77, 76);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button1_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.Location = new Point(175, 62);
            btnC.Name = "btnC";
            btnC.Size = new Size(77, 76);
            btnC.TabIndex = 1;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += BtnClear_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(9, 390);
            button8.Name = "button8";
            button8.Size = new Size(77, 76);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(9, 308);
            btn1.Name = "btn1";
            btn1.Size = new Size(77, 76);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(9, 226);
            btn4.Name = "btn4";
            btn4.Size = new Size(77, 76);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button1_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(9, 144);
            btn7.Name = "btn7";
            btn7.Size = new Size(77, 76);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button1_Click;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Font = new Font("Wingdings", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnBackSpace.Location = new Point(9, 62);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(77, 76);
            btnBackSpace.TabIndex = 1;
            btnBackSpace.Text = "";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += BtnBackspace_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(9, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(326, 46);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 498);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBackSpace;
        private TextBox txtDisplay;
        private Button button2;
        private Button btnPM;
        private Button btnC;
        private Button btnCE;
        private Button btn0;
        private Button button8;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btnDec;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnSub;
        private Button btnDiv;
        private Button btnMult;
        private Button btnAdd;
        private Button btnEqu;
        private Button btn3;
        private Button btn6;
        private Button btn9;
    }
}
