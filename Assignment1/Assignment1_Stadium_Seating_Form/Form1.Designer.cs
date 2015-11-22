namespace Assignment1_Stadium_Seating_Form
{
    partial class formStadiumSeating
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
            this.gboxTicketsSold = new System.Windows.Forms.GroupBox();
            this.txtClassAQuantity = new System.Windows.Forms.TextBox();
            this.txtClassBQuantity = new System.Windows.Forms.TextBox();
            this.txtClassCQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxRevenue = new System.Windows.Forms.GroupBox();
            this.txtClassBRev = new System.Windows.Forms.TextBox();
            this.txtClassCRev = new System.Windows.Forms.TextBox();
            this.txtTotalRev = new System.Windows.Forms.TextBox();
            this.txtClassARev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gboxTicketsSold.SuspendLayout();
            this.gboxRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxTicketsSold
            // 
            this.gboxTicketsSold.Controls.Add(this.txtClassAQuantity);
            this.gboxTicketsSold.Controls.Add(this.txtClassBQuantity);
            this.gboxTicketsSold.Controls.Add(this.txtClassCQuantity);
            this.gboxTicketsSold.Controls.Add(this.label2);
            this.gboxTicketsSold.Controls.Add(this.label3);
            this.gboxTicketsSold.Controls.Add(this.label4);
            this.gboxTicketsSold.Controls.Add(this.label1);
            this.gboxTicketsSold.Location = new System.Drawing.Point(12, 12);
            this.gboxTicketsSold.Name = "gboxTicketsSold";
            this.gboxTicketsSold.Size = new System.Drawing.Size(284, 194);
            this.gboxTicketsSold.TabIndex = 0;
            this.gboxTicketsSold.TabStop = false;
            this.gboxTicketsSold.Text = "Tickets Sold";
            // 
            // txtClassAQuantity
            // 
            this.txtClassAQuantity.Location = new System.Drawing.Point(98, 78);
            this.txtClassAQuantity.Name = "txtClassAQuantity";
            this.txtClassAQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtClassAQuantity.TabIndex = 4;
            // 
            // txtClassBQuantity
            // 
            this.txtClassBQuantity.Location = new System.Drawing.Point(98, 112);
            this.txtClassBQuantity.Name = "txtClassBQuantity";
            this.txtClassBQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtClassBQuantity.TabIndex = 5;
            // 
            // txtClassCQuantity
            // 
            this.txtClassCQuantity.Location = new System.Drawing.Point(98, 144);
            this.txtClassCQuantity.Name = "txtClassCQuantity";
            this.txtClassCQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtClassCQuantity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // gboxRevenue
            // 
            this.gboxRevenue.Controls.Add(this.txtClassBRev);
            this.gboxRevenue.Controls.Add(this.txtClassCRev);
            this.gboxRevenue.Controls.Add(this.txtTotalRev);
            this.gboxRevenue.Controls.Add(this.txtClassARev);
            this.gboxRevenue.Controls.Add(this.label5);
            this.gboxRevenue.Controls.Add(this.label6);
            this.gboxRevenue.Controls.Add(this.label7);
            this.gboxRevenue.Controls.Add(this.label8);
            this.gboxRevenue.Location = new System.Drawing.Point(302, 12);
            this.gboxRevenue.Name = "gboxRevenue";
            this.gboxRevenue.Size = new System.Drawing.Size(273, 194);
            this.gboxRevenue.TabIndex = 0;
            this.gboxRevenue.TabStop = false;
            this.gboxRevenue.Text = "Revenue Generated";
            // 
            // txtClassBRev
            // 
            this.txtClassBRev.Location = new System.Drawing.Point(115, 65);
            this.txtClassBRev.Name = "txtClassBRev";
            this.txtClassBRev.ReadOnly = true;
            this.txtClassBRev.Size = new System.Drawing.Size(120, 20);
            this.txtClassBRev.TabIndex = 7;
            // 
            // txtClassCRev
            // 
            this.txtClassCRev.Location = new System.Drawing.Point(115, 107);
            this.txtClassCRev.Name = "txtClassCRev";
            this.txtClassCRev.ReadOnly = true;
            this.txtClassCRev.Size = new System.Drawing.Size(120, 20);
            this.txtClassCRev.TabIndex = 8;
            // 
            // txtTotalRev
            // 
            this.txtTotalRev.Location = new System.Drawing.Point(115, 151);
            this.txtTotalRev.Name = "txtTotalRev";
            this.txtTotalRev.ReadOnly = true;
            this.txtTotalRev.Size = new System.Drawing.Size(120, 20);
            this.txtTotalRev.TabIndex = 9;
            // 
            // txtClassARev
            // 
            this.txtClassARev.Location = new System.Drawing.Point(115, 25);
            this.txtClassARev.Name = "txtClassARev";
            this.txtClassARev.ReadOnly = true;
            this.txtClassARev.Size = new System.Drawing.Size(120, 20);
            this.txtClassARev.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(157, 239);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(96, 52);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate Revenue";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(259, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 52);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(355, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formStadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 330);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gboxRevenue);
            this.Controls.Add(this.gboxTicketsSold);
            this.Name = "formStadiumSeating";
            this.Text = "Stadium Seating";
            this.gboxTicketsSold.ResumeLayout(false);
            this.gboxTicketsSold.PerformLayout();
            this.gboxRevenue.ResumeLayout(false);
            this.gboxRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTicketsSold;
        private System.Windows.Forms.TextBox txtClassAQuantity;
        private System.Windows.Forms.TextBox txtClassBQuantity;
        private System.Windows.Forms.TextBox txtClassCQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxRevenue;
        private System.Windows.Forms.TextBox txtClassBRev;
        private System.Windows.Forms.TextBox txtClassCRev;
        private System.Windows.Forms.TextBox txtTotalRev;
        private System.Windows.Forms.TextBox txtClassARev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

