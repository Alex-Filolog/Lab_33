namespace NotesApp
{
    partial class AuthForm
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
            LoginTextBox = new TextBox();
            AuthButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(12, 12);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(200, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // AuthButton
            // 
            AuthButton.Location = new Point(52, 41);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(105, 23);
            AuthButton.TabIndex = 1;
            AuthButton.Text = "Авторизоваться";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 79);
            Controls.Add(AuthButton);
            Controls.Add(LoginTextBox);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private Button AuthButton;
    }
}