namespace MikeCrabtree_Assignment3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSelect = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductDetails = new System.Windows.Forms.TextBox();
            this.lboxProductList = new System.Windows.Forms.ListBox();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.calDelivery = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxShipping = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtShippingCost = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxShoppingCart = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tabCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSelect);
            this.tabControl1.Controls.Add(this.tabCart);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSelect
            // 
            this.tabSelect.Controls.Add(this.label8);
            this.tabSelect.Controls.Add(this.label7);
            this.tabSelect.Controls.Add(this.txtProductDetails);
            this.tabSelect.Controls.Add(this.lboxProductList);
            this.tabSelect.Location = new System.Drawing.Point(4, 22);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelect.Size = new System.Drawing.Size(686, 383);
            this.tabSelect.TabIndex = 0;
            this.tabSelect.Text = "Select Products:";
            this.tabSelect.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Product Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Double click an item to add it to your shopping cart.";
            // 
            // txtProductDetails
            // 
            this.txtProductDetails.Location = new System.Drawing.Point(334, 39);
            this.txtProductDetails.Multiline = true;
            this.txtProductDetails.Name = "txtProductDetails";
            this.txtProductDetails.ReadOnly = true;
            this.txtProductDetails.Size = new System.Drawing.Size(313, 95);
            this.txtProductDetails.TabIndex = 2;
            // 
            // lboxProductList
            // 
            this.lboxProductList.FormattingEnabled = true;
            this.lboxProductList.Location = new System.Drawing.Point(47, 39);
            this.lboxProductList.Name = "lboxProductList";
            this.lboxProductList.Size = new System.Drawing.Size(222, 95);
            this.lboxProductList.TabIndex = 0;
            this.lboxProductList.SelectedIndexChanged += new System.EventHandler(this.lboxProductList_SelectedIndexChanged);
            this.lboxProductList.DoubleClick += new System.EventHandler(this.lboxProductList_DoubleClick);
            // 
            // tabCart
            // 
            this.tabCart.Controls.Add(this.label9);
            this.tabCart.Controls.Add(this.lblDelivery);
            this.tabCart.Controls.Add(this.calDelivery);
            this.tabCart.Controls.Add(this.label6);
            this.tabCart.Controls.Add(this.cboxShipping);
            this.tabCart.Controls.Add(this.btnReset);
            this.tabCart.Controls.Add(this.btnPurchase);
            this.tabCart.Controls.Add(this.txtTotal);
            this.tabCart.Controls.Add(this.txtShippingCost);
            this.tabCart.Controls.Add(this.txtDiscount);
            this.tabCart.Controls.Add(this.txtTax);
            this.tabCart.Controls.Add(this.txtSubtotal);
            this.tabCart.Controls.Add(this.label5);
            this.tabCart.Controls.Add(this.label4);
            this.tabCart.Controls.Add(this.label3);
            this.tabCart.Controls.Add(this.label2);
            this.tabCart.Controls.Add(this.label1);
            this.tabCart.Controls.Add(this.lboxShoppingCart);
            this.tabCart.Location = new System.Drawing.Point(4, 22);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(686, 383);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "My Shopping Cart:";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Double click an item to remove it.";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(399, 236);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(0, 13);
            this.lblDelivery.TabIndex = 16;
            // 
            // calDelivery
            // 
            this.calDelivery.Location = new System.Drawing.Point(402, 9);
            this.calDelivery.Name = "calDelivery";
            this.calDelivery.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Shipping Option:";
            // 
            // cboxShipping
            // 
            this.cboxShipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxShipping.FormattingEnabled = true;
            this.cboxShipping.Location = new System.Drawing.Point(451, 199);
            this.cboxShipping.Name = "cboxShipping";
            this.cboxShipping.Size = new System.Drawing.Size(121, 21);
            this.cboxShipping.TabIndex = 13;
            this.cboxShipping.SelectedIndexChanged += new System.EventHandler(this.cboxShipping_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(361, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(539, 341);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(123, 23);
            this.btnPurchase.TabIndex = 11;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(151, 324);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // txtShippingCost
            // 
            this.txtShippingCost.Location = new System.Drawing.Point(151, 275);
            this.txtShippingCost.Name = "txtShippingCost";
            this.txtShippingCost.ReadOnly = true;
            this.txtShippingCost.Size = new System.Drawing.Size(100, 20);
            this.txtShippingCost.TabIndex = 9;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(151, 229);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 8;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(151, 183);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(151, 139);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shipping Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sales Tax (6%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subtotal:";
            // 
            // lboxShoppingCart
            // 
            this.lboxShoppingCart.FormattingEnabled = true;
            this.lboxShoppingCart.Location = new System.Drawing.Point(41, 9);
            this.lboxShoppingCart.Name = "lboxShoppingCart";
            this.lboxShoppingCart.Size = new System.Drawing.Size(203, 108);
            this.lboxShoppingCart.TabIndex = 0;
            this.lboxShoppingCart.DoubleClick += new System.EventHandler(this.lboxShoppingCart_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabSelect.ResumeLayout(false);
            this.tabSelect.PerformLayout();
            this.tabCart.ResumeLayout(false);
            this.tabCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSelect;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.ListBox lboxProductList;
        private System.Windows.Forms.ListBox lboxShoppingCart;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtShippingCost;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxShipping;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.MonthCalendar calDelivery;
        private System.Windows.Forms.TextBox txtProductDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

