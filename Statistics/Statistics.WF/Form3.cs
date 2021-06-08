using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics.WF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            //добавляем строку в таблицу и заполняем ее

            for (int i = 0; i < Works.elementForTables.Count; i++)
            {
                int rowNumber = dgvResult.Rows.Add(); //добавляем строку

                dgvResult.Rows[rowNumber].Cells[0].Value = Works.elementForTables[i].Symbol;
                dgvResult.Rows[rowNumber].Cells[1].Value = Works.elementForTables[i].ToString();


            }

            // результат кодирования 

            tbResultCode.Text = Works.codeTextHuffman;

            lbCountText.Text = "Число битов в исходном тексте: " + (16 * Works.text.Count());
            lbCountCode.Text = "Число битов в закодированном тексте: " + Works.encoded.Length;
            lbCompressionRation.Text = "Степень сжатия: " + ((16 * Works.text.Count()) / Works.encoded.Length);

            tbResultDecode.Text = Works.decodedTextHuffman;

        }
    }
}
