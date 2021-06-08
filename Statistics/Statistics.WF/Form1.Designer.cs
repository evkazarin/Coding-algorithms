namespace Statistics.WF
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
            this.tbTextForAnalysis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.btLearning = new System.Windows.Forms.Button();
            this.dgvTabl = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btCode = new System.Windows.Forms.Button();
            this.btCodeHuffman = new System.Windows.Forms.Button();
            this.btLZ78 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюРаботыСФайломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлЗакодированныйLZ78ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИДекодироватьLZ78ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTextForAnalysis
            // 
            this.tbTextForAnalysis.Location = new System.Drawing.Point(0, 119);
            this.tbTextForAnalysis.Multiline = true;
            this.tbTextForAnalysis.Name = "tbTextForAnalysis";
            this.tbTextForAnalysis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTextForAnalysis.Size = new System.Drawing.Size(313, 355);
            this.tbTextForAnalysis.TabIndex = 0;
            this.tbTextForAnalysis.Text = "е";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный текст для анализа";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(0, 480);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(130, 35);
            this.btGenerate.TabIndex = 2;
            this.btGenerate.Text = "Генерировать текст";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.BtGenerate_Click);
            // 
            // btLearning
            // 
            this.btLearning.Location = new System.Drawing.Point(319, 479);
            this.btLearning.Name = "btLearning";
            this.btLearning.Size = new System.Drawing.Size(75, 23);
            this.btLearning.TabIndex = 3;
            this.btLearning.Text = "Изучение";
            this.btLearning.UseVisualStyleBackColor = true;
            this.btLearning.Click += new System.EventHandler(this.BtLearning_Click);
            // 
            // dgvTabl
            // 
            this.dgvTabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTabl.Location = new System.Drawing.Point(319, 119);
            this.dgvTabl.Name = "dgvTabl";
            this.dgvTabl.Size = new System.Drawing.Size(726, 355);
            this.dgvTabl.TabIndex = 4;
            this.dgvTabl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabl_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Символ ai";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N( ai)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "P(ai)";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "P(ai)*log(P(ai))";
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(406, 479);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(75, 23);
            this.btExcel.TabIndex = 5;
            this.btExcel.Text = "В Excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.BtExcel_Click);
            // 
            // btCode
            // 
            this.btCode.Location = new System.Drawing.Point(493, 479);
            this.btCode.Name = "btCode";
            this.btCode.Size = new System.Drawing.Size(105, 23);
            this.btCode.TabIndex = 6;
            this.btCode.Text = "Кодировать LZW";
            this.btCode.UseVisualStyleBackColor = true;
            this.btCode.Click += new System.EventHandler(this.BtCode_Click);
            // 
            // btCodeHuffman
            // 
            this.btCodeHuffman.Location = new System.Drawing.Point(610, 479);
            this.btCodeHuffman.Name = "btCodeHuffman";
            this.btCodeHuffman.Size = new System.Drawing.Size(145, 23);
            this.btCodeHuffman.TabIndex = 7;
            this.btCodeHuffman.Text = "Кодирование Хаффмана";
            this.btCodeHuffman.UseVisualStyleBackColor = true;
            this.btCodeHuffman.Click += new System.EventHandler(this.BtCodeHuffman_Click);
            // 
            // btLZ78
            // 
            this.btLZ78.Location = new System.Drawing.Point(767, 479);
            this.btLZ78.Name = "btLZ78";
            this.btLZ78.Size = new System.Drawing.Size(115, 23);
            this.btLZ78.TabIndex = 8;
            this.btLZ78.Text = "Кодировать LZ78";
            this.btLZ78.UseVisualStyleBackColor = true;
            this.btLZ78.Click += new System.EventHandler(this.BtLZ78_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюРаботыСФайломToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюРаботыСФайломToolStripMenuItem
            // 
            this.менюРаботыСФайломToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьФайлЗакодированныйLZ78ToolStripMenuItem,
            this.открытьИДекодироватьLZ78ToolStripMenuItem});
            this.менюРаботыСФайломToolStripMenuItem.Name = "менюРаботыСФайломToolStripMenuItem";
            this.менюРаботыСФайломToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.менюРаботыСФайломToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьФайлЗакодированныйLZ78ToolStripMenuItem
            // 
            this.сохранитьФайлЗакодированныйLZ78ToolStripMenuItem.Name = "сохранитьФайлЗакодированныйLZ78ToolStripMenuItem";
            this.сохранитьФайлЗакодированныйLZ78ToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.сохранитьФайлЗакодированныйLZ78ToolStripMenuItem.Text = "Сохранить файл закодированный LZ78";
            this.сохранитьФайлЗакодированныйLZ78ToolStripMenuItem.Click += new System.EventHandler(this.СохранитьФайлЗакодированныйLZ78ToolStripMenuItem_Click);
            // 
            // открытьИДекодироватьLZ78ToolStripMenuItem
            // 
            this.открытьИДекодироватьLZ78ToolStripMenuItem.Name = "открытьИДекодироватьLZ78ToolStripMenuItem";
            this.открытьИДекодироватьLZ78ToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.открытьИДекодироватьLZ78ToolStripMenuItem.Text = "Открыть и декодировать LZ78";
            this.открытьИДекодироватьLZ78ToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьИДекодироватьLZ78ToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.оПрограммеToolStripMenuItem.Text = "Help";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 524);
            this.Controls.Add(this.btLZ78);
            this.Controls.Add(this.btCodeHuffman);
            this.Controls.Add(this.btCode);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.dgvTabl);
            this.Controls.Add(this.btLearning);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTextForAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Изучение статистических характеристик дискретных сообщений  и кодирования информа" +
    "ции";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextForAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button btLearning;
        private System.Windows.Forms.DataGridView dgvTabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btCode;
        private System.Windows.Forms.Button btCodeHuffman;
        private System.Windows.Forms.Button btLZ78;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюРаботыСФайломToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлЗакодированныйLZ78ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИДекодироватьLZ78ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

