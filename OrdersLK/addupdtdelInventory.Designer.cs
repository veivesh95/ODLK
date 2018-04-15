namespace OrdersLK
{
    partial class AddInventory
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
            this.productdgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productidlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.catergorycombobox = new System.Windows.Forms.ComboBox();
            this.productnamebox = new System.Windows.Forms.TextBox();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.unitpricebox = new System.Windows.Forms.TextBox();
            this.sellingpricebox = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.supcombobox = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.newcatergortbtn = new System.Windows.Forms.LinkLabel();
            this.updtbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productdgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productdgv
            // 
            this.productdgv.BackgroundColor = System.Drawing.Color.White;
            this.productdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdgv.Location = new System.Drawing.Point(374, 87);
            this.productdgv.Name = "productdgv";
            this.productdgv.Size = new System.Drawing.Size(787, 445);
            this.productdgv.TabIndex = 0;
            this.productdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productdgv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catergory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit Price";
            // 
            // productidlbl
            // 
            this.productidlbl.AutoSize = true;
            this.productidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidlbl.Location = new System.Drawing.Point(137, 151);
            this.productidlbl.Name = "productidlbl";
            this.productidlbl.Size = new System.Drawing.Size(64, 16);
            this.productidlbl.TabIndex = 5;
            this.productidlbl.Text = "productid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Selling Price";
            // 
            // catergorycombobox
            // 
            this.catergorycombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catergorycombobox.FormattingEnabled = true;
            this.catergorycombobox.Location = new System.Drawing.Point(140, 87);
            this.catergorycombobox.Name = "catergorycombobox";
            this.catergorycombobox.Size = new System.Drawing.Size(183, 24);
            this.catergorycombobox.TabIndex = 8;
            // 
            // productnamebox
            // 
            this.productnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamebox.Location = new System.Drawing.Point(140, 194);
            this.productnamebox.Name = "productnamebox";
            this.productnamebox.Size = new System.Drawing.Size(183, 22);
            this.productnamebox.TabIndex = 9;
            // 
            // quantitybox
            // 
            this.quantitybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitybox.Location = new System.Drawing.Point(140, 238);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(183, 22);
            this.quantitybox.TabIndex = 10;
            // 
            // unitpricebox
            // 
            this.unitpricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitpricebox.Location = new System.Drawing.Point(140, 280);
            this.unitpricebox.Name = "unitpricebox";
            this.unitpricebox.Size = new System.Drawing.Size(183, 22);
            this.unitpricebox.TabIndex = 11;
            // 
            // sellingpricebox
            // 
            this.sellingpricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingpricebox.Location = new System.Drawing.Point(140, 323);
            this.sellingpricebox.Name = "sellingpricebox";
            this.sellingpricebox.Size = new System.Drawing.Size(183, 22);
            this.sellingpricebox.TabIndex = 12;
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(140, 426);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(77, 23);
            this.addbtn.TabIndex = 15;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Supplier";
            // 
            // supcombobox
            // 
            this.supcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supcombobox.FormattingEnabled = true;
            this.supcombobox.Location = new System.Drawing.Point(140, 364);
            this.supcombobox.Name = "supcombobox";
            this.supcombobox.Size = new System.Drawing.Size(183, 24);
            this.supcombobox.TabIndex = 17;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(229, 388);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 16);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New Supplier?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // newcatergortbtn
            // 
            this.newcatergortbtn.AutoSize = true;
            this.newcatergortbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcatergortbtn.Location = new System.Drawing.Point(223, 111);
            this.newcatergortbtn.Name = "newcatergortbtn";
            this.newcatergortbtn.Size = new System.Drawing.Size(100, 16);
            this.newcatergortbtn.TabIndex = 19;
            this.newcatergortbtn.TabStop = true;
            this.newcatergortbtn.Text = "Edit Catergory?";
            this.newcatergortbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newcatergortbtn_LinkClicked);
            // 
            // updtbtn
            // 
            this.updtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtbtn.Location = new System.Drawing.Point(142, 426);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(75, 23);
            this.updtbtn.TabIndex = 20;
            this.updtbtn.Text = "Update";
            this.updtbtn.UseVisualStyleBackColor = true;
            this.updtbtn.Click += new System.EventHandler(this.updtbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(1167, 21);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 22;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(1086, 21);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 23;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(226, 426);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 24;
            this.cancelbtn.Text = "Cancel Editing";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::OrdersLK.Properties.Resources.orders;
            this.label8.Location = new System.Drawing.Point(2, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 57);
            this.label8.TabIndex = 24;
            this.label8.Tag = "                    ";
            this.label8.Text = "           ";
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.newcatergortbtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.supcombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.sellingpricebox);
            this.Controls.Add(this.unitpricebox);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.productnamebox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productidlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productdgv);
            this.Controls.Add(this.catergorycombobox);
            this.Controls.Add(this.updtbtn);
            this.Name = "AddInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addupdtdelInventory";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label productidlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox catergorycombobox;
        private System.Windows.Forms.TextBox productnamebox;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.TextBox unitpricebox;
        private System.Windows.Forms.TextBox sellingpricebox;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox supcombobox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel newcatergortbtn;
        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}