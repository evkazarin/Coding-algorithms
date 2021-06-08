namespace Statistics.WF
{
    partial class Form4
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResultCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResultDecode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCountCode = new System.Windows.Forms.Label();
            this.lbCountCodeInText = new System.Windows.Forms.Label();
            this.lbTextCount = new System.Windows.Forms.Label();
            this.lbCompressionRation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvResult.Location = new System.Drawing.Point(12, 56);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(243, 382);
            this.dgvResult.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Префикс";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер префикса";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кодовая таблица";
            // 
            // tbResultCode
            // 
            this.tbResultCode.Location = new System.Drawing.Point(261, 56);
            this.tbResultCode.Multiline = true;
            this.tbResultCode.Name = "tbResultCode";
            this.tbResultCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultCode.Size = new System.Drawing.Size(277, 382);
            this.tbResultCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат кодирования";
            // 
            // tbResultDecode
            // 
            this.tbResultDecode.Location = new System.Drawing.Point(544, 175);
            this.tbResultDecode.Multiline = true;
            this.tbResultDecode.Name = "tbResultDecode";
            this.tbResultDecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultDecode.Size = new System.Drawing.Size(479, 263);
            this.tbResultDecode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат декодирования";
            // 
            // lbCountCode
            // 
            this.lbCountCode.AutoSize = true;
            this.lbCountCode.Location = new System.Drawing.Point(502, 13);
            this.lbCountCode.Name = "lbCountCode";
            this.lbCountCode.Size = new System.Drawing.Size(72, 13);
            this.lbCountCode.TabIndex = 6;
            this.lbCountCode.Text = "Число кодов";
            // 
            // lbCountCodeInText
            // 
            this.lbCountCodeInText.AutoSize = true;
            this.lbCountCodeInText.Location = new System.Drawing.Point(502, 30);
            this.lbCountCodeInText.Name = "lbCountCodeInText";
            this.lbCountCodeInText.Size = new System.Drawing.Size(35, 13);
            this.lbCountCodeInText.TabIndex = 7;
            this.lbCountCodeInText.Text = "label4";
            // 
            // lbTextCount
            // 
            this.lbTextCount.AutoSize = true;
            this.lbTextCount.Location = new System.Drawing.Point(678, 13);
            this.lbTextCount.Name = "lbTextCount";
            this.lbTextCount.Size = new System.Drawing.Size(35, 13);
            this.lbTextCount.TabIndex = 8;
            this.lbTextCount.Text = "label4";
            // 
            // lbCompressionRation
            // 
            this.lbCompressionRation.AutoSize = true;
            this.lbCompressionRation.Location = new System.Drawing.Point(911, 13);
            this.lbCompressionRation.Name = "lbCompressionRation";
            this.lbCompressionRation.Size = new System.Drawing.Size(35, 13);
            this.lbCompressionRation.TabIndex = 9;
            this.lbCompressionRation.Text = "label4";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.lbCompressionRation);
            this.Controls.Add(this.lbTextCount);
            this.Controls.Add(this.lbCountCodeInText);
            this.Controls.Add(this.lbCountCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResultDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResultCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResult);
            this.Name = "Form4";
            this.Text = "Отображение результатов кодирования LZ78";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResultCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResultDecode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCountCode;
        private System.Windows.Forms.Label lbCountCodeInText;
        private System.Windows.Forms.Label lbTextCount;
        private System.Windows.Forms.Label lbCompressionRation;
    }
}