namespace AmazonWannabe
{
    partial class Administrator_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator_Form));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxPriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minPriceBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.view_pending = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Approve = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.StoresGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoresGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(95, 56);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(496, 21);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Maximum Price : ";
            // 
            // maxPriceBox
            // 
            this.maxPriceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPriceBox.Location = new System.Drawing.Point(148, 194);
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(443, 21);
            this.maxPriceBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Minimum Price : ";
            // 
            // minPriceBox
            // 
            this.minPriceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minPriceBox.Location = new System.Drawing.Point(148, 155);
            this.minPriceBox.Name = "minPriceBox";
            this.minPriceBox.Size = new System.Drawing.Size(443, 21);
            this.minPriceBox.TabIndex = 4;
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
            this.imageList1.Images.SetKeyName(6, "add.png");
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.ImageIndex = 6;
            this.addButton.ImageList = this.imageList1;
            this.addButton.Location = new System.Drawing.Point(452, 329);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 42);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.ImageIndex = 5;
            this.searchButton.ImageList = this.imageList1;
            this.searchButton.Location = new System.Drawing.Point(12, 329);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(206, 42);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Open Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // view_pending
            // 
            this.view_pending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.view_pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_pending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_pending.ImageIndex = 6;
            this.view_pending.ImageList = this.imageList1;
            this.view_pending.Location = new System.Drawing.Point(236, 329);
            this.view_pending.Name = "view_pending";
            this.view_pending.Size = new System.Drawing.Size(210, 42);
            this.view_pending.TabIndex = 14;
            this.view_pending.Text = "View Pending Stores";
            this.view_pending.UseVisualStyleBackColor = true;
            this.view_pending.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StoresGridView);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Approve);
            this.panel1.Location = new System.Drawing.Point(120, -29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 410);
            this.panel1.TabIndex = 15;
            // 
            // Approve
            // 
            this.Approve.Location = new System.Drawing.Point(46, 345);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(148, 36);
            this.Approve.TabIndex = 0;
            this.Approve.Text = "Approve";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(293, 345);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(143, 36);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // StoresGridView
            // 
            this.StoresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresGridView.Location = new System.Drawing.Point(46, 52);
            this.StoresGridView.Name = "StoresGridView";
            this.StoresGridView.Size = new System.Drawing.Size(390, 287);
            this.StoresGridView.TabIndex = 2;
            // 
            // Administrator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 383);
            this.Controls.Add(this.view_pending);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minPriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxPriceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Administrator_Form";
            this.Text = "Administrative Tools";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoresGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxPriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minPriceBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button view_pending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.DataGridView StoresGridView;
    }
}