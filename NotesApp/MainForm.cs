using System;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenNotesFormButton_Click(object sender, EventArgs e)
        {
            NotesForm notesForm = new NotesForm();
            notesForm.Show();
        }

        private void OpenAuthFormButton_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
        }

        private void OpenPurchaseFormButton_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.Show();
        }
    }
}
