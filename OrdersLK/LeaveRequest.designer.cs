namespace OrdersLK
{
    partial class LeaveRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.leavedescription = new System.Windows.Forms.RichTextBox();
            this.empid = new System.Windows.Forms.TextBox();
            this.leavecategory = new System.Windows.Forms.ComboBox();
            this.leavestartdate = new System.Windows.Forms.DateTimePicker();
            this.leaveenddate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.monthcombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leaveyear = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leave Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leave End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Leave Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Leave Request Description";
            // 
            // leavedescription
            // 
            this.leavedescription.Location = new System.Drawing.Point(683, 151);
            this.leavedescription.Name = "leavedescription";
            this.leavedescription.Size = new System.Drawing.Size(284, 208);
            this.leavedescription.TabIndex = 8;
            this.leavedescription.Text = "";
            // 
            // empid
            // 
            this.empid.Enabled = false;
            this.empid.Location = new System.Drawing.Point(371, 126);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(197, 20);
            this.empid.TabIndex = 9;
            this.empid.TextChanged += new System.EventHandler(this.empid_TextChanged);
            // 
            // leavecategory
            // 
            this.leavecategory.FormattingEnabled = true;
            this.leavecategory.Location = new System.Drawing.Point(371, 172);
            this.leavecategory.Name = "leavecategory";
            this.leavecategory.Size = new System.Drawing.Size(197, 21);
            this.leavecategory.TabIndex = 12;
            // 
            // leavestartdate
            // 
            this.leavestartdate.Location = new System.Drawing.Point(371, 226);
            this.leavestartdate.Name = "leavestartdate";
            this.leavestartdate.Size = new System.Drawing.Size(197, 20);
            this.leavestartdate.TabIndex = 13;
            // 
            // leaveenddate
            // 
            this.leaveenddate.Location = new System.Drawing.Point(371, 281);
            this.leaveenddate.Name = "leaveenddate";
            this.leaveenddate.Size = new System.Drawing.Size(197, 20);
            this.leaveenddate.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Month";
            // 
            // monthcombobox
            // 
            this.monthcombobox.FormattingEnabled = true;
            this.monthcombobox.Location = new System.Drawing.Point(371, 374);
            this.monthcombobox.Name = "monthcombobox";
            this.monthcombobox.Size = new System.Drawing.Size(197, 21);
            this.monthcombobox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Year";
            // 
            // leaveyear
            // 
            this.leaveyear.Location = new System.Drawing.Point(371, 328);
            this.leaveyear.Name = "leaveyear";
            this.leaveyear.Size = new System.Drawing.Size(197, 20);
            this.leaveyear.TabIndex = 20;
            this.leaveyear.TextChanged += new System.EventHandler(this.leaveyear_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::OrdersLK.Properties.Resources.orders;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 57);
            this.label9.TabIndex = 3;
            this.label9.Tag = "                    ";
            this.label9.Text = "           ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1171, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(1090, 23);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // LeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leaveyear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthcombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leaveenddate);
            this.Controls.Add(this.leavestartdate);
            this.Controls.Add(this.leavecategory);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.leavedescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LeaveRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1270, 600";
            this.Load += new System.EventHandler(this.LeaveRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox leavedescription;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.ComboBox leavecategory;
        private System.Windows.Forms.DateTimePicker leavestartdate;
        private System.Windows.Forms.DateTimePicker leaveenddate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox monthcombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox leaveyear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backbtn;
    }
}