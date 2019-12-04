namespace AmazonWannabe
{
    partial class AdminStats_Form
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
            this.qureryNameLabel = new System.Windows.Forms.Label();
            this.queryType = new System.Windows.Forms.ComboBox();
            this.queryTypeLabel = new System.Windows.Forms.Label();
            this.queryFieldLabel = new System.Windows.Forms.Label();
            this.queryField = new System.Windows.Forms.ComboBox();
            this.queryName = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qureryNameLabel
            // 
            this.qureryNameLabel.AutoSize = true;
            this.qureryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qureryNameLabel.Location = new System.Drawing.Point(12, 25);
            this.qureryNameLabel.Name = "qureryNameLabel";
            this.qureryNameLabel.Size = new System.Drawing.Size(70, 25);
            this.qureryNameLabel.TabIndex = 0;
            this.qureryNameLabel.Text = "Name:";
            // 
            // queryType
            // 
            this.queryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryType.FormattingEnabled = true;
            this.queryType.Items.AddRange(new object[] {
            "max",
            "min",
            "sum",
            "avg"});
            this.queryType.Location = new System.Drawing.Point(88, 71);
            this.queryType.Name = "queryType";
            this.queryType.Size = new System.Drawing.Size(229, 28);
            this.queryType.TabIndex = 1;
            // 
            // queryTypeLabel
            // 
            this.queryTypeLabel.AutoSize = true;
            this.queryTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryTypeLabel.Location = new System.Drawing.Point(12, 71);
            this.queryTypeLabel.Name = "queryTypeLabel";
            this.queryTypeLabel.Size = new System.Drawing.Size(63, 25);
            this.queryTypeLabel.TabIndex = 2;
            this.queryTypeLabel.Text = "Type:";
            // 
            // queryFieldLabel
            // 
            this.queryFieldLabel.AutoSize = true;
            this.queryFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryFieldLabel.Location = new System.Drawing.Point(12, 118);
            this.queryFieldLabel.Name = "queryFieldLabel";
            this.queryFieldLabel.Size = new System.Drawing.Size(54, 25);
            this.queryFieldLabel.TabIndex = 4;
            this.queryFieldLabel.Text = "Field";
            // 
            // queryField
            // 
            this.queryField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryField.FormattingEnabled = true;
            this.queryField.Items.AddRange(new object[] {
            "UserViews",
            "SoldNum"});
            this.queryField.Location = new System.Drawing.Point(88, 118);
            this.queryField.Name = "queryField";
            this.queryField.Size = new System.Drawing.Size(229, 28);
            this.queryField.TabIndex = 3;
            // 
            // queryName
            // 
            this.queryName.Location = new System.Drawing.Point(88, 25);
            this.queryName.Name = "queryName";
            this.queryName.Size = new System.Drawing.Size(229, 26);
            this.queryName.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.ImageIndex = 6;
            this.addButton.Location = new System.Drawing.Point(97, 169);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 42);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AdminStats_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 223);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.queryName);
            this.Controls.Add(this.queryFieldLabel);
            this.Controls.Add(this.queryField);
            this.Controls.Add(this.queryTypeLabel);
            this.Controls.Add(this.queryType);
            this.Controls.Add(this.qureryNameLabel);
            this.Name = "AdminStats_Form";
            this.Text = "AdminStats_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qureryNameLabel;
        private System.Windows.Forms.ComboBox queryType;
        private System.Windows.Forms.Label queryTypeLabel;
        private System.Windows.Forms.Label queryFieldLabel;
        private System.Windows.Forms.ComboBox queryField;
        private System.Windows.Forms.TextBox queryName;
        private System.Windows.Forms.Button addButton;
    }
}