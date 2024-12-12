namespace NotesApp
{
    partial class PurchaseForm
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
            PurchasesDataGridView = new DataGridView();
            SavePurchasesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PurchasesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PurchasesDataGridView
            // 
            PurchasesDataGridView.BackgroundColor = Color.White;
            PurchasesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurchasesDataGridView.GridColor = Color.White;
            PurchasesDataGridView.Location = new Point(12, 12);
            PurchasesDataGridView.Name = "PurchasesDataGridView";
            PurchasesDataGridView.Size = new Size(400, 400);
            PurchasesDataGridView.TabIndex = 0;
            // 
            // SavePurchasesButton
            // 
            SavePurchasesButton.Location = new Point(176, 418);
            SavePurchasesButton.Name = "SavePurchasesButton";
            SavePurchasesButton.Size = new Size(75, 23);
            SavePurchasesButton.TabIndex = 1;
            SavePurchasesButton.Text = "Сохранить";
            SavePurchasesButton.UseVisualStyleBackColor = true;
            SavePurchasesButton.Click += SavePurchasesButton_Click;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 447);
            Controls.Add(SavePurchasesButton);
            Controls.Add(PurchasesDataGridView);
            Name = "PurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Данные о покупках";
            ((System.ComponentModel.ISupportInitialize)PurchasesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PurchasesDataGridView;
        private Button SavePurchasesButton;
    }
}