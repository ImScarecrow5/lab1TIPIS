namespace WindowsFormsApp3
{
    partial class Form1
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
            this.lblFile = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSample = new System.Windows.Forms.Label();
            this.txtSampleSize = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 31);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(82, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Расположение";
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(100, 28);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(566, 20);
            this.textFileName.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(672, 25);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(116, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Выбрать файл";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(12, 79);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(127, 13);
            this.lblSample.TabIndex = 3;
            this.lblSample.Text = "Символов для анализа:";
            // 
            // txtSampleSize
            // 
            this.txtSampleSize.Location = new System.Drawing.Point(145, 77);
            this.txtSampleSize.Name = "txtSampleSize";
            this.txtSampleSize.Size = new System.Drawing.Size(144, 20);
            this.txtSampleSize.TabIndex = 4;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(307, 75);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 5;
            this.btnAnalyze.Text = "Анализ";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 128);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(773, 310);
            this.txtResult.TabIndex = 7;
            this.txtResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtSampleSize);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.lblFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.TextBox txtSampleSize;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}

