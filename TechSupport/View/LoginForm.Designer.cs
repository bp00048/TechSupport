
namespace TechSupport.View
{
    partial class LoginForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.MaskedTextBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.formLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(190, 0);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(158, 36);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.UseMnemonic = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(193, 36);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(155, 36);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameTextbox.Location = new System.Drawing.Point(356, 5);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(148, 26);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.UserInputEntered);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextbox.Location = new System.Drawing.Point(356, 41);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(148, 26);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.UserInputEntered);
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessage.AutoSize = true;
            this.formLayout.SetColumnSpan(this.errorMessage, 2);
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(352, 72);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 25);
            this.errorMessage.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSize = true;
            this.formLayout.SetColumnSpan(this.loginButton, 2);
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(264, 107);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(176, 62);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginSubmit);
            // 
            // formLayout
            // 
            this.formLayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.formLayout.ColumnCount = 2;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.Controls.Add(this.usernameLabel, 0, 0);
            this.formLayout.Controls.Add(this.errorMessage, 0, 2);
            this.formLayout.Controls.Add(this.loginButton, 0, 3);
            this.formLayout.Controls.Add(this.usernameTextbox, 1, 0);
            this.formLayout.Controls.Add(this.passwordLabel, 0, 1);
            this.formLayout.Controls.Add(this.passwordTextbox, 1, 1);
            this.formLayout.Location = new System.Drawing.Point(4, 171);
            this.formLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formLayout.Name = "formLayout";
            this.formLayout.RowCount = 4;
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayout.Size = new System.Drawing.Size(704, 180);
            this.formLayout.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 555);
            this.Controls.Add(this.formLayout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.formLayout.ResumeLayout(false);
            this.formLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.MaskedTextBox passwordTextbox;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TableLayoutPanel formLayout;
    }
}