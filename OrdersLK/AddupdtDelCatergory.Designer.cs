namespace OrdersLK
{
    partial class AddupdtDelCategory
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
            this.ctergorydgv = new System.Windows.Forms.DataGridView();
            this.catergorynamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catergoridlable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.updtbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctergorydgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctergorydgv
            // 
            this.ctergorydgv.BackgroundColor = System.Drawing.Color.White;
            this.ctergorydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctergorydgv.Location = new System.Drawing.Point(440, 107);
            this.ctergorydgv.Name = "ctergorydgv";
            this.ctergorydgv.Size = new System.Drawing.Size(631, 326);
            this.ctergorydgv.TabIndex = 0;
            this.ctergorydgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctergorydgv_CellDoubleClick);
            // 
            // catergorynamebox
            // 
            this.catergorynamebox.Location = new System.Drawing.Point(159, 182);
            this.catergorynamebox.Name = "catergorynamebox";
            this.catergorynamebox.Size = new System.Drawing.Size(206, 20);
            this.catergorynamebox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Catergory Name";
            // 
            // catergoridlable
            // 
            this.catergoridlable.AutoSize = true;
            this.catergoridlable.Location = new System.Drawing.Point(156, 121);
            this.catergoridlable.Name = "catergoridlable";
            this.catergoridlable.Size = new System.Drawing.Size(35, 13);
            this.catergoridlable.TabIndex = 3;
            this.catergoridlable.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Catergory Id";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(159, 238);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // updtbtn
            // 
            this.updtbtn.Location = new System.Drawing.Point(159, 282);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(75, 23);
            this.updtbtn.TabIndex = 6;
            this.updtbtn.Text = "Update";
            this.updtbtn.UseVisualStyleBackColor = true;
            this.updtbtn.Click += new System.EventHandler(this.updtbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(159, 321);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 7;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::OrdersLK.Properties.Resources.orders;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 57);
            this.label2.TabIndex = 3;
            this.label2.Tag = "                    ";
            this.label2.Text = "           ";
            // 
            // AddupdtDelCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updtbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.catergoridlable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catergorynamebox);
            this.Controls.Add(this.ctergorydgv);
            this.Name = "AddupdtDelCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddupdtDelCatergory";
            this.Load += new System.EventHandler(this.catergoryidlbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctergorydgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ctergorydgv;
        private System.Windows.Forms.TextBox catergorynamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label catergoridlable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}