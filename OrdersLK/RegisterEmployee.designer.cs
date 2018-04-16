namespace OrdersLK
{
    partial class RegisterEmployee
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
            this.dobirth = new System.Windows.Forms.DateTimePicker();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.contactnum = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regdate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.depidcombo = new System.Windows.Forms.ComboBox();
            this.jobrolecombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dobirth);
            this.groupBox1.Controls.Add(this.genderCombo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.nic);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.contactnum);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(229, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // dobirth
            // 
            this.dobirth.Location = new System.Drawing.Point(146, 140);
            this.dobirth.Name = "dobirth";
            this.dobirth.Size = new System.Drawing.Size(200, 20);
            this.dobirth.TabIndex = 20;
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCombo.Location = new System.Drawing.Point(146, 106);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(205, 21);
            this.genderCombo.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Gender";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(146, 73);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(205, 20);
            this.lname.TabIndex = 17;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Last Name";
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(146, 338);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(205, 20);
            this.nic.TabIndex = 13;
            this.nic.TextChanged += new System.EventHandler(this.nic_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "NIC Number";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(146, 263);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(205, 57);
            this.address.TabIndex = 11;
            this.address.Text = "";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(146, 221);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(205, 20);
            this.email.TabIndex = 8;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // contactnum
            // 
            this.contactnum.Location = new System.Drawing.Point(146, 182);
            this.contactnum.Name = "contactnum";
            this.contactnum.Size = new System.Drawing.Size(205, 20);
            this.contactnum.TabIndex = 7;
            this.contactnum.TextChanged += new System.EventHandler(this.contactnum_TextChanged);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(146, 37);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(205, 20);
            this.fname.TabIndex = 6;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First  Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact No.";
            // 
            // regdate
            // 
            this.regdate.Location = new System.Drawing.Point(181, 175);
            this.regdate.Name = "regdate";
            this.regdate.Size = new System.Drawing.Size(200, 20);
            this.regdate.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Date of Regisration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordtxt);
            this.groupBox2.Controls.Add(this.usernametxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.depidcombo);
            this.groupBox2.Controls.Add(this.jobrolecombo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.regdate);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtsalary);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(642, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Information";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(181, 268);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(200, 20);
            this.passwordtxt.TabIndex = 20;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(181, 224);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(200, 20);
            this.usernametxt.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Username";
            // 
            // depidcombo
            // 
            this.depidcombo.FormattingEnabled = true;
            this.depidcombo.Location = new System.Drawing.Point(181, 40);
            this.depidcombo.Name = "depidcombo";
            this.depidcombo.Size = new System.Drawing.Size(200, 21);
            this.depidcombo.TabIndex = 16;
            // 
            // jobrolecombo
            // 
            this.jobrolecombo.FormattingEnabled = true;
            this.jobrolecombo.Items.AddRange(new object[] {
            "Manager",
            "Salesman",
            "Deliveryboy",
            "StockKeeper"});
            this.jobrolecombo.Location = new System.Drawing.Point(181, 127);
            this.jobrolecombo.Name = "jobrolecombo";
            this.jobrolecombo.Size = new System.Drawing.Size(200, 21);
            this.jobrolecombo.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Job Role";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(181, 85);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(200, 20);
            this.txtsalary.TabIndex = 7;
            this.txtsalary.TextChanged += new System.EventHandler(this.txtsalary_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Basic Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Department ID";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(887, 435);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(154, 31);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add Employee";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaaaa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1184, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 48);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaback;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Location = new System.Drawing.Point(1120, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 48);
            this.backbtn.TabIndex = 0;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::OrdersLK.Properties.Resources.orders;
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 57);
            this.label11.TabIndex = 3;
            this.label11.Tag = "                    ";
            this.label11.Text = "           ";
            // 
            // RegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterEmployee";
            this.Load += new System.EventHandler(this.RegisterEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox contactnum;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox jobrolecombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DateTimePicker regdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox depidcombo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dobirth;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}