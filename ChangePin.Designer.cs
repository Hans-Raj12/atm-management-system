namespace Project
{
    partial class ChangePin
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
            this.lbBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPin = new System.Windows.Forms.Label();
            this.lbCPin = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbLOut = new System.Windows.Forms.Label();
            this.tbPin1 = new System.Windows.Forms.TextBox();
            this.tbPin2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.lbBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 94);
            this.panel1.TabIndex = 2;
            // 
            // lbBack
            // 
            this.lbBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBack.Location = new System.Drawing.Point(475, 0);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(25, 28);
            this.lbBack.TabIndex = 53;
            this.lbBack.Text = "X";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
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
            // lbPin
            // 
            this.lbPin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPin.Location = new System.Drawing.Point(34, 145);
            this.lbPin.Name = "lbPin";
            this.lbPin.Size = new System.Drawing.Size(188, 37);
            this.lbPin.TabIndex = 45;
            this.lbPin.Text = "NEW PIN";
            // 
            // lbCPin
            // 
            this.lbCPin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCPin.Location = new System.Drawing.Point(34, 220);
            this.lbCPin.Name = "lbCPin";
            this.lbCPin.Size = new System.Drawing.Size(188, 37);
            this.lbCPin.TabIndex = 46;
            this.lbCPin.Text = "CONFIRM PIN";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.Location = new System.Drawing.Point(165, 311);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(162, 48);
            this.btnChange.TabIndex = 47;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbLOut
            // 
            this.lbLOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbLOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLOut.Location = new System.Drawing.Point(195, 379);
            this.lbLOut.Name = "lbLOut";
            this.lbLOut.Size = new System.Drawing.Size(91, 28);
            this.lbLOut.TabIndex = 49;
            this.lbLOut.Text = "BACK";
            this.lbLOut.Click += new System.EventHandler(this.lbLOut_Click);
            // 
            // tbPin1
            // 
            this.tbPin1.Location = new System.Drawing.Point(228, 145);
            this.tbPin1.Multiline = true;
            this.tbPin1.Name = "tbPin1";
            this.tbPin1.Size = new System.Drawing.Size(183, 37);
            this.tbPin1.TabIndex = 50;
            // 
            // tbPin2
            // 
            this.tbPin2.Location = new System.Drawing.Point(228, 220);
            this.tbPin2.Multiline = true;
            this.tbPin2.Name = "tbPin2";
            this.tbPin2.Size = new System.Drawing.Size(183, 37);
            this.tbPin2.TabIndex = 51;
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 416);
            this.Controls.Add(this.tbPin2);
            this.Controls.Add(this.tbPin1);
            this.Controls.Add(this.lbLOut);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lbCPin);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePin";
            this.Text = "ChangePin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPin;
        private System.Windows.Forms.Label lbCPin;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lbLOut;
        private System.Windows.Forms.TextBox tbPin1;
        private System.Windows.Forms.TextBox tbPin2;
        private System.Windows.Forms.Label lbBack;
    }
}