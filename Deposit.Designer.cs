namespace Project
{
    partial class Deposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbDep = new System.Windows.Forms.TextBox();
            this.lbBack = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lbDep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 80);
            this.panel1.TabIndex = 3;
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
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAmount.Location = new System.Drawing.Point(46, 142);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(168, 37);
            this.lbAmount.TabIndex = 46;
            this.lbAmount.Text = "AMOUNT";
            // 
            // tbDep
            // 
            this.tbDep.Location = new System.Drawing.Point(241, 142);
            this.tbDep.Multiline = true;
            this.tbDep.Name = "tbDep";
            this.tbDep.Size = new System.Drawing.Size(206, 37);
            this.tbDep.TabIndex = 51;
            // 
            // lbBack
            // 
            this.lbBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBack.Location = new System.Drawing.Point(227, 308);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(90, 28);
            this.lbBack.TabIndex = 52;
            this.lbBack.Text = "BACK";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnDeposit.Location = new System.Drawing.Point(196, 236);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(162, 48);
            this.btnDeposit.TabIndex = 53;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lbDep
            // 
            this.lbDep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDep.Location = new System.Drawing.Point(158, 87);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(168, 37);
            this.lbDep.TabIndex = 54;
            this.lbDep.Text = "DEPOSIT";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(455, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 356);
            this.Controls.Add(this.lbDep);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.tbDep);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.panel1);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbDep;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDep;
    }
}