namespace Project
{
    partial class Withdraw
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
            this.lb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWDraw = new System.Windows.Forms.Label();
            this.lbAvBal = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbWdAmount = new System.Windows.Forms.TextBox();
            this.btnWDraw = new System.Windows.Forms.Button();
            this.lbBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 85);
            this.panel1.TabIndex = 4;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb2.Location = new System.Drawing.Point(483, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(27, 28);
            this.lb2.TabIndex = 53;
            this.lb2.Text = "X";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lbWDraw
            // 
            this.lbWDraw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbWDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWDraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbWDraw.Location = new System.Drawing.Point(133, 91);
            this.lbWDraw.Name = "lbWDraw";
            this.lbWDraw.Size = new System.Drawing.Size(168, 37);
            this.lbWDraw.TabIndex = 55;
            this.lbWDraw.Text = "WITHDRAW";
            // 
            // lbAvBal
            // 
            this.lbAvBal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAvBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvBal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAvBal.Location = new System.Drawing.Point(133, 150);
            this.lbAvBal.Name = "lbAvBal";
            this.lbAvBal.Size = new System.Drawing.Size(294, 37);
            this.lbAvBal.TabIndex = 56;
            this.lbAvBal.Text = "AVAILABLE BALANCE";
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAmount.Location = new System.Drawing.Point(35, 219);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(168, 37);
            this.lbAmount.TabIndex = 57;
            this.lbAmount.Text = "AMOUNT";
            // 
            // tbWdAmount
            // 
            this.tbWdAmount.Location = new System.Drawing.Point(221, 219);
            this.tbWdAmount.Multiline = true;
            this.tbWdAmount.Name = "tbWdAmount";
            this.tbWdAmount.Size = new System.Drawing.Size(206, 37);
            this.tbWdAmount.TabIndex = 58;
            // 
            // btnWDraw
            // 
            this.btnWDraw.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWDraw.ForeColor = System.Drawing.Color.Black;
            this.btnWDraw.Location = new System.Drawing.Point(157, 319);
            this.btnWDraw.Name = "btnWDraw";
            this.btnWDraw.Size = new System.Drawing.Size(162, 48);
            this.btnWDraw.TabIndex = 59;
            this.btnWDraw.Text = "WITHDRAW";
            this.btnWDraw.UseVisualStyleBackColor = false;
            this.btnWDraw.Click += new System.EventHandler(this.btnWDraw_Click_1);
            // 
            // lbBack
            // 
            this.lbBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBack.Location = new System.Drawing.Point(193, 382);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(88, 28);
            this.lbBack.TabIndex = 60;
            this.lbBack.Text = "BACK";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click_1);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 428);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btnWDraw);
            this.Controls.Add(this.tbWdAmount);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbAvBal);
            this.Controls.Add(this.lbWDraw);
            this.Controls.Add(this.panel1);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWDraw;
        private System.Windows.Forms.Label lbAvBal;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbWdAmount;
        private System.Windows.Forms.Button btnWDraw;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Label lb2;
    }
}