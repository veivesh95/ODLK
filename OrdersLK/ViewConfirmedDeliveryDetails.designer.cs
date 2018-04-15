namespace OrdersLK
{
    partial class ViewConfirmedDeliveryDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewDeliverydataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cancelDelivery = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDeliverydataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewDeliverydataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(157, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmed Delivery details";
            // 
            // ViewDeliverydataGridView1
            // 
            this.ViewDeliverydataGridView1.AllowUserToAddRows = false;
            this.ViewDeliverydataGridView1.AllowUserToDeleteRows = false;
            this.ViewDeliverydataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.ViewDeliverydataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDeliverydataGridView1.Location = new System.Drawing.Point(16, 30);
            this.ViewDeliverydataGridView1.Name = "ViewDeliverydataGridView1";
            this.ViewDeliverydataGridView1.ReadOnly = true;
            this.ViewDeliverydataGridView1.Size = new System.Drawing.Size(943, 331);
            this.ViewDeliverydataGridView1.TabIndex = 0;
            this.ViewDeliverydataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDeliverydataGridView1_CellClick);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(157, 486);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(97, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update Payment";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1026, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export to Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancelDelivery
            // 
            this.cancelDelivery.Location = new System.Drawing.Point(270, 486);
            this.cancelDelivery.Name = "cancelDelivery";
            this.cancelDelivery.Size = new System.Drawing.Size(114, 23);
            this.cancelDelivery.TabIndex = 3;
            this.cancelDelivery.Text = "Cancel Delivery";
            this.cancelDelivery.UseVisualStyleBackColor = true;
            this.cancelDelivery.Click += new System.EventHandler(this.cancelDelivery_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1086, 23);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::OrdersLK.Properties.Resources.orders;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 57);
            this.label1.TabIndex = 5;
            this.label1.Tag = "                    ";
            this.label1.Text = "           ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1167, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ViewConfirmedDeliveryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelDelivery);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewConfirmedDeliveryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewConfirmedDeliveryDetails";
            this.Load += new System.EventHandler(this.ViewConfirmedDeliveryDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDeliverydataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ViewDeliverydataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancelDelivery;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}