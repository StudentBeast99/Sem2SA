namespace _1._2
{
    partial class FileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenInputBtn = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.OpenOutputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveOutputBtn = new System.Windows.Forms.Button();
            this.SaveInputBtn = new System.Windows.Forms.Button();
            this.WorkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "входной файл(вещественные числа)";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Файл данных (*.dat)|*.dat|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файл данных (*.dat)|*.dat|Все файлы|*.*";
            // 
            // OpenInputBtn
            // 
            this.OpenInputBtn.Location = new System.Drawing.Point(201, 11);
            this.OpenInputBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenInputBtn.Name = "OpenInputBtn";
            this.OpenInputBtn.Size = new System.Drawing.Size(68, 26);
            this.OpenInputBtn.TabIndex = 1;
            this.OpenInputBtn.Text = "открыть ";
            this.OpenInputBtn.UseVisualStyleBackColor = true;
            this.OpenInputBtn.Click += new System.EventHandler(this.OpenInputBtn_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(9, 49);
            this.Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(576, 52);
            this.Input.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(9, 143);
            this.Output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(576, 66);
            this.Output.TabIndex = 5;
            // 
            // OpenOutputFile
            // 
            this.OpenOutputFile.Location = new System.Drawing.Point(201, 105);
            this.OpenOutputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenOutputFile.Name = "OpenOutputFile";
            this.OpenOutputFile.Size = new System.Drawing.Size(68, 26);
            this.OpenOutputFile.TabIndex = 4;
            this.OpenOutputFile.Text = "открыть ";
            this.OpenOutputFile.UseVisualStyleBackColor = true;
            this.OpenOutputFile.Click += new System.EventHandler(this.OpenOutputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "выходной файл(целые числа)";
            // 
            // SaveOutputBtn
            // 
            this.SaveOutputBtn.Location = new System.Drawing.Point(273, 105);
            this.SaveOutputBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveOutputBtn.Name = "SaveOutputBtn";
            this.SaveOutputBtn.Size = new System.Drawing.Size(68, 26);
            this.SaveOutputBtn.TabIndex = 6;
            this.SaveOutputBtn.Text = "сохранить";
            this.SaveOutputBtn.UseVisualStyleBackColor = true;
            this.SaveOutputBtn.Click += new System.EventHandler(this.SaveOutputBtn_Click);
            // 
            // SaveInputBtn
            // 
            this.SaveInputBtn.Location = new System.Drawing.Point(273, 11);
            this.SaveInputBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveInputBtn.Name = "SaveInputBtn";
            this.SaveInputBtn.Size = new System.Drawing.Size(68, 26);
            this.SaveInputBtn.TabIndex = 7;
            this.SaveInputBtn.Text = "сохранить";
            this.SaveInputBtn.UseVisualStyleBackColor = true;
            this.SaveInputBtn.Click += new System.EventHandler(this.SaveInputBtn_Click);
            // 
            // WorkBtn
            // 
            this.WorkBtn.Location = new System.Drawing.Point(398, 11);
            this.WorkBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkBtn.Name = "WorkBtn";
            this.WorkBtn.Size = new System.Drawing.Size(186, 26);
            this.WorkBtn.TabIndex = 8;
            this.WorkBtn.Text = "поменять минимум и максимум";
            this.WorkBtn.UseVisualStyleBackColor = true;
            this.WorkBtn.Click += new System.EventHandler(this.WorkBtn_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 218);
            this.Controls.Add(this.WorkBtn);
            this.Controls.Add(this.SaveInputBtn);
            this.Controls.Add(this.SaveOutputBtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OpenOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.OpenInputBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FileForm";
            this.Text = "File Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button OpenInputBtn;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button OpenOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveOutputBtn;
        private System.Windows.Forms.Button SaveInputBtn;
        private System.Windows.Forms.Button WorkBtn;
    }
}

