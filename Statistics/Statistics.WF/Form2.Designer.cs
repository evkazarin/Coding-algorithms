namespace Statistics.WF
{
    partial class Form2
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCountText = new System.Windows.Forms.Label();
            this.lbCountCode = new System.Windows.Forms.Label();
            this.lbCompressionRation = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
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
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvResult.Location = new System.Drawing.Point(12, 55);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(442, 383);
            this.dgvResult.TabIndex = 1;
            this.dgvResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Содержимое строки исходное";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Код строки";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Содержимое строки декодированное";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Код строки";
            this.Column4.Name = "Column4";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(166, 24);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(35, 13);
            this.lbCount.TabIndex = 2;
            this.lbCount.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Закодированный текст";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(460, 55);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCode.Size = new System.Drawing.Size(227, 383);
            this.tbCode.TabIndex = 5;
            // 
            // lbCountText
            // 
            this.lbCountText.AutoSize = true;
            this.lbCountText.Location = new System.Drawing.Point(691, 24);
            this.lbCountText.Name = "lbCountText";
            this.lbCountText.Size = new System.Drawing.Size(35, 13);
            this.lbCountText.TabIndex = 6;
            this.lbCountText.Text = "label3";
            // 
            // lbCountCode
            // 
            this.lbCountCode.AutoSize = true;
            this.lbCountCode.Location = new System.Drawing.Point(693, 55);
            this.lbCountCode.Name = "lbCountCode";
            this.lbCountCode.Size = new System.Drawing.Size(35, 13);
            this.lbCountCode.TabIndex = 7;
            this.lbCountCode.Text = "label3";
            // 
            // lbCompressionRation
            // 
            this.lbCompressionRation.AutoSize = true;
            this.lbCompressionRation.Location = new System.Drawing.Point(839, 37);
            this.lbCompressionRation.Name = "lbCompressionRation";
            this.lbCompressionRation.Size = new System.Drawing.Size(35, 13);
            this.lbCompressionRation.TabIndex = 8;
            this.lbCompressionRation.Text = "label3";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(694, 140);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(311, 298);
            this.tbResult.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Результат декодирования";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbCompressionRation);
            this.Controls.Add(this.lbCountCode);
            this.Controls.Add(this.lbCountText);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Отображение результатов кодирования LWZ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCountText;
        private System.Windows.Forms.Label lbCountCode;
        private System.Windows.Forms.Label lbCompressionRation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
    }
}