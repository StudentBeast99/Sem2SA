namespace _4
{
    partial class SortsForm
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
            this.Output = new System.Windows.Forms.PictureBox();
            this.BubleSort = new System.Windows.Forms.Button();
            this.Shaker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 53);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(776, 385);
            this.Output.TabIndex = 0;
            this.Output.TabStop = false;
            // 
            // BubleSort
            // 
            this.BubleSort.Location = new System.Drawing.Point(12, 12);
            this.BubleSort.Name = "BubleSort";
            this.BubleSort.Size = new System.Drawing.Size(75, 23);
            this.BubleSort.TabIndex = 1;
            this.BubleSort.Text = "Пузырьком";
            this.BubleSort.UseVisualStyleBackColor = true;
            this.BubleSort.Click += new System.EventHandler(this.BubleSort_Click);
            // 
            // Shaker
            // 
            this.Shaker.Location = new System.Drawing.Point(93, 12);
            this.Shaker.Name = "Shaker";
            this.Shaker.Size = new System.Drawing.Size(75, 23);
            this.Shaker.TabIndex = 2;
            this.Shaker.Text = "Шейкер";
            this.Shaker.UseVisualStyleBackColor = true;
            this.Shaker.Click += new System.EventHandler(this.BubleSort_Click);
            // 
            // SortsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Shaker);
            this.Controls.Add(this.BubleSort);
            this.Controls.Add(this.Output);
            this.Name = "SortsForm";
            this.Text = "Sorts";
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Output;
        private System.Windows.Forms.Button BubleSort;
        private System.Windows.Forms.Button Shaker;
    }
}

