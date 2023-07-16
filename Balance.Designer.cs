namespace Project
{
    partial class Balance
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
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAccNum = new System.Windows.Forms.Label();
            this.lbBal = new System.Windows.Forms.Label();
            this.lbAcc = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 90);
            this.panel1.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(564, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(29, 27);
            this.lbl.TabIndex = 49;
            this.lbl.Text = "X";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(120, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lbAccNum
            // 
            this.lbAccNum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAccNum.Location = new System.Drawing.Point(41, 153);
            this.lbAccNum.Name = "lbAccNum";
            this.lbAccNum.Size = new System.Drawing.Size(213, 37);
            this.lbAccNum.TabIndex = 44;
            this.lbAccNum.Text = "ACCOUNT NUM:";
            // 
            // lbBal
            // 
            this.lbBal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBal.Location = new System.Drawing.Point(41, 241);
            this.lbBal.Name = "lbBal";
            this.lbBal.Size = new System.Drawing.Size(226, 37);
            this.lbBal.TabIndex = 45;
            this.lbBal.Text = "YOUR BALANCE :";
            // 
            // lbAcc
            // 
            this.lbAcc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAcc.Location = new System.Drawing.Point(273, 153);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(141, 37);
            this.lbAcc.TabIndex = 46;
            this.lbAcc.Text = "ACC Num";
            // 
            // lbBalance
            // 
            this.lbBalance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBalance.Location = new System.Drawing.Point(273, 241);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(212, 37);
            this.lbBalance.TabIndex = 47;
            this.lbBalance.Text = "BALANCE IN RS:";
            // 
            // lbBack
            // 
            this.lbBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBack.Location = new System.Drawing.Point(233, 381);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(85, 37);
            this.lbBack.TabIndex = 48;
            this.lbBack.Text = "BACK";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbAcc);
            this.Controls.Add(this.lbBal);
            this.Controls.Add(this.lbAccNum);
            this.Controls.Add(this.panel1);
            this.Name = "Balance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAccNum;
        private System.Windows.Forms.Label lbBal;
        private System.Windows.Forms.Label lbAcc;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Label lbl;
    }
}