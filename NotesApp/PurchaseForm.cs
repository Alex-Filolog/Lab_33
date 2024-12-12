using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            PurchasesDataGridView.Columns.Add("Product", "Товар");
            PurchasesDataGridView.Columns.Add("Price", "Цена");
            PurchasesDataGridView.Columns.Add("Quantity", "Количество");
        }

        private void SavePurchasesButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvData = new StringBuilder();
                    csvData.AppendLine("Товар,Цена,Количество");

                    foreach (DataGridViewRow row in PurchasesDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string product = row.Cells["Product"]?.Value?.ToString() ?? string.Empty;
                        string price = row.Cells["Price"]?.Value?.ToString() ?? string.Empty;
                        string quantity = row.Cells["Quantity"]?.Value?.ToString() ?? string.Empty;

                        product = EscapeCsvValue(product);
                        price = EscapeCsvValue(price);
                        quantity = EscapeCsvValue(quantity);

                        csvData.AppendLine($"{product},{price},{quantity}");
                    }

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                        {
                            writer.Write(csvData.ToString());
                        }
                        MessageBox.Show("Данные о покупках сохранены!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
                    }
                }
            }
        }

        private string EscapeCsvValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "\"\""; 

            if (value.Contains("\"") || value.Contains(", ") || value.Contains("\n"))
            {
                value = "\"" + value.Replace("\"", "\"\"") +"\"";
            }
            return value;
        }
    }
}