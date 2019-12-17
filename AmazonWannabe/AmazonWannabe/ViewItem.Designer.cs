namespace AmazonWannabe
{
    partial class ViewItem
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
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.StoreName = new System.Windows.Forms.Label();
            this.StoreNameLabel = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 34);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(112, 37);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Name:";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(136, 34);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(53, 37);
            this.ProductName.TabIndex = 1;
            this.ProductName.Text = "....";
            // 
            // StoreName
            // 
            this.StoreName.AutoSize = true;
            this.StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName.Location = new System.Drawing.Point(136, 125);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(53, 37);
            this.StoreName.TabIndex = 3;
            this.StoreName.Text = "....";
            // 
            // StoreNameLabel
            // 
            this.StoreNameLabel.AutoSize = true;
            this.StoreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNameLabel.Location = new System.Drawing.Point(12, 125);
            this.StoreNameLabel.Name = "StoreNameLabel";
            this.StoreNameLabel.Size = new System.Drawing.Size(102, 37);
            this.StoreNameLabel.TabIndex = 2;
            this.StoreNameLabel.Text = "Store:";
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSize = true;
            this.ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.Location = new System.Drawing.Point(136, 83);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(53, 37);
            this.ProductPrice.TabIndex = 5;
            this.ProductPrice.Text = "....";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceLabel.Location = new System.Drawing.Point(12, 83);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(98, 37);
            this.ProductPriceLabel.TabIndex = 4;
            this.ProductPriceLabel.Text = "Price:";
            // 
            // ViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 359);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.StoreName);
            this.Controls.Add(this.StoreNameLabel);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "ViewItem";
            this.Text = "ViewItem";
            this.Load += new System.EventHandler(this.ViewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private new System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label StoreName;
        private System.Windows.Forms.Label StoreNameLabel;
        private System.Windows.Forms.Label ProductPrice;
        private System.Windows.Forms.Label ProductPriceLabel;
    }
}