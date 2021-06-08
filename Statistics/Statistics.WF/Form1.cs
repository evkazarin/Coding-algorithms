using Statistics.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Statistics.BL.Controller;


using Excel = Microsoft.Office.Interop.Excel;

namespace Statistics.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvTabl.Visible = false;
            btLearning.Visible = false;
            btExcel.Visible = false;
            btCode.Visible = false;
            btCodeHuffman.Visible = false;
            btLZ78.Visible = false;

            saveFileDialog1.Filter = "Code files(*.LZ78)|*.LZ78";
            openFileDialog1.Filter = "Code files(*.LZ78)|*.LZ78";

        }

        private void BtGenerate_Click(object sender, EventArgs e)
        {
            tbTextForAnalysis.Text = String.Empty;
            Works.MethodGenerateText();
            tbTextForAnalysis.Text = Works.text;
            btLearning.Visible = true;
        }

        private void BtLearning_Click(object sender, EventArgs e)
        {
            Works.MethodLearning();
            btExcel.Visible = true;

            dgvTabl.Visible = true;
            btCode.Visible = true;
            btCodeHuffman.Visible = true;
            btLZ78.Visible = true;

            // добавляем строки и заполняем их

            for (int i  = 0; i  < Alphabet.character.Count(); i ++)
            {
                int rowNumber = dgvTabl.Rows.Add(); //добавляем строку и получаем ее номер

                dgvTabl.Rows[rowNumber].Cells[0].Value = (Alphabet.character[i].SymbolName);//Convert.ToString
                dgvTabl.Rows[rowNumber].Cells[1].Value = Alphabet.character[i].SymbolCount;
                dgvTabl.Rows[rowNumber].Cells[2].Value = Alphabet.character[i].SymbolChance;
                dgvTabl.Rows[rowNumber].Cells[3].Value = Alphabet.character[i].SymbolEntropy;
            }

            int rowNumberFinal = dgvTabl.Rows.Add();

            dgvTabl.Rows[rowNumberFinal].Cells[1].Value = "Количество символов: " + Works.CountSymbols;
            dgvTabl.Rows[rowNumberFinal].Cells[2].Value = "Вероятность: " + Works.SumProbability;
            dgvTabl.Rows[rowNumberFinal].Cells[3].Value = "Энтропия" + Works.SumEntropy;

            // расчитаем коэффициент избыточностси

            int rowNumberFinalOff = dgvTabl.Rows.Add();

            dgvTabl.Rows[rowNumberFinalOff].Cells[2].Value = "Коэфф. изб.: " + Works.CoefficientOfRedundancy;
        }

        private void DgvTabl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Книга Excel(*.xlsx.)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return; // запускаем окно сохранения файла

           string path = saveFileDialog1.FileName; //получаем дорожку

            Excel.Application ExcelApp = new Excel.Application(); // создаем книгу таблицу
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dgvTabl.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTabl.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dgvTabl.Rows[i].Cells[j].Value;
                }
            }

            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

            ExcelWorkSheet.SaveAs(path); //сохраняем в файл

            ExcelApp.Quit(); // завершаем работу с книгой
        }

        private void BtCode_Click(object sender, EventArgs e)
        {
            Works.StartCode(); // начинаем кодировать
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }

        private void BtCodeHuffman_Click(object sender, EventArgs e)
        {
            Works.StartHuffman();

            Form3 newForm = new Form3();
            newForm.ShowDialog();
        }

        private void BtLZ78_Click(object sender, EventArgs e)
        {
            Works.StartLZ78();

            Form4 newForm = new Form4();
            newForm.ShowDialog();

            
        }

        private void ОПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void СохранитьФайлЗакодированныйLZ78ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string fileName = saveFileDialog1.FileName; // получили имя файла


            // запись в файл
            using (FileStream fStream = new FileStream(fileName, FileMode.Create))
            {
                fStream.Write(Works.byteArrayThree, 0, Works.byteArrayThree.Length); //записываем в файл

                MessageBox.Show("Файл сохранен");
            }


        }

        private void ОткрытьИДекодироватьLZ78ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string fileName = openFileDialog1.FileName; //получаем имя файла

            // чтение из файла

            using(FileStream fStream = new FileStream(fileName, FileMode.Open))
            {
                Works.byteArrayFromFile = new byte[fStream.Length]; //создаем массив с нужной длиной

                fStream.Read(Works.byteArrayFromFile, 0, Works.byteArrayFromFile.Length); // записываем в массив из файла

            }

            Works.DecodingFromFile(); // вызов метода декодирования файла

            Form5 newForm = new Form5();
            newForm.ShowDialog();

        }
    }
}
