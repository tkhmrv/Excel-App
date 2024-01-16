namespace ExcelApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePathBox = new System.Windows.Forms.TextBox();
            this.excelFilePathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.excelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtButton
            // 
            this.txtButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtButton.Location = new System.Drawing.Point(84, 226);
            this.txtButton.Name = "txtButton";
            this.txtButton.Size = new System.Drawing.Size(275, 46);
            this.txtButton.TabIndex = 2;
            this.txtButton.Text = "Выбрать .txt файл";
            this.txtButton.UseVisualStyleBackColor = false;
            this.txtButton.Click += new System.EventHandler(this.TxtButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название .txt файла:";
            // 
            // txtFilePathBox
            // 
            this.txtFilePathBox.Location = new System.Drawing.Point(84, 180);
            this.txtFilePathBox.Name = "txtFilePathBox";
            this.txtFilePathBox.ReadOnly = true;
            this.txtFilePathBox.Size = new System.Drawing.Size(275, 26);
            this.txtFilePathBox.TabIndex = 4;
            // 
            // excelFilePathBox
            // 
            this.excelFilePathBox.Location = new System.Drawing.Point(441, 180);
            this.excelFilePathBox.Name = "excelFilePathBox";
            this.excelFilePathBox.Size = new System.Drawing.Size(231, 26);
            this.excelFilePathBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(437, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название Excel файла";
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.Color.YellowGreen;
            this.processButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.processButton.Location = new System.Drawing.Point(297, 341);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(206, 46);
            this.processButton.TabIndex = 8;
            this.processButton.Text = "Записать в файл";
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = ".xlsx";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearButton.Location = new System.Drawing.Point(84, 341);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(145, 46);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Очистка";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(79, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(532, 57);
            this.label4.TabIndex = 11;
            this.label4.Text = "Эта программа автоматически записывает данные из файлов с форматом .txt в таблицу" +
    " Excel.";
            // 
            // excelButton
            // 
            this.excelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.excelButton.Location = new System.Drawing.Point(441, 226);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(275, 46);
            this.excelButton.TabIndex = 12;
            this.excelButton.Text = "Выбрать папку сохранения";
            this.excelButton.UseVisualStyleBackColor = false;
            this.excelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Coral;
            this.exitButton.Location = new System.Drawing.Point(571, 341);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 46);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 440);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.excelFilePathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilePathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtButton);
            this.Name = "MainForm";
            this.Text = "Дополнение для Microsoft Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePathBox;
        private System.Windows.Forms.TextBox excelFilePathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button exitButton;
    }
}

