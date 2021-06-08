namespace Statistics.WF
{
    partial class Form5
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
            this.tbTextResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTextResult
            // 
            this.tbTextResult.Location = new System.Drawing.Point(12, 24);
            this.tbTextResult.Multiline = true;
            this.tbTextResult.Name = "tbTextResult";
            this.tbTextResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextResult.Size = new System.Drawing.Size(776, 414);
            this.tbTextResult.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTextResult);
            this.Name = "Form5";
            this.Text = "Результат декодировани файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextResult;
    }
}