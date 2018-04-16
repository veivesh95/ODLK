namespace OrdersLK
{
    partial class Statementpage
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
            this.backbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfbtn = new System.Windows.Forms.Button();
            this.paymentsdgv = new System.Windows.Forms.DataGridView();
            this.fromdatepicker = new System.Windows.Forms.DateTimePicker();
            this.todatepicker = new System.Windows.Forms.DateTimePicker();
            this.paycatergorycombo = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsdgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaback;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Location = new System.Drawing.Point(1122, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 48);
            this.backbtn.TabIndex = 1;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaaaa;
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtn.Location = new System.Drawing.Point(1185, 12);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(57, 48);
            this.homebtn.TabIndex = 0;
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Income Statement";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // pdfbtn
            // 
            this.pdfbtn.BackColor = System.Drawing.Color.Cyan;
            this.pdfbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfbtn.Location = new System.Drawing.Point(64, 359);
            this.pdfbtn.Name = "pdfbtn";
            this.pdfbtn.Size = new System.Drawing.Size(200, 41);
            this.pdfbtn.TabIndex = 18;
            this.pdfbtn.Text = "Export PDF";
            this.pdfbtn.UseVisualStyleBackColor = false;
            this.pdfbtn.Click += new System.EventHandler(this.pdfbtn_Click);
            // 
            // paymentsdgv
            // 
            this.paymentsdgv.BackgroundColor = System.Drawing.Color.White;
            this.paymentsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsdgv.Location = new System.Drawing.Point(331, 137);
            this.paymentsdgv.Name = "paymentsdgv";
            this.paymentsdgv.Size = new System.Drawing.Size(885, 348);
            this.paymentsdgv.TabIndex = 19;
            // 
            // fromdatepicker
            // 
            this.fromdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdatepicker.Location = new System.Drawing.Point(381, 103);
            this.fromdatepicker.Name = "fromdatepicker";
            this.fromdatepicker.Size = new System.Drawing.Size(212, 20);
            this.fromdatepicker.TabIndex = 20;
            this.fromdatepicker.ValueChanged += new System.EventHandler(this.fromdatepicker_ValueChanged);
            // 
            // todatepicker
            // 
            this.todatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todatepicker.Location = new System.Drawing.Point(652, 103);
            this.todatepicker.Name = "todatepicker";
            this.todatepicker.Size = new System.Drawing.Size(207, 20);
            this.todatepicker.TabIndex = 21;
            this.todatepicker.ValueChanged += new System.EventHandler(this.todatepicker_ValueChanged);
            // 
            // paycatergorycombo
            // 
            this.paycatergorycombo.FormattingEnabled = true;
            this.paycatergorycombo.Items.AddRange(new object[] {
            "ALL",
            "PettyCash",
            "Supplier",
            "Delivery",
            "Salary"});
            this.paycatergorycombo.Location = new System.Drawing.Point(1056, 103);
            this.paycatergorycombo.Name = "paycatergorycombo";
            this.paycatergorycombo.Size = new System.Drawing.Size(160, 21);
            this.paycatergorycombo.TabIndex = 22;
            this.paycatergorycombo.SelectedIndexChanged += new System.EventHandler(this.paycatergorycombo_SelectedIndexChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Cyan;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(878, 103);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(111, 23);
            this.searchbtn.TabIndex = 23;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::OrdersLK.Properties.Resources.orders;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 57);
            this.label3.TabIndex = 3;
            this.label3.Tag = "                    ";
            this.label3.Text = "           ";
            // 
            // Statementpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.paycatergorycombo);
            this.Controls.Add(this.todatepicker);
            this.Controls.Add(this.fromdatepicker);
            this.Controls.Add(this.paymentsdgv);
            this.Controls.Add(this.pdfbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statementpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statementpage";
            this.Load += new System.EventHandler(this.Statementpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pdfbtn;
        private System.Windows.Forms.DataGridView paymentsdgv;
        private System.Windows.Forms.DateTimePicker fromdatepicker;
        private System.Windows.Forms.DateTimePicker todatepicker;
        private System.Windows.Forms.ComboBox paycatergorycombo;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}