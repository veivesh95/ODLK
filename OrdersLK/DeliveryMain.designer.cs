namespace OrdersLK
{
    partial class DeliveryMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkDelivery = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 151);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Delivery";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(619, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 151);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Delivery";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkDelivery
            // 
            this.checkDelivery.BackColor = System.Drawing.Color.DarkTurquoise;
            this.checkDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDelivery.Location = new System.Drawing.Point(452, 207);
            this.checkDelivery.Name = "checkDelivery";
            this.checkDelivery.Size = new System.Drawing.Size(226, 151);
            this.checkDelivery.TabIndex = 2;
            this.checkDelivery.Text = "Check My Delivery";
            this.checkDelivery.UseVisualStyleBackColor = false;
            this.checkDelivery.Click += new System.EventHandler(this.checkDelivery_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::OrdersLK.Properties.Resources.aaaaaaaaaback;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Location = new System.Drawing.Point(1182, 11);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 48);
            this.backbtn.TabIndex = 3;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::OrdersLK.Properties.Resources.orders;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 57);
            this.label1.TabIndex = 4;
            this.label1.Tag = "                    ";
            this.label1.Text = "           ";
            // 
            // DeliveryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkDelivery);
            this.Controls.Add(this.panel1);
            this.Name = "DeliveryMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DeliveryMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button checkDelivery;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

