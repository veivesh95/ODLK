﻿namespace OrdersLK
{
    partial class s_add
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.comboCustomerName = new System.Windows.Forms.ComboBox();
            this.comboAgent = new System.Windows.Forms.ComboBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboItems = new System.Windows.Forms.ComboBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQuantityTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartTable = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveCart = new System.Windows.Forms.Button();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddNewCustomer);
            this.groupBox3.Controls.Add(this.comboCustomerName);
            this.groupBox3.Controls.Add(this.comboAgent);
            this.groupBox3.Controls.Add(this.txtInvoiceNo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(42, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1162, 87);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.Location = new System.Drawing.Point(341, 22);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(23, 23);
            this.btnAddNewCustomer.TabIndex = 22;
            this.btnAddNewCustomer.Text = "+";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboCustomerName
            // 
            this.comboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomerName.FormattingEnabled = true;
            this.comboCustomerName.Location = new System.Drawing.Point(80, 22);
            this.comboCustomerName.Name = "comboCustomerName";
            this.comboCustomerName.Size = new System.Drawing.Size(246, 21);
            this.comboCustomerName.TabIndex = 21;
            this.comboCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboAgent
            // 
            this.comboAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgent.FormattingEnabled = true;
            this.comboAgent.Location = new System.Drawing.Point(80, 53);
            this.comboAgent.Name = "comboAgent";
            this.comboAgent.Size = new System.Drawing.Size(132, 21);
            this.comboAgent.TabIndex = 20;
            this.comboAgent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(1005, 49);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(132, 20);
            this.txtInvoiceNo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1071, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "current_date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(988, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ordered Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No. :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboItems);
            this.groupBox1.Controls.Add(this.txtAvailable);
            this.groupBox1.Controls.Add(this.txtMRP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 130);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // comboItems
            // 
            this.comboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboItems.FormattingEnabled = true;
            this.comboItems.Location = new System.Drawing.Point(77, 17);
            this.comboItems.Name = "comboItems";
            this.comboItems.Size = new System.Drawing.Size(197, 21);
            this.comboItems.TabIndex = 22;
            this.comboItems.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(137, 94);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(137, 20);
            this.txtAvailable.TabIndex = 13;
            // 
            // txtMRP
            // 
            this.txtMRP.Location = new System.Drawing.Point(137, 55);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.ReadOnly = true;
            this.txtMRP.Size = new System.Drawing.Size(137, 20);
            this.txtMRP.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max. Retail Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQuantityTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 103);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // lblQuantityTotal
            // 
            this.lblQuantityTotal.AutoSize = true;
            this.lblQuantityTotal.Location = new System.Drawing.Point(141, 58);
            this.lblQuantityTotal.Name = "lblQuantityTotal";
            this.lblQuantityTotal.Size = new System.Drawing.Size(13, 13);
            this.lblQuantityTotal.TabIndex = 17;
            this.lblQuantityTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(137, 17);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(137, 20);
            this.txtQuantity.TabIndex = 15;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGrandTotal);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnConfirmOrder);
            this.groupBox4.Location = new System.Drawing.Point(937, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 326);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(122, 117);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(138, 20);
            this.txtGrandTotal.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Grand Total :";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(39, 162);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(221, 64);
            this.btnConfirmOrder.TabIndex = 28;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartTable);
            this.panel1.Location = new System.Drawing.Point(42, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 326);
            this.panel1.TabIndex = 32;
            // 
            // cartTable
            // 
            this.cartTable.AllowUserToDeleteRows = false;
            this.cartTable.BackgroundColor = System.Drawing.Color.White;
            this.cartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Product,
            this.UnitPrice,
            this.Quantity,
            this.SubTotal});
            this.cartTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartTable.Location = new System.Drawing.Point(0, 0);
            this.cartTable.Name = "cartTable";
            this.cartTable.ReadOnly = true;
            this.cartTable.Size = new System.Drawing.Size(551, 326);
            this.cartTable.TabIndex = 0;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnRemoveCart
            // 
            this.btnRemoveCart.BackColor = System.Drawing.Color.Red;
            this.btnRemoveCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCart.Location = new System.Drawing.Point(6, 280);
            this.btnRemoveCart.Name = "btnRemoveCart";
            this.btnRemoveCart.Size = new System.Drawing.Size(119, 30);
            this.btnRemoveCart.TabIndex = 34;
            this.btnRemoveCart.Text = "Remove from cart";
            this.btnRemoveCart.UseVisualStyleBackColor = false;
            this.btnRemoveCart.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.Lime;
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.Location = new System.Drawing.Point(181, 280);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(119, 30);
            this.btnAddCart.TabIndex = 33;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 69);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(1168, 23);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 4;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::OrdersLK.Properties.Resources.orders;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 57);
            this.label10.TabIndex = 3;
            this.label10.Tag = "                    ";
            this.label10.Text = "           ";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(1087, 23);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.btnRemoveCart);
            this.groupBox5.Controls.Add(this.btnAddCart);
            this.groupBox5.Location = new System.Drawing.Point(613, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 326);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // s_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "s_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Sales Order";
            this.Load += new System.EventHandler(this.s_add_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboCustomerName;
        private System.Windows.Forms.ComboBox comboAgent;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboItems;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblQuantityTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView cartTable;
        private System.Windows.Forms.Button btnRemoveCart;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}