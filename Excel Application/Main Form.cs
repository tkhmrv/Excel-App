using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ExcelApplication
{
    public partial class MainForm : Form
    {
        private string txtFilePath;
        private string excelFolderPath;

        private readonly OpenFileDialog openFileDialog;
        private readonly FolderBrowserDialog folderBrowserDialog;

        public MainForm()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Выберите текстовый файл"
            };

            folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Выберите папку для сохранения Excel файла"
            };

            // Добавляем обработчик события для текстового поля excelFilePathBox
            excelFilePathBox.TextChanged += ExcelFilePathBox_TextChanged;
        }

        private void ExcelFilePathBox_TextChanged(object sender, EventArgs e)
        {
            string invalidChars = "<>:\"/\\|?*."; // Список недопустимых символов

            string sanitizedText = new string(excelFilePathBox.Text.Where(c => !invalidChars.Contains(c)).ToArray());
            excelFilePathBox.Text = sanitizedText;
        }

        private void TxtButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath = openFileDialog.FileName;
                txtFilePathBox.Text = Path.GetFileName(txtFilePath);
            }
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                excelFolderPath = folderBrowserDialog.SelectedPath;
                excelFilePathBox.Text = "Новый_файл"; // По умолчанию, можно изменить по вашему усмотрению
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Очищаем значения полей и переменных
            txtFilePath = string.Empty;
            excelFolderPath = string.Empty;
            txtFilePathBox.Text = string.Empty;
            excelFilePathBox.Text = string.Empty;
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilePath) && File.Exists(txtFilePath))
            {
                if (!string.IsNullOrEmpty(excelFolderPath) && Directory.Exists(excelFolderPath))
                {
                    string excelFilePath = Path.Combine(excelFolderPath, excelFilePathBox.Text + ".xlsx");

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Лист1");

                        string[] lines = File.ReadAllLines(txtFilePath);
                        int row = 1;

                        foreach (string line in lines)
                        {
                            string[] columns = line.Split(' ');

                            for (int col = 1; col <= columns.Length; col++)
                            {
                                // Попытка преобразовать значение в double
                                if (double.TryParse(columns[col - 1], out double result))
                                {
                                    // Преобразование удалось - это число
                                    worksheet.Cells[row, col].Value = result;
                                }
                                else
                                {
                                    // Преобразование не удалось - это текст или другой тип данных
                                    worksheet.Cells[row, col].Value = columns[col - 1];
                                }
                            }
                            row++;
                        }

                        excelPackage.SaveAs(new FileInfo(excelFilePath));
                    }

                    Process.Start(excelFilePath);
                    //MessageBox.Show("Данные успешно записаны в Excel файл.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Выберите папку для сохранения Excel файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите существующий текстовый файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
