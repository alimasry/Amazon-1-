namespace AmazonWannabe
{
    partial class StoreOwner_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreOwner_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.stockNumBox = new System.Windows.Forms.TextBox();
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.storeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addStorePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.storeLocationBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.storeTypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storeNameBox = new System.Windows.Forms.TextBox();
            this.addStoreButton = new System.Windows.Forms.Button();
            this.StatsViewButton = new System.Windows.Forms.Button();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.statsView = new System.Windows.Forms.DataGridView();
            this.ProductViewButton = new System.Windows.Forms.Button();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.RemoveLabel = new System.Windows.Forms.LinkLabel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.storeBox2 = new System.Windows.Forms.ComboBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ViewHistoryButton = new System.Windows.Forms.Button();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.UndoLabel = new System.Windows.Forms.LinkLabel();
            this.SearchHistoryButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.storeBox3 = new System.Windows.Forms.ComboBox();
            this.HistoryGridView = new System.Windows.Forms.DataGridView();
            this.HistoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryStockNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditLabel = new System.Windows.Forms.LinkLabel();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductPanel.SuspendLayout();
            this.addStorePanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsView)).BeginInit();
            this.ProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.HistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name : ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(190, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(396, 24);
            this.nameBox.TabIndex = 1;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(190, 59);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(396, 24);
            this.priceBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item : ";
            // 
            // itemBox
            // 
            this.itemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(77, 185);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(509, 26);
            this.itemBox.TabIndex = 5;
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductButton.ImageIndex = 6;
            this.addProductButton.ImageList = this.imageList2;
            this.addProductButton.Location = new System.Drawing.Point(469, 456);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(139, 42);
            this.addProductButton.TabIndex = 13;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "close.png");
            this.imageList2.Images.SetKeyName(1, "clipboard.png");
            this.imageList2.Images.SetKeyName(2, "back.png");
            this.imageList2.Images.SetKeyName(3, "login.png");
            this.imageList2.Images.SetKeyName(4, "logout.png");
            this.imageList2.Images.SetKeyName(5, "research.png");
            this.imageList2.Images.SetKeyName(6, "add.png");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(12, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Store";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addProductPanel
            // 
            this.addProductPanel.Controls.Add(this.label11);
            this.addProductPanel.Controls.Add(this.stockNumBox);
            this.addProductPanel.Controls.Add(this.brandBox);
            this.addProductPanel.Controls.Add(this.label8);
            this.addProductPanel.Controls.Add(this.storeBox);
            this.addProductPanel.Controls.Add(this.label4);
            this.addProductPanel.Controls.Add(this.label1);
            this.addProductPanel.Controls.Add(this.nameBox);
            this.addProductPanel.Controls.Add(this.label2);
            this.addProductPanel.Controls.Add(this.addProductButton);
            this.addProductPanel.Controls.Add(this.priceBox);
            this.addProductPanel.Controls.Add(this.itemBox);
            this.addProductPanel.Controls.Add(this.label3);
            this.addProductPanel.Location = new System.Drawing.Point(205, 9);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(608, 498);
            this.addProductPanel.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Product Stock Number : ";
            // 
            // stockNumBox
            // 
            this.stockNumBox.Location = new System.Drawing.Point(190, 108);
            this.stockNumBox.Name = "stockNumBox";
            this.stockNumBox.Size = new System.Drawing.Size(396, 24);
            this.stockNumBox.TabIndex = 19;
            // 
            // brandBox
            // 
            this.brandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandBox.FormattingEnabled = true;
            this.brandBox.Location = new System.Drawing.Point(77, 276);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(509, 26);
            this.brandBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Brand : ";
            // 
            // storeBox
            // 
            this.storeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeBox.FormattingEnabled = true;
            this.storeBox.Location = new System.Drawing.Point(77, 232);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(509, 26);
            this.storeBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Store : ";
            // 
            // addStorePanel
            // 
            this.addStorePanel.Controls.Add(this.label7);
            this.addStorePanel.Controls.Add(this.storeLocationBox);
            this.addStorePanel.Controls.Add(this.label6);
            this.addStorePanel.Controls.Add(this.storeTypeBox);
            this.addStorePanel.Controls.Add(this.label5);
            this.addStorePanel.Controls.Add(this.storeNameBox);
            this.addStorePanel.Controls.Add(this.addStoreButton);
            this.addStorePanel.Location = new System.Drawing.Point(205, 9);
            this.addStorePanel.Name = "addStorePanel";
            this.addStorePanel.Size = new System.Drawing.Size(608, 498);
            this.addStorePanel.TabIndex = 18;
            this.addStorePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addStorePanel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Location : ";
            // 
            // storeLocationBox
            // 
            this.storeLocationBox.Location = new System.Drawing.Point(113, 208);
            this.storeLocationBox.Name = "storeLocationBox";
            this.storeLocationBox.Size = new System.Drawing.Size(473, 24);
            this.storeLocationBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Type : ";
            // 
            // storeTypeBox
            // 
            this.storeTypeBox.Location = new System.Drawing.Point(113, 136);
            this.storeTypeBox.Name = "storeTypeBox";
            this.storeTypeBox.Size = new System.Drawing.Size(473, 24);
            this.storeTypeBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Store Name : ";
            // 
            // storeNameBox
            // 
            this.storeNameBox.Location = new System.Drawing.Point(113, 70);
            this.storeNameBox.Name = "storeNameBox";
            this.storeNameBox.Size = new System.Drawing.Size(473, 24);
            this.storeNameBox.TabIndex = 15;
            // 
            // addStoreButton
            // 
            this.addStoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStoreButton.ImageIndex = 6;
            this.addStoreButton.ImageList = this.imageList2;
            this.addStoreButton.Location = new System.Drawing.Point(469, 456);
            this.addStoreButton.Name = "addStoreButton";
            this.addStoreButton.Size = new System.Drawing.Size(139, 42);
            this.addStoreButton.TabIndex = 16;
            this.addStoreButton.Text = "Add";
            this.addStoreButton.UseVisualStyleBackColor = true;
            this.addStoreButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // StatsViewButton
            // 
            this.StatsViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatsViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatsViewButton.ImageList = this.imageList2;
            this.StatsViewButton.Location = new System.Drawing.Point(12, 156);
            this.StatsViewButton.Name = "StatsViewButton";
            this.StatsViewButton.Size = new System.Drawing.Size(190, 42);
            this.StatsViewButton.TabIndex = 19;
            this.StatsViewButton.Text = "View Stats";
            this.StatsViewButton.UseVisualStyleBackColor = true;
            this.StatsViewButton.Click += new System.EventHandler(this.StatsViewButton_Click);
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.statsView);
            this.statsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsPanel.Location = new System.Drawing.Point(205, 9);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(608, 498);
            this.statsPanel.TabIndex = 18;
            // 
            // statsView
            // 
            this.statsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsView.Location = new System.Drawing.Point(0, 0);
            this.statsView.Name = "statsView";
            this.statsView.RowHeadersWidth = 51;
            this.statsView.RowTemplate.Height = 28;
            this.statsView.Size = new System.Drawing.Size(608, 422);
            this.statsView.TabIndex = 0;
            // 
            // ProductViewButton
            // 
            this.ProductViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductViewButton.ImageList = this.imageList2;
            this.ProductViewButton.Location = new System.Drawing.Point(12, 108);
            this.ProductViewButton.Name = "ProductViewButton";
            this.ProductViewButton.Size = new System.Drawing.Size(190, 42);
            this.ProductViewButton.TabIndex = 20;
            this.ProductViewButton.Text = "View Products";
            this.ProductViewButton.UseVisualStyleBackColor = true;
            this.ProductViewButton.Click += new System.EventHandler(this.ProductViewButton_Click);
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.Controls.Add(this.EditLabel);
            this.ProductsPanel.Controls.Add(this.RemoveLabel);
            this.ProductsPanel.Controls.Add(this.SearchButton);
            this.ProductsPanel.Controls.Add(this.label9);
            this.ProductsPanel.Controls.Add(this.storeBox2);
            this.ProductsPanel.Controls.Add(this.ProductsGridView);
            this.ProductsPanel.Location = new System.Drawing.Point(205, 9);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(609, 498);
            this.ProductsPanel.TabIndex = 21;
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.Location = new System.Drawing.Point(541, 425);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(64, 18);
            this.RemoveLabel.TabIndex = 23;
            this.RemoveLabel.TabStop = true;
            this.RemoveLabel.Text = "Remove";
            this.RemoveLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveLabel_LinkClicked);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.ImageList = this.imageList2;
            this.SearchButton.Location = new System.Drawing.Point(477, 456);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(128, 42);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Store : ";
            // 
            // storeBox2
            // 
            this.storeBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeBox2.FormattingEnabled = true;
            this.storeBox2.Location = new System.Drawing.Point(66, 435);
            this.storeBox2.Name = "storeBox2";
            this.storeBox2.Size = new System.Drawing.Size(163, 26);
            this.storeBox2.TabIndex = 1;
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AllowUserToAddRows = false;
            this.ProductsGridView.AllowUserToDeleteRows = false;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductPrice,
            this.StockNum,
            this.ItemName,
            this.StoreName,
            this.BrandName});
            this.ProductsGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.ReadOnly = true;
            this.ProductsGridView.RowHeadersWidth = 51;
            this.ProductsGridView.RowTemplate.Height = 24;
            this.ProductsGridView.Size = new System.Drawing.Size(608, 422);
            this.ProductsGridView.TabIndex = 0;
            // 
            // ViewHistoryButton
            // 
            this.ViewHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewHistoryButton.ImageList = this.imageList2;
            this.ViewHistoryButton.Location = new System.Drawing.Point(12, 204);
            this.ViewHistoryButton.Name = "ViewHistoryButton";
            this.ViewHistoryButton.Size = new System.Drawing.Size(190, 42);
            this.ViewHistoryButton.TabIndex = 22;
            this.ViewHistoryButton.Text = "View History";
            this.ViewHistoryButton.UseVisualStyleBackColor = true;
            this.ViewHistoryButton.Click += new System.EventHandler(this.ViewHistoryButton_Click);
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Controls.Add(this.UndoLabel);
            this.HistoryPanel.Controls.Add(this.SearchHistoryButton);
            this.HistoryPanel.Controls.Add(this.label10);
            this.HistoryPanel.Controls.Add(this.storeBox3);
            this.HistoryPanel.Controls.Add(this.HistoryGridView);
            this.HistoryPanel.Location = new System.Drawing.Point(205, 9);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(609, 498);
            this.HistoryPanel.TabIndex = 23;
            // 
            // UndoLabel
            // 
            this.UndoLabel.AutoSize = true;
            this.UndoLabel.Location = new System.Drawing.Point(561, 425);
            this.UndoLabel.Name = "UndoLabel";
            this.UndoLabel.Size = new System.Drawing.Size(44, 18);
            this.UndoLabel.TabIndex = 25;
            this.UndoLabel.TabStop = true;
            this.UndoLabel.Text = "Undo";
            this.UndoLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UndoLabel_LinkClicked);
            // 
            // SearchHistoryButton
            // 
            this.SearchHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchHistoryButton.ImageList = this.imageList2;
            this.SearchHistoryButton.Location = new System.Drawing.Point(469, 456);
            this.SearchHistoryButton.Name = "SearchHistoryButton";
            this.SearchHistoryButton.Size = new System.Drawing.Size(139, 42);
            this.SearchHistoryButton.TabIndex = 24;
            this.SearchHistoryButton.Text = "Search";
            this.SearchHistoryButton.UseVisualStyleBackColor = true;
            this.SearchHistoryButton.Click += new System.EventHandler(this.SearchHistoryButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Store : ";
            // 
            // storeBox3
            // 
            this.storeBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeBox3.FormattingEnabled = true;
            this.storeBox3.Location = new System.Drawing.Point(66, 432);
            this.storeBox3.Name = "storeBox3";
            this.storeBox3.Size = new System.Drawing.Size(163, 26);
            this.storeBox3.TabIndex = 3;
            // 
            // HistoryGridView
            // 
            this.HistoryGridView.AllowUserToAddRows = false;
            this.HistoryGridView.AllowUserToDeleteRows = false;
            this.HistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryID,
            this.HistoryAction,
            this.HistoryProductName,
            this.HistoryProductID,
            this.HistoryStoreName,
            this.HistoryItemName,
            this.HistoryBrandName,
            this.HistoryStockNum,
            this.HistoryPrice});
            this.HistoryGridView.Location = new System.Drawing.Point(0, 0);
            this.HistoryGridView.MultiSelect = false;
            this.HistoryGridView.Name = "HistoryGridView";
            this.HistoryGridView.ReadOnly = true;
            this.HistoryGridView.RowHeadersWidth = 51;
            this.HistoryGridView.RowTemplate.Height = 24;
            this.HistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoryGridView.Size = new System.Drawing.Size(608, 422);
            this.HistoryGridView.TabIndex = 0;
            // 
            // HistoryID
            // 
            this.HistoryID.HeaderText = "ID";
            this.HistoryID.MinimumWidth = 6;
            this.HistoryID.Name = "HistoryID";
            this.HistoryID.ReadOnly = true;
            this.HistoryID.Visible = false;
            this.HistoryID.Width = 125;
            // 
            // HistoryAction
            // 
            this.HistoryAction.HeaderText = "Action";
            this.HistoryAction.MinimumWidth = 6;
            this.HistoryAction.Name = "HistoryAction";
            this.HistoryAction.ReadOnly = true;
            this.HistoryAction.Width = 79;
            // 
            // HistoryProductName
            // 
            this.HistoryProductName.HeaderText = "Product Name";
            this.HistoryProductName.MinimumWidth = 6;
            this.HistoryProductName.Name = "HistoryProductName";
            this.HistoryProductName.ReadOnly = true;
            this.HistoryProductName.Width = 80;
            // 
            // HistoryProductID
            // 
            this.HistoryProductID.HeaderText = "Product ID";
            this.HistoryProductID.MinimumWidth = 6;
            this.HistoryProductID.Name = "HistoryProductID";
            this.HistoryProductID.ReadOnly = true;
            this.HistoryProductID.Visible = false;
            this.HistoryProductID.Width = 69;
            // 
            // HistoryStoreName
            // 
            this.HistoryStoreName.HeaderText = "Store Name";
            this.HistoryStoreName.MinimumWidth = 6;
            this.HistoryStoreName.Name = "HistoryStoreName";
            this.HistoryStoreName.ReadOnly = true;
            this.HistoryStoreName.Width = 79;
            // 
            // HistoryItemName
            // 
            this.HistoryItemName.HeaderText = "Item Name";
            this.HistoryItemName.MinimumWidth = 6;
            this.HistoryItemName.Name = "HistoryItemName";
            this.HistoryItemName.ReadOnly = true;
            this.HistoryItemName.Width = 79;
            // 
            // HistoryBrandName
            // 
            this.HistoryBrandName.HeaderText = "Brand Name";
            this.HistoryBrandName.MinimumWidth = 6;
            this.HistoryBrandName.Name = "HistoryBrandName";
            this.HistoryBrandName.ReadOnly = true;
            this.HistoryBrandName.Width = 79;
            // 
            // HistoryStockNum
            // 
            this.HistoryStockNum.HeaderText = "Stock Number";
            this.HistoryStockNum.MinimumWidth = 6;
            this.HistoryStockNum.Name = "HistoryStockNum";
            this.HistoryStockNum.ReadOnly = true;
            this.HistoryStockNum.Width = 80;
            // 
            // HistoryPrice
            // 
            this.HistoryPrice.HeaderText = "Price";
            this.HistoryPrice.MinimumWidth = 6;
            this.HistoryPrice.Name = "HistoryPrice";
            this.HistoryPrice.ReadOnly = true;
            this.HistoryPrice.Width = 79;
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Location = new System.Drawing.Point(502, 425);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(33, 18);
            this.EditLabel.TabIndex = 27;
            this.EditLabel.TabStop = true;
            this.EditLabel.Text = "Edit";
            this.EditLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditLabel_LinkClicked);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            this.ProductID.Width = 79;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 93;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 92;
            // 
            // StockNum
            // 
            this.StockNum.HeaderText = "Stock Number";
            this.StockNum.MinimumWidth = 6;
            this.StockNum.Name = "StockNum";
            this.StockNum.ReadOnly = true;
            this.StockNum.Width = 93;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 92;
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "Store";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 93;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "Brand";
            this.BrandName.MinimumWidth = 6;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 92;
            // 
            // StoreOwner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 519);
            this.Controls.Add(this.ViewHistoryButton);
            this.Controls.Add(this.ProductViewButton);
            this.Controls.Add(this.StatsViewButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductsPanel);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.addStorePanel);
            this.Controls.Add(this.addProductPanel);
            this.Controls.Add(this.HistoryPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StoreOwner_Form";
            this.Text = "Store Owner";
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
            this.addStorePanel.ResumeLayout(false);
            this.addStorePanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statsView)).EndInit();
            this.ProductsPanel.ResumeLayout(false);
            this.ProductsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.HistoryPanel.ResumeLayout(false);
            this.HistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox itemBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.ComboBox storeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel addStorePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox storeNameBox;
        private System.Windows.Forms.Button addStoreButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox storeLocationBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox storeTypeBox;
        private System.Windows.Forms.ComboBox brandBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Button StatsViewButton;
        private System.Windows.Forms.DataGridView statsView;
        private System.Windows.Forms.Button ProductViewButton;
        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox storeBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.LinkLabel RemoveLabel;
        private System.Windows.Forms.Button ViewHistoryButton;
        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.Button SearchHistoryButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox storeBox3;
        private System.Windows.Forms.DataGridView HistoryGridView;
        private System.Windows.Forms.LinkLabel UndoLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stockNumBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryStockNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryPrice;
        private System.Windows.Forms.LinkLabel EditLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
    }
}