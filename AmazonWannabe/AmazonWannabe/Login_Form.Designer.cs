namespace AmazonWannabe
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.userLoginBox = new System.Windows.Forms.TextBox();
            this.passLoginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.userRegisterBox = new System.Windows.Forms.TextBox();
            this.emailRegisterBox = new System.Windows.Forms.TextBox();
            this.passRegisterBox = new System.Windows.Forms.TextBox();
            this.confpassRegisterBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.closeButton2 = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLoginBox
            // 
            this.userLoginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLoginBox.Location = new System.Drawing.Point(92, 105);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(588, 21);
            this.userLoginBox.TabIndex = 0;
            // 
            // passLoginBox
            // 
            this.passLoginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passLoginBox.Location = new System.Drawing.Point(92, 169);
            this.passLoginBox.Name = "passLoginBox";
            this.passLoginBox.Size = new System.Drawing.Size(588, 21);
            this.passLoginBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password : ";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.ImageKey = "login.png";
            this.loginButton.ImageList = this.imageList1;
            this.loginButton.Location = new System.Drawing.Point(353, 390);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(196, 42);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.ImageIndex = 0;
            this.closeButton.ImageList = this.imageList1;
            this.closeButton.Location = new System.Drawing.Point(555, 390);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 42);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.LinkColor = System.Drawing.Color.Black;
            this.registerLink.Location = new System.Drawing.Point(12, 405);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(54, 15);
            this.registerLink.TabIndex = 6;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Register";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.backButton);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Controls.Add(this.closeButton2);
            this.registerPanel.Controls.Add(this.label6);
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Controls.Add(this.label4);
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Controls.Add(this.confpassRegisterBox);
            this.registerPanel.Controls.Add(this.passRegisterBox);
            this.registerPanel.Controls.Add(this.emailRegisterBox);
            this.registerPanel.Controls.Add(this.userRegisterBox);
            this.registerPanel.Location = new System.Drawing.Point(12, 12);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(668, 420);
            this.registerPanel.TabIndex = 7;
            // 
            // userRegisterBox
            // 
            this.userRegisterBox.Location = new System.Drawing.Point(119, 66);
            this.userRegisterBox.Name = "userRegisterBox";
            this.userRegisterBox.Size = new System.Drawing.Size(549, 21);
            this.userRegisterBox.TabIndex = 0;
            // 
            // emailRegisterBox
            // 
            this.emailRegisterBox.Location = new System.Drawing.Point(119, 113);
            this.emailRegisterBox.Name = "emailRegisterBox";
            this.emailRegisterBox.Size = new System.Drawing.Size(549, 21);
            this.emailRegisterBox.TabIndex = 1;
            // 
            // passRegisterBox
            // 
            this.passRegisterBox.Location = new System.Drawing.Point(119, 160);
            this.passRegisterBox.Name = "passRegisterBox";
            this.passRegisterBox.Size = new System.Drawing.Size(549, 21);
            this.passRegisterBox.TabIndex = 2;
            // 
            // confpassRegisterBox
            // 
            this.confpassRegisterBox.Location = new System.Drawing.Point(119, 207);
            this.confpassRegisterBox.Name = "confpassRegisterBox";
            this.confpassRegisterBox.Size = new System.Drawing.Size(549, 21);
            this.confpassRegisterBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email : ";
            // 
            // closeButton2
            // 
            this.closeButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton2.ImageKey = "close.png";
            this.closeButton2.ImageList = this.imageList1;
            this.closeButton2.Location = new System.Drawing.Point(543, 378);
            this.closeButton2.Name = "closeButton2";
            this.closeButton2.Size = new System.Drawing.Size(125, 42);
            this.closeButton2.TabIndex = 8;
            this.closeButton2.Text = "Close";
            this.closeButton2.UseVisualStyleBackColor = true;
            this.closeButton2.Click += new System.EventHandler(this.closeButton2_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerButton.ImageKey = "clipboard.png";
            this.registerButton.ImageList = this.imageList1;
            this.registerButton.Location = new System.Drawing.Point(341, 378);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(196, 42);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.ImageIndex = 2;
            this.backButton.ImageList = this.imageList1;
            this.backButton.Location = new System.Drawing.Point(0, 378);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(48, 42);
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 444);
            this.ControlBox = false;
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLoginBox);
            this.Controls.Add(this.userLoginBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login_Form";
            this.Text = "Login";
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userLoginBox;
        private System.Windows.Forms.TextBox passLoginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button closeButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confpassRegisterBox;
        private System.Windows.Forms.TextBox passRegisterBox;
        private System.Windows.Forms.TextBox emailRegisterBox;
        private System.Windows.Forms.TextBox userRegisterBox;
        private System.Windows.Forms.Button backButton;
    }
}

