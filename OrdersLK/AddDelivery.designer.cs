namespace OrdersLK
{
    partial class AddDelivery
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewOrdersDataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderItemGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CustomerDataGridView3 = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CitycomboBox1 = new System.Windows.Forms.ComboBox();
            this.delCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentTypecomboBox2 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cutidlabel = new System.Windows.Forms.Label();
            this.ordidlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DManCombo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdersDataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewOrdersDataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(19, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Orders";
            // 
            // ViewOrdersDataGridView1
            // 
            this.ViewOrdersDataGridView1.AllowUserToAddRows = false;
            this.ViewOrdersDataGridView1.AllowUserToDeleteRows = false;
            this.ViewOrdersDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.ViewOrdersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrdersDataGridView1.Location = new System.Drawing.Point(8, 26);
            this.ViewOrdersDataGridView1.Name = "ViewOrdersDataGridView1";
            this.ViewOrdersDataGridView1.ReadOnly = true;
            this.ViewOrdersDataGridView1.Size = new System.Drawing.Size(640, 396);
            this.ViewOrdersDataGridView1.TabIndex = 0;
            this.ViewOrdersDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewOrdersDataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OrderItemGridView);
            this.groupBox2.Location = new System.Drawing.Point(679, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Items";
            // 
            // OrderItemGridView
            // 
            this.OrderItemGridView.AllowUserToAddRows = false;
            this.OrderItemGridView.AllowUserToDeleteRows = false;
            this.OrderItemGridView.BackgroundColor = System.Drawing.Color.White;
            this.OrderItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItemGridView.Location = new System.Drawing.Point(7, 20);
            this.OrderItemGridView.Name = "OrderItemGridView";
            this.OrderItemGridView.ReadOnly = true;
            this.OrderItemGridView.Size = new System.Drawing.Size(539, 186);
            this.OrderItemGridView.TabIndex = 0;
            this.OrderItemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CustomerDataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(679, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 204);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customers";
            // 
            // CustomerDataGridView3
            // 
            this.CustomerDataGridView3.AllowUserToAddRows = false;
            this.CustomerDataGridView3.AllowUserToDeleteRows = false;
            this.CustomerDataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.CustomerDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView3.Location = new System.Drawing.Point(7, 20);
            this.CustomerDataGridView3.Name = "CustomerDataGridView3";
            this.CustomerDataGridView3.ReadOnly = true;
            this.CustomerDataGridView3.Size = new System.Drawing.Size(539, 178);
            this.CustomerDataGridView3.TabIndex = 0;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(1134, 511);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "Add Delivery";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Delivery Cost:";
            // 
            // CitycomboBox1
            // 
            this.CitycomboBox1.FormattingEnabled = true;
            this.CitycomboBox1.Items.AddRange(new object[] {
            "Ampara",
            "Anuradhapura",
            "Badulla\t",
            "Batticaloa",
            "Colombo",
            "Galle",
            "Gampaha\t",
            "Hambantota",
            "Jaffna",
            "Kalutara\t",
            "Kandy",
            "Kegalle",
            "Kilinochchi",
            "Kurunegala",
            "Mannar",
            "Matale",
            "Matara",
            "Monaragala",
            "Mullaitivu",
            "Nuwara Eliya",
            "Polonnaruwa",
            "Puttalam",
            "Ratnapura",
            "Trincomalee",
            "Vavuniya"});
            this.CitycomboBox1.Location = new System.Drawing.Point(503, 512);
            this.CitycomboBox1.Name = "CitycomboBox1";
            this.CitycomboBox1.Size = new System.Drawing.Size(121, 21);
            this.CitycomboBox1.TabIndex = 12;
            // 
            // delCost
            // 
            this.delCost.Location = new System.Drawing.Point(330, 513);
            this.delCost.Name = "delCost";
            this.delCost.Size = new System.Drawing.Size(116, 20);
            this.delCost.TabIndex = 13;
            this.delCost.TextChanged += new System.EventHandler(this.delCost_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Delivery Type:";
            // 
            // PaymentTypecomboBox2
            // 
            this.PaymentTypecomboBox2.FormattingEnabled = true;
            this.PaymentTypecomboBox2.Items.AddRange(new object[] {
            "Cash on delivery",
            "Post"});
            this.PaymentTypecomboBox2.Location = new System.Drawing.Point(721, 512);
            this.PaymentTypecomboBox2.Name = "PaymentTypecomboBox2";
            this.PaymentTypecomboBox2.Size = new System.Drawing.Size(121, 21);
            this.PaymentTypecomboBox2.TabIndex = 15;
            this.PaymentTypecomboBox2.SelectedValueChanged += new System.EventHandler(this.PaymentTypecomboBox2_SelectedValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cutidlabel
            // 
            this.cutidlabel.AutoSize = true;
            this.cutidlabel.Location = new System.Drawing.Point(137, 516);
            this.cutidlabel.Name = "cutidlabel";
            this.cutidlabel.Size = new System.Drawing.Size(85, 13);
            this.cutidlabel.TabIndex = 16;
            this.cutidlabel.Text = "                          ";
            this.cutidlabel.Click += new System.EventHandler(this.cutidlabel_Click);
            // 
            // ordidlabel
            // 
            this.ordidlabel.AutoSize = true;
            this.ordidlabel.Location = new System.Drawing.Point(17, 516);
            this.ordidlabel.Name = "ordidlabel";
            this.ordidlabel.Size = new System.Drawing.Size(85, 13);
            this.ordidlabel.TabIndex = 17;
            this.ordidlabel.Text = "                          ";
            this.ordidlabel.Click += new System.EventHandler(this.ordidlabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Choose Delivery Man:";
            // 
            // DManCombo
            // 
            this.DManCombo.FormattingEnabled = true;
            this.DManCombo.Location = new System.Drawing.Point(980, 512);
            this.DManCombo.Name = "DManCombo";
            this.DManCombo.Size = new System.Drawing.Size(121, 21);
            this.DManCombo.TabIndex = 19;
            this.DManCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // homebtn
            // 
            this.homebtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaaaa;
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtn.Location = new System.Drawing.Point(1182, 12);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(57, 48);
            this.homebtn.TabIndex = 22;
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::OrdersLK.Properties.Resources.orders;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 57);
            this.label3.TabIndex = 21;
            this.label3.Tag = "                    ";
            this.label3.Text = "           ";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaback;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(1120, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 48);
            this.back.TabIndex = 20;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DManCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordidlabel);
            this.Controls.Add(this.cutidlabel);
            this.Controls.Add(this.PaymentTypecomboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delCost);
            this.Controls.Add(this.CitycomboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDelivery";
            this.Load += new System.EventHandler(this.AddDelivery_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdersDataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ViewOrdersDataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView OrderItemGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView CustomerDataGridView3;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CitycomboBox1;
        private System.Windows.Forms.TextBox delCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaymentTypecomboBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ordidlabel;
        private System.Windows.Forms.Label cutidlabel;
        private System.Windows.Forms.ComboBox DManCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button homebtn;
    }
}