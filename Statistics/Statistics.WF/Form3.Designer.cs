namespace Statistics.WF
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResultCode = new System.Windows.Forms.TextBox();
            this.tbResultDecode = new System.Windows.Forms.TextBox();
            this.lbCountText = new System.Windows.Forms.Label();
            this.lbCountCode = new System.Windows.Forms.Label();
            this.lbCompressionRation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кодовая таблица";
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvResult.Location = new System.Drawing.Point(12, 48);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(244, 397);
            this.dgvResult.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Символ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Код";
            this.Column2.Name = "Column2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результат кодирования";
            // 
            // tbResultCode
            // 
            this.tbResultCode.Location = new System.Drawing.Point(262, 48);
            this.tbResultCode.Multiline = true;
            this.tbResultCode.Name = "tbResultCode";
            this.tbResultCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultCode.Size = new System.Drawing.Size(333, 397);
            this.tbResultCode.TabIndex = 3;
            // 
            // tbResultDecode
            // 
            this.tbResultDecode.Location = new System.Drawing.Point(601, 165);
            this.tbResultDecode.Multiline = true;
            this.tbResultDecode.Name = "tbResultDecode";
            this.tbResultDecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultDecode.Size = new System.Drawing.Size(391, 280);
            this.tbResultDecode.TabIndex = 4;
            // 
            // lbCountText
            // 
            this.lbCountText.AutoSize = true;
            this.lbCountText.Location = new System.Drawing.Point(617, 48);
            this.lbCountText.Name = "lbCountText";
            this.lbCountText.Size = new System.Drawing.Size(35, 13);
            this.lbCountText.TabIndex = 5;
            this.lbCountText.Text = "label3";
            // 
            // lbCountCode
            // 
            this.lbCountCode.AutoSize = true;
            this.lbCountCode.Location = new System.Drawing.Point(617, 78);
            this.lbCountCode.Name = "lbCountCode";
            this.lbCountCode.Size = new System.Drawing.Size(35, 13);
            this.lbCountCode.TabIndex = 6;
            this.lbCountCode.Text = "label3";
            // 
            // lbCompressionRation
            // 
            this.lbCompressionRation.AutoSize = true;
            this.lbCompressionRation.Location = new System.Drawing.Point(873, 63);
            this.lbCompressionRation.Name = "lbCompressionRation";
            this.lbCompressionRation.Size = new System.Drawing.Size(35, 13);
            this.lbCompressionRation.TabIndex = 7;
            this.lbCompressionRation.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат декодирования";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCompressionRation);
            this.Controls.Add(this.lbCountCode);
            this.Controls.Add(this.lbCountText);
            this.Controls.Add(this.tbResultDecode);
            this.Controls.Add(this.tbResultCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Отображение результатов кодирования Хаффмана";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResultCode;
        private System.Windows.Forms.TextBox tbResultDecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lbCountText;
        private System.Windows.Forms.Label lbCountCode;
        private System.Windows.Forms.Label lbCompressionRation;
        private System.Windows.Forms.Label label3;
    }
}