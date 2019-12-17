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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchItem = new System.Windows.Forms.ComboBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.Buy_button = new System.Windows.Forms.Button();
            this.Confirm_panel = new System.Windows.Forms.Panel();
            this.Term3 = new System.Windows.Forms.Label();
            this.Term2 = new System.Windows.Forms.Label();
            this.Term1 = new System.Windows.Forms.Label();
            this.Terms = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.Agreement = new System.Windows.Forms.CheckBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Close_panel = new System.Windows.Forms.Button();
            this.adminFormButton = new System.Windows.Forms.Button();
            this.storeOwnerFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.Confirm_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsGrid
            // 
            this.productsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGrid.BackgroundColor = System.Drawing.Color.White;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productPrice,
            this.ID});
            this.productsGrid.Location = new System.Drawing.Point(12, 159);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            this.productsGrid.Size = new System.Drawing.Size(909, 348);
            this.productsGrid.TabIndex = 0;
            this.productsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellDoubleClick_1);
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
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // searchItem
            // 
            this.searchItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // Buy_button
            // 
            this.Buy_button.Location = new System.Drawing.Point(70, 118);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(98, 35);
            this.Buy_button.TabIndex = 12;
            this.Buy_button.Text = "Buy Selected";
            this.Buy_button.UseVisualStyleBackColor = true;
            this.Buy_button.Click += new System.EventHandler(this.Buy_button_Click);
            // 
            // Confirm_panel
            // 
            this.Confirm_panel.Controls.Add(this.Term3);
            this.Confirm_panel.Controls.Add(this.Term2);
            this.Confirm_panel.Controls.Add(this.Term1);
            this.Confirm_panel.Controls.Add(this.Terms);
            this.Confirm_panel.Controls.Add(this.Address);
            this.Confirm_panel.Controls.Add(this.Amount);
            this.Confirm_panel.Controls.Add(this.addressBox);
            this.Confirm_panel.Controls.Add(this.amountBox);
            this.Confirm_panel.Controls.Add(this.Agreement);
            this.Confirm_panel.Controls.Add(this.Confirm);
            this.Confirm_panel.Controls.Add(this.Close_panel);
            this.Confirm_panel.Location = new System.Drawing.Point(329, 30);
            this.Confirm_panel.Name = "Confirm_panel";
            this.Confirm_panel.Size = new System.Drawing.Size(488, 359);
            this.Confirm_panel.TabIndex = 13;
            // 
            // Term3
            // 
            this.Term3.AutoSize = true;
            this.Term3.Location = new System.Drawing.Point(51, 218);
            this.Term3.Name = "Term3";
            this.Term3.Size = new System.Drawing.Size(269, 15);
            this.Term3.TabIndex = 10;
            this.Term3.Text = "-Payment will be given to delivery guy on delivery";
            // 
            // Term2
            // 
            this.Term2.AutoSize = true;
            this.Term2.Location = new System.Drawing.Point(51, 189);
            this.Term2.Name = "Term2";
            this.Term2.Size = new System.Drawing.Size(210, 15);
            this.Term2.TabIndex = 9;
            this.Term2.Text = "-No refunds are allowed after 15 days";
            // 
            // Term1
            // 
            this.Term1.AutoSize = true;
            this.Term1.Location = new System.Drawing.Point(48, 157);
            this.Term1.Name = "Term1";
            this.Term1.Size = new System.Drawing.Size(287, 15);
            this.Term1.TabIndex = 8;
            this.Term1.Text = "-The product will be shipped withing 3 working days";
            // 
            // Terms
            // 
            this.Terms.AutoSize = true;
            this.Terms.Location = new System.Drawing.Point(29, 129);
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(130, 15);
            this.Terms.TabIndex = 7;
            this.Terms.Text = "Terms and Conditions:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(55, 80);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(51, 15);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(55, 32);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(49, 15);
            this.Amount.TabIndex = 5;
            this.Amount.Text = "Amount";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(150, 80);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 21);
            this.addressBox.TabIndex = 4;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(150, 32);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 21);
            this.amountBox.TabIndex = 3;
            // 
            // Agreement
            // 
            this.Agreement.AutoSize = true;
            this.Agreement.Location = new System.Drawing.Point(29, 263);
            this.Agreement.Name = "Agreement";
            this.Agreement.Size = new System.Drawing.Size(188, 19);
            this.Agreement.TabIndex = 2;
            this.Agreement.Text = "Agree to terms and conditions";
            this.Agreement.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(29, 298);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(121, 45);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Close_panel
            // 
            this.Close_panel.Location = new System.Drawing.Point(345, 298);
            this.Close_panel.Name = "Close_panel";
            this.Close_panel.Size = new System.Drawing.Size(121, 45);
            this.Close_panel.TabIndex = 0;
            this.Close_panel.Text = "Close Panel";
            this.Close_panel.UseVisualStyleBackColor = true;
            this.Close_panel.Click += new System.EventHandler(this.Close_panel_Click);
            // 
            // adminFormButton
            // 
            this.adminFormButton.Location = new System.Drawing.Point(12, 12);
            this.adminFormButton.Name = "adminFormButton";
            this.adminFormButton.Size = new System.Drawing.Size(98, 35);
            this.adminFormButton.TabIndex = 14;
            this.adminFormButton.Text = "Tools";
            this.adminFormButton.UseVisualStyleBackColor = true;
            this.adminFormButton.Click += new System.EventHandler(this.AdminFormButton_Click);
            // 
            // storeOwnerFormButton
            // 
            this.storeOwnerFormButton.Location = new System.Drawing.Point(12, 12);
            this.storeOwnerFormButton.Name = "storeOwnerFormButton";
            this.storeOwnerFormButton.Size = new System.Drawing.Size(98, 35);
            this.storeOwnerFormButton.TabIndex = 15;
            this.storeOwnerFormButton.Text = "Tools";
            this.storeOwnerFormButton.UseVisualStyleBackColor = true;
            this.storeOwnerFormButton.Click += new System.EventHandler(this.storeOwnerFormButton_Click);
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.Buy_button);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.Confirm_panel);
            this.Controls.Add(this.storeOwnerFormButton);
            this.Controls.Add(this.adminFormButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Search_Form";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.Confirm_panel.ResumeLayout(false);
            this.Confirm_panel.PerformLayout();
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
        private System.Windows.Forms.Button Buy_button;
        private System.Windows.Forms.Panel Confirm_panel;
        private System.Windows.Forms.CheckBox Agreement;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Close_panel;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label Term3;
        private System.Windows.Forms.Label Term2;
        private System.Windows.Forms.Label Term1;
        private System.Windows.Forms.Label Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button adminFormButton;
        private System.Windows.Forms.Button storeOwnerFormButton;
    }
}