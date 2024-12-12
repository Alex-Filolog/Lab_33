using System;
using System.IO;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string loginFilePath = "logins.txt";
            bool isValidLogin = false;

            if (File.Exists(loginFilePath))
            {
                try
                {
                    foreach (var line in File.ReadLines(loginFilePath))
                    {
                        if (line.Equals(LoginTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            isValidLogin = true;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Файл logins.txt не найден.");
                return;
            }

            if (isValidLogin)
            {
                MessageBox.Show($"Добро пожаловать, {LoginTextBox.Text}!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Некорректный логин.");
            }
        }
    }
}
