using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statistics.BL.Model;

namespace Statistics.BL.Controller
{
   public class LZWalgorithm // здесь работает алгоритм LZW
    {
        static public string textOriginal = string.Empty; // текст исходный

        public string textProcessed = string.Empty; // текст после обработки
        
         string stringNew = string.Empty; //просто пустая строка
        

        public List<TableElement> tableWithSingleSymbols = new List<TableElement>(); // таблица с кодами одиночных символов

        public List<TableElement> tableWithDatesAddedDuringEncoding = new List<TableElement>(); //таблицу с в котороую заносяся неодиночные символы при кодировании

        public List<TableElement> tableWithDatesAddedDuringDecoding = new List<TableElement>(); // таблица в которую заносим неодиночные символы при раскодировании


       public List<int> encodedCharacters = new List<int>(); // сюда заносим закодированные символы


      public  LZWalgorithm( string txt)
        {
            InitilizationMethodDictionary();

            textOriginal = txt;
        }

        /// <summary>
        ///   метод инициализации словаря одиночными символами
        /// </summary>
        void InitilizationMethodDictionary()
        {
            for (int i = 0; i < Alphabet.character.Count; i++)
            {                             
                string stringText = Convert.ToString(Alphabet.character[i].SymbolName); //преобразуем в строку из списка с символами

                // создаем новый TableElement

                tableWithSingleSymbols.Add(new TableElement(stringText, i)); //добовляем в таблицу новый элемент

            }

            tableWithDatesAddedDuringEncoding.AddRange(tableWithSingleSymbols); 
           
        }

    
            /// <summary>
            /// метод кодирования с добавлением символов в словарь
            /// </summary>
       public void EncodedCharacters()
        {
            string previousSymbol = string.Empty; // предыдущий символ/группа символов

            foreach (char  currentSymbol in textOriginal)// перебираме текст который кодируем
            {
                string groupSymbol = previousSymbol + currentSymbol;

                TableElement tempOne = new TableElement(groupSymbol, tableWithDatesAddedDuringEncoding.Count());

                if (tableWithDatesAddedDuringEncoding.Contains(tempOne)) // проверяем существуетли в таблице элемент с со строкой (ключем) как групповая сторока
                {
                    previousSymbol = groupSymbol;
                }

                else
                {
                    TableElement temp = tableWithDatesAddedDuringEncoding.Find(item => item.String == previousSymbol); //получаем элемет

                    encodedCharacters.Add(temp.Code);   //добавляем в кодированный список код  

                    tableWithDatesAddedDuringEncoding.Add(new TableElement(groupSymbol, tableWithDatesAddedDuringEncoding.Count())); // добавляем в таблицу новую строку

                    previousSymbol = currentSymbol.ToString(); //         присвоить значение из текущего предыдущему
                }

            }

            if (!string.IsNullOrEmpty(previousSymbol))
            {
                TableElement temp = tableWithDatesAddedDuringEncoding.Find(item => item.String == previousSymbol); //получаем элемет
                encodedCharacters.Add(temp.Code);
            }

        }


        /// <summary>
        /// метод декодирования с добавлением символов в словарь
        /// </summary>
        public void DecodingCharacters()
        {
            tableWithDatesAddedDuringDecoding.AddRange(tableWithSingleSymbols);

            string previousSymbol = string.Empty; // предыдущий символ/группа символов

            previousSymbol = tableWithDatesAddedDuringDecoding[encodedCharacters[0]].String; //присваиваем предыдушему символу значение из кодированного сообщения в соответсвии с таблицей кодировки

            encodedCharacters.RemoveAt(0); //удаляем нулевой элемент

            StringBuilder decompressed = new StringBuilder(previousSymbol); // создаем строку куда заносим раскодированный текст


            foreach (int  item in encodedCharacters) // перибираем закодированное сообщение
            {

                string entry = null;
                bool flag = false;

                // ишем в таблице  элемент с нужным кодом если есть то flag = true
                foreach (TableElement itemOne in tableWithDatesAddedDuringDecoding)
                {
                   flag = itemOne.EqualsSecond(new TableElement("Любая строка", item));

                }

                if (flag)
                {

                    //добавляем в запись сроку соответств коду

                    TableElement temp = tableWithDatesAddedDuringDecoding.Find(itemSecond => itemSecond.Code == item);
                    
                    entry = temp.String;

                 }

                else if (item == tableWithDatesAddedDuringDecoding.Count())
                {
                    entry = previousSymbol + previousSymbol[0];
                }

                decompressed.Append(entry);

                tableWithDatesAddedDuringDecoding.Add(new TableElement(previousSymbol + entry[0], tableWithDatesAddedDuringDecoding.Count()));

                previousSymbol = entry;
            }

            textProcessed = String.Copy(Convert.ToString(decompressed));

        }








    }
}
