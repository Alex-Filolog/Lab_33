namespace NotesApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenNotesFormButton = new Button();
            OpenAuthFormButton = new Button();
            OpenPurchaseFormButton = new Button();
            SuspendLayout();
            // 
            // OpenNotesFormButton
            // 
            OpenNotesFormButton.Location = new Point(12, 12);
            OpenNotesFormButton.Name = "OpenNotesFormButton";
            OpenNotesFormButton.Size = new Size(101, 23);
            OpenNotesFormButton.TabIndex = 0;
            OpenNotesFormButton.Text = "Запись заметки";
            OpenNotesFormButton.UseVisualStyleBackColor = true;
            OpenNotesFormButton.Click += OpenNotesFormButton_Click;
            // 
            // OpenAuthFormButton
            // 
            OpenAuthFormButton.Location = new Point(119, 12);
            OpenAuthFormButton.Name = "OpenAuthFormButton";
            OpenAuthFormButton.Size = new Size(88, 23);
            OpenAuthFormButton.TabIndex = 1;
            OpenAuthFormButton.Text = "Авторизация";
            OpenAuthFormButton.UseVisualStyleBackColor = true;
            OpenAuthFormButton.Click += OpenAuthFormButton_Click;
            // 
            // OpenPurchaseFormButton
            // 
            OpenPurchaseFormButton.Location = new Point(213, 11);
            OpenPurchaseFormButton.Name = "OpenPurchaseFormButton";
            OpenPurchaseFormButton.Size = new Size(122, 23);
            OpenPurchaseFormButton.TabIndex = 2;
            OpenPurchaseFormButton.Text = "Данные о покупках";
            OpenPurchaseFormButton.UseVisualStyleBackColor = true;
            OpenPurchaseFormButton.Click += OpenPurchaseFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 46);
            Controls.Add(OpenPurchaseFormButton);
            Controls.Add(OpenAuthFormButton);
            Controls.Add(OpenNotesFormButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            ResumeLayout(false);
        }

        #endregion

        private Button OpenNotesFormButton;
        private Button OpenAuthFormButton;
        private Button OpenPurchaseFormButton;
    }
}
