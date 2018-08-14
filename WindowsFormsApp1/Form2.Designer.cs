namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lblFoodName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(6, 27);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(62, 13);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Food Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(107, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(80, 22);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(197, 20);
            this.txtUpdateName.TabIndex = 4;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(12, 25);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateName.TabIndex = 3;
            this.lblUpdateName.Text = "Name";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(80, 61);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(197, 20);
            this.txtUpdatePrice.TabIndex = 6;
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(12, 64);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(31, 13);
            this.lblUpdatePrice.TabIndex = 5;
            this.lblUpdatePrice.Text = "Price";
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(80, 97);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(197, 20);
            this.txtUpdateDescription.TabIndex = 8;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(12, 100);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(60, 13);
            this.lblUpdateDescription.TabIndex = 7;
            this.lblUpdateDescription.Text = "Description";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(107, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(357, 378);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblFoodName);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(31, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.lblUpdateName);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.lblUpdateDescription);
            this.groupBox2.Controls.Add(this.lblUpdatePrice);
            this.groupBox2.Controls.Add(this.txtUpdateDescription);
            this.groupBox2.Controls.Add(this.txtUpdateName);
            this.groupBox2.Controls.Add(this.txtUpdatePrice);
            this.groupBox2.Location = new System.Drawing.Point(31, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 175);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 378);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}