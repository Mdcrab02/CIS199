namespace MikeCrabtree_Assignment2
{
    partial class Form1
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
            this.tboxTshirt = new System.Windows.Forms.TabControl();
            this.tabSell = new System.Windows.Forms.TabPage();
            this.btnExecuteSale = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaleAmount = new System.Windows.Forms.TextBox();
            this.txtSaleQuantity = new System.Windows.Forms.TextBox();
            this.cboxSell = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.btnExecuteOrder = new System.Windows.Forms.Button();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxOrder = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInvSmall = new System.Windows.Forms.TextBox();
            this.txtInvMed = new System.Windows.Forms.TextBox();
            this.txtInvLar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tboxTshirt.SuspendLayout();
            this.tabSell.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxTshirt
            // 
            this.tboxTshirt.Controls.Add(this.tabSell);
            this.tboxTshirt.Controls.Add(this.tabOrder);
            this.tboxTshirt.Location = new System.Drawing.Point(12, 12);
            this.tboxTshirt.Name = "tboxTshirt";
            this.tboxTshirt.SelectedIndex = 0;
            this.tboxTshirt.Size = new System.Drawing.Size(233, 291);
            this.tboxTshirt.TabIndex = 0;
            // 
            // tabSell
            // 
            this.tabSell.Controls.Add(this.btnExecuteSale);
            this.tabSell.Controls.Add(this.lblAmount);
            this.tabSell.Controls.Add(this.label2);
            this.tabSell.Controls.Add(this.txtSaleAmount);
            this.tabSell.Controls.Add(this.txtSaleQuantity);
            this.tabSell.Controls.Add(this.cboxSell);
            this.tabSell.Controls.Add(this.label1);
            this.tabSell.Location = new System.Drawing.Point(4, 22);
            this.tabSell.Name = "tabSell";
            this.tabSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabSell.Size = new System.Drawing.Size(225, 265);
            this.tabSell.TabIndex = 0;
            this.tabSell.Text = "Sell T-shirts";
            this.tabSell.UseVisualStyleBackColor = true;
            // 
            // btnExecuteSale
            // 
            this.btnExecuteSale.Location = new System.Drawing.Point(45, 216);
            this.btnExecuteSale.Name = "btnExecuteSale";
            this.btnExecuteSale.Size = new System.Drawing.Size(96, 23);
            this.btnExecuteSale.TabIndex = 3;
            this.btnExecuteSale.Text = "Execute Sale";
            this.btnExecuteSale.UseVisualStyleBackColor = true;
            this.btnExecuteSale.Click += new System.EventHandler(this.btnExecuteSale_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(17, 156);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Sale Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale Quantity";
            // 
            // txtSaleAmount
            // 
            this.txtSaleAmount.Location = new System.Drawing.Point(20, 172);
            this.txtSaleAmount.Name = "txtSaleAmount";
            this.txtSaleAmount.ReadOnly = true;
            this.txtSaleAmount.Size = new System.Drawing.Size(100, 20);
            this.txtSaleAmount.TabIndex = 1;
            // 
            // txtSaleQuantity
            // 
            this.txtSaleQuantity.Location = new System.Drawing.Point(20, 105);
            this.txtSaleQuantity.Name = "txtSaleQuantity";
            this.txtSaleQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtSaleQuantity.TabIndex = 2;
            // 
            // cboxSell
            // 
            this.cboxSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSell.FormattingEnabled = true;
            this.cboxSell.Items.AddRange(new object[] {
            "Red T-Shirt (S) $18.99",
            "Red T-Shirt (M) $19.99",
            "Red T-Shirt (L) $20.99"});
            this.cboxSell.Location = new System.Drawing.Point(20, 41);
            this.cboxSell.Name = "cboxSell";
            this.cboxSell.Size = new System.Drawing.Size(163, 21);
            this.cboxSell.TabIndex = 1;
            this.cboxSell.SelectedIndexChanged += new System.EventHandler(this.cboxSell_SelectedIndexChanged);
            this.cboxSell.Click += new System.EventHandler(this.cboxSell_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a T-shirt:";
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.btnExecuteOrder);
            this.tabOrder.Controls.Add(this.txtOrderAmount);
            this.tabOrder.Controls.Add(this.label9);
            this.tabOrder.Controls.Add(this.txtOrderQuantity);
            this.tabOrder.Controls.Add(this.label8);
            this.tabOrder.Controls.Add(this.cboxOrder);
            this.tabOrder.Controls.Add(this.label7);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(225, 265);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "Order T-shirts";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // btnExecuteOrder
            // 
            this.btnExecuteOrder.Location = new System.Drawing.Point(41, 214);
            this.btnExecuteOrder.Name = "btnExecuteOrder";
            this.btnExecuteOrder.Size = new System.Drawing.Size(100, 23);
            this.btnExecuteOrder.TabIndex = 6;
            this.btnExecuteOrder.Text = "Execute Order";
            this.btnExecuteOrder.UseVisualStyleBackColor = true;
            this.btnExecuteOrder.Click += new System.EventHandler(this.btnExecuteOrder_Click);
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(20, 172);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.ReadOnly = true;
            this.txtOrderAmount.Size = new System.Drawing.Size(100, 20);
            this.txtOrderAmount.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Order Amount:";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(23, 105);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtOrderQuantity.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Order Quantity:";
            // 
            // cboxOrder
            // 
            this.cboxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOrder.FormattingEnabled = true;
            this.cboxOrder.Items.AddRange(new object[] {
            "Red T-Shirt (S) $15.99",
            "Red T-Shirt (M) $16.99",
            "Red T-Shirt (L) $17.99"});
            this.cboxOrder.Location = new System.Drawing.Point(23, 41);
            this.cboxOrder.Name = "cboxOrder";
            this.cboxOrder.Size = new System.Drawing.Size(154, 21);
            this.cboxOrder.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select a T-shirt";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(39, 331);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Transaction";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInvSmall);
            this.groupBox1.Controls.Add(this.txtInvMed);
            this.groupBox1.Controls.Add(this.txtInvLar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(261, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "T-shirt Inventory";
            // 
            // txtInvSmall
            // 
            this.txtInvSmall.Location = new System.Drawing.Point(150, 32);
            this.txtInvSmall.Name = "txtInvSmall";
            this.txtInvSmall.ReadOnly = true;
            this.txtInvSmall.Size = new System.Drawing.Size(100, 20);
            this.txtInvSmall.TabIndex = 3;
            // 
            // txtInvMed
            // 
            this.txtInvMed.Location = new System.Drawing.Point(150, 80);
            this.txtInvMed.Name = "txtInvMed";
            this.txtInvMed.ReadOnly = true;
            this.txtInvMed.Size = new System.Drawing.Size(100, 20);
            this.txtInvMed.TabIndex = 4;
            // 
            // txtInvLar
            // 
            this.txtInvLar.Location = new System.Drawing.Point(150, 126);
            this.txtInvLar.Name = "txtInvLar";
            this.txtInvLar.ReadOnly = true;
            this.txtInvLar.Size = new System.Drawing.Size(100, 20);
            this.txtInvLar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Red T-shirt (L)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Red T-shirt (M)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Red T-shirt (S)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Cash:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(372, 334);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(139, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 385);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tboxTshirt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tboxTshirt.ResumeLayout(false);
            this.tabSell.ResumeLayout(false);
            this.tabSell.PerformLayout();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tboxTshirt;
        private System.Windows.Forms.TabPage tabSell;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaleQuantity;
        private System.Windows.Forms.ComboBox cboxSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecuteSale;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtSaleAmount;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvSmall;
        private System.Windows.Forms.TextBox txtInvMed;
        private System.Windows.Forms.TextBox txtInvLar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExecuteOrder;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxOrder;
        private System.Windows.Forms.Label label7;
    }
}

