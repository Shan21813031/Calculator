namespace Task1_5_Calculator
{
    partial class frmCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalc));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecNum = new System.Windows.Forms.Label();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecNum = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbxPlus = new System.Windows.Forms.PictureBox();
            this.pbxMinus = new System.Windows.Forms.PictureBox();
            this.pbxDivide = new System.Windows.Forms.PictureBox();
            this.pbxMult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitle.Location = new System.Drawing.Point(200, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Simple Calculator";
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstNum.Location = new System.Drawing.Point(68, 102);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(129, 25);
            this.lblFirstNum.TabIndex = 1;
            this.lblFirstNum.Text = "First Number:";
            // 
            // lblSecNum
            // 
            this.lblSecNum.AutoSize = true;
            this.lblSecNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSecNum.Location = new System.Drawing.Point(37, 164);
            this.lblSecNum.Name = "lblSecNum";
            this.lblSecNum.Size = new System.Drawing.Size(160, 25);
            this.lblSecNum.TabIndex = 2;
            this.lblSecNum.Text = "Second Number:";
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultLabel.Location = new System.Drawing.Point(125, 222);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(72, 25);
            this.lblResultLabel.TabIndex = 3;
            this.lblResultLabel.Text = "Result:";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtFirstNum.Location = new System.Drawing.Point(216, 90);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(100, 53);
            this.txtFirstNum.TabIndex = 4;
            // 
            // txtSecNum
            // 
            this.txtSecNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtSecNum.Location = new System.Drawing.Point(216, 149);
            this.txtSecNum.Name = "txtSecNum";
            this.txtSecNum.Size = new System.Drawing.Size(100, 53);
            this.txtSecNum.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.LightBlue;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblResult.Location = new System.Drawing.Point(208, 215);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 46);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Location = new System.Drawing.Point(192, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSub.Location = new System.Drawing.Point(135, 300);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(132, 39);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMult.Location = new System.Drawing.Point(500, 300);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(116, 39);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "Multiply";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDiv.Location = new System.Drawing.Point(500, 345);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(93, 39);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnQuit.Location = new System.Drawing.Point(396, 300);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(77, 39);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPower
            // 
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPower.Location = new System.Drawing.Point(273, 300);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(99, 39);
            this.btnPower.TabIndex = 12;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAverage.Location = new System.Drawing.Point(273, 346);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(116, 39);
            this.btnAverage.TabIndex = 13;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Location = new System.Drawing.Point(396, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 39);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pbxPlus
            // 
            this.pbxPlus.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlus.Image")));
            this.pbxPlus.Location = new System.Drawing.Point(192, 391);
            this.pbxPlus.Name = "pbxPlus";
            this.pbxPlus.Size = new System.Drawing.Size(75, 50);
            this.pbxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlus.TabIndex = 15;
            this.pbxPlus.TabStop = false;
            // 
            // pbxMinus
            // 
            this.pbxMinus.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinus.Image")));
            this.pbxMinus.Location = new System.Drawing.Point(59, 289);
            this.pbxMinus.Name = "pbxMinus";
            this.pbxMinus.Size = new System.Drawing.Size(70, 50);
            this.pbxMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinus.TabIndex = 16;
            this.pbxMinus.TabStop = false;
            // 
            // pbxDivide
            // 
            this.pbxDivide.Image = ((System.Drawing.Image)(resources.GetObject("pbxDivide.Image")));
            this.pbxDivide.Location = new System.Drawing.Point(500, 388);
            this.pbxDivide.Name = "pbxDivide";
            this.pbxDivide.Size = new System.Drawing.Size(77, 50);
            this.pbxDivide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDivide.TabIndex = 17;
            this.pbxDivide.TabStop = false;
            // 
            // pbxMult
            // 
            this.pbxMult.Image = ((System.Drawing.Image)(resources.GetObject("pbxMult.Image")));
            this.pbxMult.Location = new System.Drawing.Point(622, 289);
            this.pbxMult.Name = "pbxMult";
            this.pbxMult.Size = new System.Drawing.Size(100, 50);
            this.pbxMult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMult.TabIndex = 18;
            this.pbxMult.TabStop = false;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxMult);
            this.Controls.Add(this.pbxDivide);
            this.Controls.Add(this.pbxMinus);
            this.Controls.Add(this.pbxPlus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSecNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.lblSecNum);
            this.Controls.Add(this.lblFirstNum);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalc_FormClosed);
            this.Load += new System.EventHandler(this.frmCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecNum;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecNum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbxPlus;
        private System.Windows.Forms.PictureBox pbxMinus;
        private System.Windows.Forms.PictureBox pbxDivide;
        private System.Windows.Forms.PictureBox pbxMult;
    }
}

