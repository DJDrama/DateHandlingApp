namespace DateHandlingApp
{
    partial class DateHandling
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFutureDate = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.btnCalculateDueDates = new System.Windows.Forms.Button();
            this.btnCalculateAge = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a future date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter a birth date";
            // 
            // txtFutureDate
            // 
            this.txtFutureDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFutureDate.Location = new System.Drawing.Point(242, 121);
            this.txtFutureDate.Name = "txtFutureDate";
            this.txtFutureDate.Size = new System.Drawing.Size(150, 28);
            this.txtFutureDate.TabIndex = 1;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthDate.Location = new System.Drawing.Point(242, 208);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(150, 28);
            this.txtBirthDate.TabIndex = 2;
            // 
            // btnCalculateDueDates
            // 
            this.btnCalculateDueDates.Location = new System.Drawing.Point(95, 291);
            this.btnCalculateDueDates.Name = "btnCalculateDueDates";
            this.btnCalculateDueDates.Size = new System.Drawing.Size(282, 48);
            this.btnCalculateDueDates.TabIndex = 2;
            this.btnCalculateDueDates.Text = "Calculate Due Dates";
            this.btnCalculateDueDates.UseVisualStyleBackColor = true;
            this.btnCalculateDueDates.Click += new System.EventHandler(this.btnCalculateDueDates_Click);
            // 
            // btnCalculateAge
            // 
            this.btnCalculateAge.Location = new System.Drawing.Point(95, 374);
            this.btnCalculateAge.Name = "btnCalculateAge";
            this.btnCalculateAge.Size = new System.Drawing.Size(282, 48);
            this.btnCalculateAge.TabIndex = 2;
            this.btnCalculateAge.Text = "Calculate Age";
            this.btnCalculateAge.UseVisualStyleBackColor = true;
            this.btnCalculateAge.Click += new System.EventHandler(this.btnCalculateAge_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(95, 457);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(282, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DateHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 559);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateAge);
            this.Controls.Add(this.btnCalculateDueDates);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtFutureDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DateHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFutureDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Button btnCalculateDueDates;
        private System.Windows.Forms.Button btnCalculateAge;
        private System.Windows.Forms.Button btnExit;
    }
}

