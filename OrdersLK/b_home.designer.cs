namespace OrdersLK
{
    partial class b_home
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
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_email = new System.Windows.Forms.RadioButton();
            this.radio_address = new System.Windows.Forms.RadioButton();
            this.radio_name = new System.Windows.Forms.RadioButton();
            this.radio_contact = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerTable
            // 
            this.customerTable.AllowUserToAddRows = false;
            this.customerTable.AllowUserToDeleteRows = false;
            this.customerTable.BackgroundColor = System.Drawing.Color.White;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTable.Location = new System.Drawing.Point(0, 0);
            this.customerTable.Name = "customerTable";
            this.customerTable.ReadOnly = true;
            this.customerTable.Size = new System.Drawing.Size(816, 439);
            this.customerTable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_email);
            this.groupBox1.Controls.Add(this.radio_address);
            this.groupBox1.Controls.Add(this.radio_name);
            this.groupBox1.Controls.Add(this.radio_contact);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchQuery);
            this.groupBox1.Location = new System.Drawing.Point(881, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // radio_email
            // 
            this.radio_email.AutoSize = true;
            this.radio_email.Location = new System.Drawing.Point(58, 141);
            this.radio_email.Name = "radio_email";
            this.radio_email.Size = new System.Drawing.Size(50, 17);
            this.radio_email.TabIndex = 2;
            this.radio_email.Text = "Email";
            this.radio_email.UseVisualStyleBackColor = true;
            this.radio_email.CheckedChanged += new System.EventHandler(this.radio_email_CheckedChanged);
            // 
            // radio_address
            // 
            this.radio_address.AutoSize = true;
            this.radio_address.Location = new System.Drawing.Point(208, 141);
            this.radio_address.Name = "radio_address";
            this.radio_address.Size = new System.Drawing.Size(63, 17);
            this.radio_address.TabIndex = 2;
            this.radio_address.Text = "Address";
            this.radio_address.UseVisualStyleBackColor = true;
            this.radio_address.CheckedChanged += new System.EventHandler(this.radio_address_CheckedChanged);
            // 
            // radio_name
            // 
            this.radio_name.AutoSize = true;
            this.radio_name.Location = new System.Drawing.Point(58, 95);
            this.radio_name.Name = "radio_name";
            this.radio_name.Size = new System.Drawing.Size(83, 17);
            this.radio_name.TabIndex = 2;
            this.radio_name.Text = "Buyer Name";
            this.radio_name.UseVisualStyleBackColor = true;
            this.radio_name.CheckedChanged += new System.EventHandler(this.radio_name_CheckedChanged);
            // 
            // radio_contact
            // 
            this.radio_contact.AutoSize = true;
            this.radio_contact.Location = new System.Drawing.Point(208, 95);
            this.radio_contact.Name = "radio_contact";
            this.radio_contact.Size = new System.Drawing.Size(102, 17);
            this.radio_contact.TabIndex = 2;
            this.radio_contact.Text = "Contact Number";
            this.radio_contact.UseVisualStyleBackColor = true;
            this.radio_contact.CheckedChanged += new System.EventHandler(this.radio_contact_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query :";
            // 
            // searchQuery
            // 
            this.searchQuery.Location = new System.Drawing.Point(89, 37);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(233, 20);
            this.searchQuery.TabIndex = 0;
            this.searchQuery.TextChanged += new System.EventHandler(this.searchQuery_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(881, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New Buyer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Location = new System.Drawing.Point(881, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Existing Information";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerTable);
            this.panel1.Location = new System.Drawing.Point(41, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 439);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 69);
            this.panel2.TabIndex = 5;
            // 
            // homebtn
            // 
            this.homebtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaaaa;
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtn.Location = new System.Drawing.Point(1181, 8);
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
            this.backbtn.Location = new System.Drawing.Point(1113, 8);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 48);
            this.backbtn.TabIndex = 0;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::OrdersLK.Properties.Resources.orders;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 57);
            this.label2.TabIndex = 3;
            this.label2.Tag = "                    ";
            this.label2.Text = "           ";
            // 
            // b_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "b_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buyer Home";
            this.Load += new System.EventHandler(this.b_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_email;
        private System.Windows.Forms.RadioButton radio_address;
        private System.Windows.Forms.RadioButton radio_name;
        private System.Windows.Forms.RadioButton radio_contact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homebtn;
    }
}