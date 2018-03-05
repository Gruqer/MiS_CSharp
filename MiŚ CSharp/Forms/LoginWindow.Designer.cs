namespace MiŚ.UI
{
    partial class LoginWindow
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
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginUsernameText = new System.Windows.Forms.TextBox();
            this.loginPasswordText = new System.Windows.Forms.TextBox();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTitleLabel
            // 
            this.loginTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTitleLabel.AutoSize = true;
            this.loginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTitleLabel.Location = new System.Drawing.Point(151, 30);
            this.loginTitleLabel.Name = "loginTitleLabel";
            this.loginTitleLabel.Size = new System.Drawing.Size(152, 18);
            this.loginTitleLabel.TabIndex = 0;
            this.loginTitleLabel.Text = "Witaj w systemie MiŚ!";
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Location = new System.Drawing.Point(56, 85);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(105, 13);
            this.loginUsernameLabel.TabIndex = 1;
            this.loginUsernameLabel.Text = "Nazwa użytkownika:";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(189, 199);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(77, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Zaloguj się";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginPressed);
            // 
            // loginUsernameText
            // 
            this.loginUsernameText.Location = new System.Drawing.Point(177, 82);
            this.loginUsernameText.Name = "loginUsernameText";
            this.loginUsernameText.Size = new System.Drawing.Size(100, 20);
            this.loginUsernameText.TabIndex = 3;
            // 
            // loginPasswordText
            // 
            this.loginPasswordText.Location = new System.Drawing.Point(177, 148);
            this.loginPasswordText.Name = "loginPasswordText";
            this.loginPasswordText.PasswordChar = '●';
            this.loginPasswordText.Size = new System.Drawing.Size(100, 20);
            this.loginPasswordText.TabIndex = 4;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(122, 151);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(39, 13);
            this.loginPasswordLabel.TabIndex = 5;
            this.loginPasswordLabel.Text = "Hasło:";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginPasswordText);
            this.Controls.Add(this.loginUsernameText);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginUsernameLabel);
            this.Controls.Add(this.loginTitleLabel);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "LoginWindow";
            this.Text = "MiŚ - Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTitleLabel;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginUsernameText;
        private System.Windows.Forms.TextBox loginPasswordText;
        private System.Windows.Forms.Label loginPasswordLabel;
    }
}

