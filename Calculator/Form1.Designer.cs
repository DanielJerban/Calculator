namespace Calculator
{
    partial class frmCalculate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndevide = new System.Windows.Forms.Button();
            this.btnmultiplie = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnminuse = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnpower = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndevide);
            this.panel1.Controls.Add(this.btnmultiplie);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btnminuse);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.btnplus);
            this.panel1.Controls.Add(this.btnbackspace);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btndot);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btnzero);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(-1, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 262);
            this.panel1.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnclear.Location = new System.Drawing.Point(142, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(61, 46);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndevide
            // 
            this.btndevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btndevide.Location = new System.Drawing.Point(209, 3);
            this.btndevide.Name = "btndevide";
            this.btndevide.Size = new System.Drawing.Size(61, 46);
            this.btndevide.TabIndex = 1;
            this.btndevide.Text = "/";
            this.btndevide.UseVisualStyleBackColor = true;
            this.btndevide.Click += new System.EventHandler(this.Operators);
            // 
            // btnmultiplie
            // 
            this.btnmultiplie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnmultiplie.Location = new System.Drawing.Point(209, 55);
            this.btnmultiplie.Name = "btnmultiplie";
            this.btnmultiplie.Size = new System.Drawing.Size(61, 46);
            this.btnmultiplie.TabIndex = 1;
            this.btnmultiplie.Text = "*";
            this.btnmultiplie.UseVisualStyleBackColor = true;
            this.btnmultiplie.Click += new System.EventHandler(this.Operators);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn9.Location = new System.Drawing.Point(142, 55);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(61, 46);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btnminuse
            // 
            this.btnminuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnminuse.Location = new System.Drawing.Point(209, 107);
            this.btnminuse.Name = "btnminuse";
            this.btnminuse.Size = new System.Drawing.Size(61, 46);
            this.btnminuse.TabIndex = 1;
            this.btnminuse.Text = "-";
            this.btnminuse.UseVisualStyleBackColor = true;
            this.btnminuse.Click += new System.EventHandler(this.Operators);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn6.Location = new System.Drawing.Point(142, 107);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(61, 46);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn8.Location = new System.Drawing.Point(75, 55);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(61, 46);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btnequal
            // 
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnequal.Location = new System.Drawing.Point(209, 211);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(61, 46);
            this.btnequal.TabIndex = 1;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnplus.Location = new System.Drawing.Point(209, 159);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(61, 46);
            this.btnplus.TabIndex = 1;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.Operators);
            // 
            // btnbackspace
            // 
            this.btnbackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnbackspace.Location = new System.Drawing.Point(8, 3);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(128, 46);
            this.btnbackspace.TabIndex = 1;
            this.btnbackspace.Text = "<---------------";
            this.btnbackspace.UseVisualStyleBackColor = true;
            this.btnbackspace.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn5.Location = new System.Drawing.Point(75, 107);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(61, 46);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btndot.Location = new System.Drawing.Point(142, 211);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(61, 46);
            this.btndot.TabIndex = 1;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btndot_MouseClick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn7.Location = new System.Drawing.Point(8, 55);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(61, 46);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn3.Location = new System.Drawing.Point(142, 159);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 46);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btnzero
            // 
            this.btnzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnzero.Location = new System.Drawing.Point(8, 211);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(128, 46);
            this.btnzero.TabIndex = 1;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn4.Location = new System.Drawing.Point(8, 107);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(61, 46);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn2.Location = new System.Drawing.Point(75, 159);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 46);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1.Location = new System.Drawing.Point(8, 159);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(61, 46);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers_MouseClick);
            // 
            // btnpower
            // 
            this.btnpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpower.Location = new System.Drawing.Point(7, 73);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(128, 46);
            this.btnpower.TabIndex = 1;
            this.btnpower.Text = "ON";
            this.btnpower.UseVisualStyleBackColor = true;
            this.btnpower.Click += new System.EventHandler(this.btnpower_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnumber.Location = new System.Drawing.Point(7, 12);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.ReadOnly = true;
            this.txtnumber.Size = new System.Drawing.Size(262, 26);
            this.txtnumber.TabIndex = 2;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // frmCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 387);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnpower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCalculate";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculate_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnmultiplie;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnminuse;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnbackspace;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btndevide;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnpower;
        private System.Windows.Forms.TextBox txtnumber;
    }
}

