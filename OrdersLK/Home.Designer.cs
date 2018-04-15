namespace OrdersLK
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.salesbtn = new System.Windows.Forms.Button();
            this.productbtn = new System.Windows.Forms.Button();
            this.deliverybtn = new System.Windows.Forms.Button();
            this.employeebtn = new System.Windows.Forms.Button();
            this.accountsbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Aqua;
            this.logoutbtn.Location = new System.Drawing.Point(1167, 24);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // salesbtn
            // 
            this.salesbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesbtn.BackgroundImage")));
            this.salesbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salesbtn.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesbtn.Location = new System.Drawing.Point(90, 99);
            this.salesbtn.Name = "salesbtn";
            this.salesbtn.Size = new System.Drawing.Size(263, 179);
            this.salesbtn.TabIndex = 0;
            this.salesbtn.UseVisualStyleBackColor = true;
            this.salesbtn.Click += new System.EventHandler(this.salesbtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.BackgroundImage = global::OrdersLK.Properties.Resources.inv;
            this.productbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productbtn.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.Location = new System.Drawing.Point(897, 99);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(263, 179);
            this.productbtn.TabIndex = 1;
            this.productbtn.UseVisualStyleBackColor = true;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // deliverybtn
            // 
            this.deliverybtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deliverybtn.BackgroundImage")));
            this.deliverybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deliverybtn.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverybtn.Location = new System.Drawing.Point(498, 99);
            this.deliverybtn.Name = "deliverybtn";
            this.deliverybtn.Size = new System.Drawing.Size(263, 179);
            this.deliverybtn.TabIndex = 1;
            this.deliverybtn.UseVisualStyleBackColor = true;
            this.deliverybtn.Click += new System.EventHandler(this.deliverybtn_Click);
            // 
            // employeebtn
            // 
            this.employeebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeebtn.BackgroundImage")));
            this.employeebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeebtn.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeebtn.Location = new System.Drawing.Point(296, 323);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(263, 179);
            this.employeebtn.TabIndex = 1;
            this.employeebtn.UseVisualStyleBackColor = true;
            this.employeebtn.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // accountsbtn
            // 
            this.accountsbtn.BackgroundImage = global::OrdersLK.Properties.Resources.accounts_consultancy_service_250x250;
            this.accountsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accountsbtn.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsbtn.Location = new System.Drawing.Point(708, 323);
            this.accountsbtn.Name = "accountsbtn";
            this.accountsbtn.Size = new System.Drawing.Size(263, 179);
            this.accountsbtn.TabIndex = 1;
            this.accountsbtn.UseVisualStyleBackColor = true;
            this.accountsbtn.Click += new System.EventHandler(this.accountsbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::OrdersLK.Properties.Resources.orders;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 57);
            this.label1.TabIndex = 4;
            this.label1.Tag = "                    ";
            this.label1.Text = "           ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.salesbtn);
            this.Controls.Add(this.productbtn);
            this.Controls.Add(this.deliverybtn);
            this.Controls.Add(this.employeebtn);
            this.Controls.Add(this.accountsbtn);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders.lk Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
      
        private System.Windows.Forms.Button salesbtn;
        private System.Windows.Forms.Button deliverybtn;
        private System.Windows.Forms.Button productbtn;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button accountsbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label1;
    }
}