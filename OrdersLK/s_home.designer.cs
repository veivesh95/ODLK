﻿namespace OrdersLK
{
    partial class s_home
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
            this.orderPendingTable = new System.Windows.Forms.DataGridView();
            this.buttonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthPicker = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderPendingTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderPendingTable
            // 
            this.orderPendingTable.AllowUserToAddRows = false;
            this.orderPendingTable.AllowUserToDeleteRows = false;
            this.orderPendingTable.BackgroundColor = System.Drawing.Color.White;
            this.orderPendingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderPendingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttonColumn});
            this.orderPendingTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPendingTable.Location = new System.Drawing.Point(3, 3);
            this.orderPendingTable.Name = "orderPendingTable";
            this.orderPendingTable.ReadOnly = true;
            this.orderPendingTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderPendingTable.Size = new System.Drawing.Size(802, 407);
            this.orderPendingTable.TabIndex = 0;
            this.orderPendingTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderPendingTable_CellContentClick);
            // 
            // buttonColumn
            // 
            this.buttonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumn.HeaderText = "Cancel Order";
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.ReadOnly = true;
            this.buttonColumn.Width = 75;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(882, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(349, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(38, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 439);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.orderPendingTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ordersTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            this.ordersTable.BackgroundColor = System.Drawing.Color.White;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTable.Location = new System.Drawing.Point(3, 3);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.ReadOnly = true;
            this.ordersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersTable.Size = new System.Drawing.Size(802, 407);
            this.ordersTable.TabIndex = 0;
            this.ordersTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ordersTable_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchQuery);
            this.groupBox1.Controls.Add(this.comboCustomer);
            this.groupBox1.Location = new System.Drawing.Point(882, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Processing",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(161, 139);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(149, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbStatus_MouseClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 139);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Search by Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search by Customer : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Order ID :";
            // 
            // searchQuery
            // 
            this.searchQuery.Location = new System.Drawing.Point(161, 41);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(149, 20);
            this.searchQuery.TabIndex = 0;
            this.searchQuery.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchQuery_MouseClick);
            this.searchQuery.TextChanged += new System.EventHandler(this.searchQuery_TextChanged);
            // 
            // comboCustomer
            // 
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(161, 89);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(149, 21);
            this.comboCustomer.TabIndex = 3;
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            this.comboCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboCustomer_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 7;
            // 
            // homebtn
            // 
            this.homebtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaaaa;
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtn.Location = new System.Drawing.Point(1190, 12);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(57, 48);
            this.homebtn.TabIndex = 4;
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaback;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Location = new System.Drawing.Point(1128, 11);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 48);
            this.backbtn.TabIndex = 0;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.monthPicker);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Location = new System.Drawing.Point(882, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pick a Month :";
            // 
            // monthPicker
            // 
            this.monthPicker.CustomFormat = "MMMM/yyyy";
            this.monthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPicker.Location = new System.Drawing.Point(152, 31);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(142, 20);
            this.monthPicker.TabIndex = 4;
            this.monthPicker.ValueChanged += new System.EventHandler(this.monthPicker_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Cyan;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(55, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(239, 24);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::OrdersLK.Properties.Resources.orders;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 57);
            this.label4.TabIndex = 3;
            this.label4.Tag = "                    ";
            this.label4.Text = "           ";
            // 
            // s_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabControl1);
            this.Name = "s_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Home";
            this.Load += new System.EventHandler(this.s_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderPendingTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderPendingTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn buttonColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker monthPicker;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label3;
    }
}