using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Statistics.BL.Controller;
using Statistics.BL.Model;

namespace Statistics.WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // добавляем строку в таблицу и заполняем ее

            for (int i = 0; i < Works.newTableElement.Count ; i++)
            {
                int rowNumber = dgvResult.Rows.Add(); //добавляем строку

                dgvResult.Rows[rowNumber].Cells[0].Value = Works.newTableElement[i].String; // Содержимое строки
                dgvResult.Rows[rowNumber].Cells[1].Value = Works.newTableElement[i].Code; //код

                dgvResult.Rows[rowNumber].Cells[2].Value = Works.newDecodingTableElement[i].String;
                dgvResult.Rows[rowNumber].Cells[3].Value = Works.newDecodingTableElement[i].Code;
            }

            lbCount.Text = "Число кодов: " + Works.newTableElement.Count();

            // закодированный текст

            string textCode = string.Empty;

            for (int i = 0; i < Works.newTableCode.Count; i++)
            {
                textCode += Convert.ToString(Works.newTableCode[i]) + Environment.NewLine;
            }

            tbCode.Text = textCode;

            lbCountText.Text = "Число знаков текста: " +  Works.text.Count();
            lbCountCode.Text = "Число кодов в сообщении" + Works.newTableCode.Count();
            lbCompressionRation.Text = "Коэффициент сжатия" + (Convert.ToDouble(Works.text.Count()) / Works.newTableCode.Count());


            tbResult.Text = Works.decodingText;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
