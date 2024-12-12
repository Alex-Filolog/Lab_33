using System;
using System.IO;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }

        private void SaveNoteButton_Click(object sender, EventArgs e)
        {
            string filePath = "Notes.txt";

            if (File.Exists(filePath))
            {
                if (MessageBox.Show("Файл Notes.txt существует. Создаётся новый файл с заметками. Продолжить?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(DateTime.Now.ToString());
                    writer.WriteLine(NotesTextBox.Text);
                    writer.WriteLine();
                }

                MessageBox.Show("Заметка записана!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в файл: {ex.Message}");
            }
        }
    }
}