namespace OrdersLK
{
    partial class PettyCashPage
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
            this.label3 = new System.Windows.Forms.Label();
            this.descbox = new System.Windows.Forms.TextBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.PettyCashGridView = new System.Windows.Forms.DataGridView();
            this.catergorycombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updtbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.pettcashidlabel = new System.Windows.Forms.Label();
            this.pclabel = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.ctgrycombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fromdatepicker = new System.Windows.Forms.DateTimePicker();
            this.todatepicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filterbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PettyCashGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders.lk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(142, 203);
            this.descbox.Multiline = true;
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(239, 72);
            this.descbox.TabIndex = 4;
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(142, 314);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(239, 20);
            this.amountbox.TabIndex = 5;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(142, 367);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(105, 23);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // PettyCashGridView
            // 
            this.PettyCashGridView.AllowUserToAddRows = false;
            this.PettyCashGridView.AllowUserToDeleteRows = false;
            this.PettyCashGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PettyCashGridView.BackgroundColor = System.Drawing.Color.White;
            this.PettyCashGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PettyCashGridView.Location = new System.Drawing.Point(423, 148);
            this.PettyCashGridView.Name = "PettyCashGridView";
            this.PettyCashGridView.ReadOnly = true;
            this.PettyCashGridView.Size = new System.Drawing.Size(697, 372);
            this.PettyCashGridView.TabIndex = 7;
            this.PettyCashGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PettyCashGridView_CellDoubleClick);
            // 
            // catergorycombobox
            // 
            this.catergorycombobox.FormattingEnabled = true;
            this.catergorycombobox.Items.AddRange(new object[] {
            "Food & Beverages",
            "Stationaries",
            "Bills",
            "Wages",
            "Other"});
            this.catergorycombobox.Location = new System.Drawing.Point(142, 148);
            this.catergorycombobox.Name = "catergorycombobox";
            this.catergorycombobox.Size = new System.Drawing.Size(239, 21);
            this.catergorycombobox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Catergory";
            // 
            // updtbtn
            // 
            this.updtbtn.BackColor = System.Drawing.Color.Lime;
            this.updtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtbtn.Location = new System.Drawing.Point(142, 367);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(105, 23);
            this.updtbtn.TabIndex = 10;
            this.updtbtn.Text = "Update";
            this.updtbtn.UseVisualStyleBackColor = false;
            this.updtbtn.Click += new System.EventHandler(this.updtbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.Red;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(276, 367);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(105, 23);
            this.delbtn.TabIndex = 11;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(180, 409);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(156, 23);
            this.cancelbtn.TabIndex = 12;
            this.cancelbtn.Text = "Cancel Editing";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // pettcashidlabel
            // 
            this.pettcashidlabel.AutoSize = true;
            this.pettcashidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pettcashidlabel.Location = new System.Drawing.Point(280, 99);
            this.pettcashidlabel.Name = "pettcashidlabel";
            this.pettcashidlabel.Size = new System.Drawing.Size(95, 24);
            this.pettcashidlabel.TabIndex = 13;
            this.pettcashidlabel.Text = "                 ";
            // 
            // pclabel
            // 
            this.pclabel.AutoSize = true;
            this.pclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pclabel.Location = new System.Drawing.Point(24, 99);
            this.pclabel.Name = "pclabel";
            this.pclabel.Size = new System.Drawing.Size(118, 24);
            this.pclabel.TabIndex = 14;
            this.pclabel.Text = "Petty Cash Id";
            // 
            // homebtn
            // 
            this.homebtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaaaa;
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtn.Location = new System.Drawing.Point(1184, 12);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(57, 48);
            this.homebtn.TabIndex = 15;
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click_1);
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaback;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Location = new System.Drawing.Point(1121, 13);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 48);
            this.backbtn.TabIndex = 16;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // ctgrycombobox
            // 
            this.ctgrycombobox.FormattingEnabled = true;
            this.ctgrycombobox.Items.AddRange(new object[] {
            "ALL"});
            this.ctgrycombobox.Location = new System.Drawing.Point(423, 106);
            this.ctgrycombobox.Name = "ctgrycombobox";
            this.ctgrycombobox.Size = new System.Drawing.Size(172, 21);
            this.ctgrycombobox.TabIndex = 17;
            this.ctgrycombobox.SelectedIndexChanged += new System.EventHandler(this.ctgrycombobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Search By Catergory";
            // 
            // fromdatepicker
            // 
            this.fromdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdatepicker.Location = new System.Drawing.Point(622, 107);
            this.fromdatepicker.MaxDate = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            this.fromdatepicker.Name = "fromdatepicker";
            this.fromdatepicker.Size = new System.Drawing.Size(112, 20);
            this.fromdatepicker.TabIndex = 19;
            this.fromdatepicker.Value = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            // 
            // todatepicker
            // 
            this.todatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todatepicker.Location = new System.Drawing.Point(758, 107);
            this.todatepicker.MaxDate = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            this.todatepicker.Name = "todatepicker";
            this.todatepicker.Size = new System.Drawing.Size(112, 20);
            this.todatepicker.TabIndex = 20;
            this.todatepicker.Value = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            this.todatepicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(763, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "To";
            // 
            // filterbtn
            // 
            this.filterbtn.BackColor = System.Drawing.Color.Cyan;
            this.filterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterbtn.Location = new System.Drawing.Point(900, 107);
            this.filterbtn.Name = "filterbtn";
            this.filterbtn.Size = new System.Drawing.Size(87, 23);
            this.filterbtn.TabIndex = 23;
            this.filterbtn.Text = "Filter";
            this.filterbtn.UseVisualStyleBackColor = false;
            this.filterbtn.Click += new System.EventHandler(this.filterbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::OrdersLK.Properties.Resources.orders;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 57);
            this.label8.TabIndex = 17;
            this.label8.Tag = "                    ";
            this.label8.Text = "           ";
            // 
            // PettyCashPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filterbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.todatepicker);
            this.Controls.Add(this.fromdatepicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctgrycombobox);
            this.Controls.Add(this.pclabel);
            this.Controls.Add(this.pettcashidlabel);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.catergorycombobox);
            this.Controls.Add(this.PettyCashGridView);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updtbtn);
            this.Controls.Add(this.addbtn);
            this.Name = "PettyCashPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PettyCashPage";
            this.Load += new System.EventHandler(this.PettyCashPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PettyCashGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView PettyCashGridView;
        private System.Windows.Forms.ComboBox catergorycombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label pettcashidlabel;
        private System.Windows.Forms.Label pclabel;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox ctgrycombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fromdatepicker;
        private System.Windows.Forms.DateTimePicker todatepicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button filterbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}