using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Statistics.BL.Model;

namespace Statistics.WF
{
    public partial class Form4 : Form
    {
        string encodedText = string.Empty;

        public Form4()
        {
            InitializeComponent();

            // Добавляем строку в таблицу и заполняем ее

            foreach (KeyValuePair<string, int> keyValue in Works.dictionaryLZ78)
            {
                int rowNumber = dgvResult.Rows.Add(); // добавляем строку

                dgvResult.Rows[rowNumber].Cells[0].Value = keyValue.Key;
                dgvResult.Rows[rowNumber].Cells[1].Value = keyValue.Value;
            }

            foreach (Element_LZ78 item in Works.encodedTextLZ78)
            {
                encodedText += item + Environment.NewLine;
            }

            tbResultCode.Text = encodedText;

            tbResultDecode.Text = Works.DecodedTextLZ78;

            lbCountCode.Text = "Число кодов в словаре: " + Works.dictionaryLZ78.Count;
            lbCountCodeInText.Text = "Число кодов в сообщении: " + Works.encodedTextLZ78.Count;
            lbTextCount.Text = "Число знаков в исходном тексте: " + Works.text.Length;
            lbCompressionRation.Text = "Степень сжатия: " + ((double)Works.text.Length / Works.encodedTextLZ78.Count);
        }
    }
}
