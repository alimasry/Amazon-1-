namespace AmazonWannabe
{
    partial class AddCollaborator_Form
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
            this.collaboratorEmail = new System.Windows.Forms.TextBox();
            this.collaboratorEmailLabel = new System.Windows.Forms.Label();
            this.collaboratorStoreLabel = new System.Windows.Forms.Label();
            this.collaboratorStores = new System.Windows.Forms.ComboBox();
            this.addCollaboratorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // collaboratorEmail
            // 
            this.collaboratorEmail.Location = new System.Drawing.Point(92, 59);
            this.collaboratorEmail.Name = "collaboratorEmail";
            this.collaboratorEmail.Size = new System.Drawing.Size(257, 26);
            this.collaboratorEmail.TabIndex = 0;
            // 
            // collaboratorEmailLabel
            // 
            this.collaboratorEmailLabel.AutoSize = true;
            this.collaboratorEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collaboratorEmailLabel.Location = new System.Drawing.Point(12, 55);
            this.collaboratorEmailLabel.Name = "collaboratorEmailLabel";
            this.collaboratorEmailLabel.Size = new System.Drawing.Size(66, 25);
            this.collaboratorEmailLabel.TabIndex = 1;
            this.collaboratorEmailLabel.Text = "Email:";
            // 
            // collaboratorStoreLabel
            // 
            this.collaboratorStoreLabel.AutoSize = true;
            this.collaboratorStoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collaboratorStoreLabel.Location = new System.Drawing.Point(12, 105);
            this.collaboratorStoreLabel.Name = "collaboratorStoreLabel";
            this.collaboratorStoreLabel.Size = new System.Drawing.Size(65, 25);
            this.collaboratorStoreLabel.TabIndex = 3;
            this.collaboratorStoreLabel.Text = "Store:";
            // 
            // collaboratorStores
            // 
            this.collaboratorStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collaboratorStores.FormattingEnabled = true;
            this.collaboratorStores.Location = new System.Drawing.Point(92, 105);
            this.collaboratorStores.Name = "collaboratorStores";
            this.collaboratorStores.Size = new System.Drawing.Size(257, 28);
            this.collaboratorStores.TabIndex = 4;
            // 
            // addCollaboratorButton
            // 
            this.addCollaboratorButton.Location = new System.Drawing.Point(134, 152);
            this.addCollaboratorButton.Name = "addCollaboratorButton";
            this.addCollaboratorButton.Size = new System.Drawing.Size(98, 35);
            this.addCollaboratorButton.TabIndex = 16;
            this.addCollaboratorButton.Text = "Add";
            this.addCollaboratorButton.UseVisualStyleBackColor = true;
            this.addCollaboratorButton.Click += new System.EventHandler(this.addCollaboratorButton_Click);
            // 
            // AddCollaborator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 199);
            this.Controls.Add(this.addCollaboratorButton);
            this.Controls.Add(this.collaboratorStores);
            this.Controls.Add(this.collaboratorStoreLabel);
            this.Controls.Add(this.collaboratorEmailLabel);
            this.Controls.Add(this.collaboratorEmail);
            this.Name = "AddCollaborator_Form";
            this.Text = "Add Collaborator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox collaboratorEmail;
        private System.Windows.Forms.Label collaboratorEmailLabel;
        private System.Windows.Forms.Label collaboratorStoreLabel;
        private System.Windows.Forms.ComboBox collaboratorStores;
        private System.Windows.Forms.Button addCollaboratorButton;
    }
}