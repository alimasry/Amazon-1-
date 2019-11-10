﻿namespace AmazonWannabe
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
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.storeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addStorePanel = new System.Windows.Forms.Panel();
            this.addProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name : ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(113, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(473, 21);
            this.nameBox.TabIndex = 1;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(113, 59);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(473, 21);
            this.priceBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item : ";
            // 
            // itemBox
            // 
            this.itemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(63, 185);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(523, 23);
            this.itemBox.TabIndex = 5;
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductButton.ImageIndex = 6;
            this.addProductButton.ImageList = this.imageList2;
            this.addProductButton.Location = new System.Drawing.Point(466, 453);
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
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.ImageIndex = 5;
            this.searchButton.ImageList = this.imageList2;
            this.searchButton.Location = new System.Drawing.Point(12, 465);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(190, 42);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Open Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 5;
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(12, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Store";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addProductPanel
            // 
            this.addProductPanel.Controls.Add(this.storeBox);
            this.addProductPanel.Controls.Add(this.label4);
            this.addProductPanel.Controls.Add(this.label1);
            this.addProductPanel.Controls.Add(this.nameBox);
            this.addProductPanel.Controls.Add(this.label2);
            this.addProductPanel.Controls.Add(this.addProductButton);
            this.addProductPanel.Controls.Add(this.priceBox);
            this.addProductPanel.Controls.Add(this.itemBox);
            this.addProductPanel.Controls.Add(this.label3);
            this.addProductPanel.Location = new System.Drawing.Point(208, 12);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(605, 495);
            this.addProductPanel.TabIndex = 17;
            // 
            // storeBox
            // 
            this.storeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeBox.FormattingEnabled = true;
            this.storeBox.Location = new System.Drawing.Point(63, 232);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(523, 23);
            this.storeBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Store : ";
            // 
            // addStorePanel
            // 
            this.addStorePanel.Location = new System.Drawing.Point(14, 162);
            this.addStorePanel.Name = "addStorePanel";
            this.addStorePanel.Size = new System.Drawing.Size(200, 100);
            this.addStorePanel.TabIndex = 18;
            // 
            // StoreOwner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 519);
            this.Controls.Add(this.addStorePanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addProductPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StoreOwner_Form";
            this.Text = "Store Owner";
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
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
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.ComboBox storeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel addStorePanel;
    }
}