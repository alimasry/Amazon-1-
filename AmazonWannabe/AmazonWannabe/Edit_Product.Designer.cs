namespace AmazonWannabe
{
    partial class Edit_Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.StockNumBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ItemBox = new System.Windows.Forms.ComboBox();
            this.StoreBox = new System.Windows.Forms.ComboBox();
            this.BrandBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brand : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Store : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item : ";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(128, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(201, 22);
            this.NameBox.TabIndex = 6;
            // 
            // StockNumBox
            // 
            this.StockNumBox.Location = new System.Drawing.Point(128, 95);
            this.StockNumBox.Name = "StockNumBox";
            this.StockNumBox.Size = new System.Drawing.Size(201, 22);
            this.StockNumBox.TabIndex = 10;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(128, 54);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(201, 22);
            this.PriceBox.TabIndex = 11;
            // 
            // ItemBox
            // 
            this.ItemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.Location = new System.Drawing.Point(128, 168);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(201, 24);
            this.ItemBox.TabIndex = 12;
            // 
            // StoreBox
            // 
            this.StoreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreBox.FormattingEnabled = true;
            this.StoreBox.Location = new System.Drawing.Point(128, 205);
            this.StoreBox.Name = "StoreBox";
            this.StoreBox.Size = new System.Drawing.Size(201, 24);
            this.StoreBox.TabIndex = 13;
            // 
            // BrandBox
            // 
            this.BrandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandBox.FormattingEnabled = true;
            this.BrandBox.Location = new System.Drawing.Point(128, 244);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(201, 24);
            this.BrandBox.TabIndex = 14;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(108, 313);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(131, 53);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Edit_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 378);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.StoreBox);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.StockNumBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Product";
            this.Text = "Edit_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox StockNumBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.ComboBox ItemBox;
        private System.Windows.Forms.ComboBox StoreBox;
        private System.Windows.Forms.ComboBox BrandBox;
        private System.Windows.Forms.Button SaveButton;
    }
}