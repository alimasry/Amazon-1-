namespace AmazonWannabe
{
    partial class Search_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Form));
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchItem = new System.Windows.Forms.ComboBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGrid.BackgroundColor = System.Drawing.Color.White;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productPrice});
            this.productsGrid.Location = new System.Drawing.Point(12, 159);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            this.productsGrid.Size = new System.Drawing.Size(909, 348);
            this.productsGrid.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "Name";
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 433;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "Price";
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 433;
            // 
            // searchItem
            // 
            this.searchItem.FormattingEnabled = true;
            this.searchItem.Location = new System.Drawing.Point(70, 89);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(185, 23);
            this.searchItem.TabIndex = 1;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.Location = new System.Drawing.Point(70, 62);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(851, 21);
            this.searchBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search : ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "clipboard.png");
            this.imageList1.Images.SetKeyName(2, "back.png");
            this.imageList1.Images.SetKeyName(3, "login.png");
            this.imageList1.Images.SetKeyName(4, "logout.png");
            this.imageList1.Images.SetKeyName(5, "research.png");
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.ImageIndex = 5;
            this.searchButton.ImageList = this.imageList1;
            this.searchButton.Location = new System.Drawing.Point(873, 89);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(48, 42);
            this.searchButton.TabIndex = 11;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.productsGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Search_Form";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.ComboBox searchItem;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
    }
}