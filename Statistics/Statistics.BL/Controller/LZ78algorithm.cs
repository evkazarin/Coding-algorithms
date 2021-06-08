using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statistics.BL.Model;

namespace Statistics.BL.Controller
{
  public  class LZ78algorithm
    {
         /// <summary>
        /// список с закодированным текстом содержит пары из словаря номер префикса и следующий символ
        /// </summary>
       public List<Element_LZ78> encodedText = new List<Element_LZ78>();

        /// <summary>
        /// Словарь в котором храним пару ключ (строку - префикс ) и число 
        /// </summary>
       public Dictionary<string, int> dictionary = new Dictionary<string, int>();

        /// <summary>
        /// Словарь заполняемый при расшифровке
        /// </summary>
        public Dictionary<int, string> dictionaryOne = new Dictionary<int, string>();

        /// <summary>
        /// раскодированная строка
        /// </summary>
        public string DecodingText { get; set; } = string.Empty;

        /// <summary>
        /// метод кодирования LZ78
        /// </summary>
        /// <param name="text"></param>
        public void EncodingMethod(string text)
        {
            string buffer = string.Empty; //текущий префикс

            for(int i = 0; i < text.Length; i++)
            {
              if(dictionary.ContainsKey(buffer + text[i])) // естли в словаре такакя строка
                {                  
                    buffer += text[i]; //добавить в буфер текущий символ
                }

                else
                {
                    dictionary.Add(buffer + text[i], dictionary.Count() + 1); // добавляем пару в словарь
                    // добавляем закодированную последовательность  в список

                     if (!String.IsNullOrEmpty(buffer)) //если буфер не пуст то этот символ добавить в последовательность
                     {
                        // char lastChar = buffer[buffer.Length]; //берем послединй символ буфера как новый символ

                         buffer.Remove(buffer.Length - 1); //удалить последний символ буфера

                         encodedText.Add(new Element_LZ78(dictionary[buffer], Convert.ToString(text[i])));     // добавить в список код
                     }

                    else //если буфер  пуст то
                    {
                        encodedText.Add(new Element_LZ78(0, Convert.ToString(text[i])));
                    }

                    buffer = string.Empty;
               }
            }
        }

        /// <summary>
        /// Метод декодирования LZ78
        /// </summary>
        /// <param name="element_LZ78"></param>
        public string DecodingMethod(List<Element_LZ78> obj)
        {
            string text = string.Empty;
            int nuber = 1;

            foreach (Element_LZ78 item in obj)
            {
                if (item.NumberPrefix == 0) //если значение префикса == 0
                {
                    dictionaryOne.Add(nuber, item.NextSymbol); // добавляем в словарь пару с ключем number  и значением item.NextSymbol
                    nuber++;
                    text += item.NextSymbol; //добавляем в текст последовательность символов
                }

                else
                {
                    string tempWord = dictionaryOne[item.NumberPrefix] + item.NextSymbol; //формируем последовательность из символов словаря и текущего символа
                    dictionaryOne.Add(nuber, tempWord); // добавляем в соварь новую последовательность символов
                    nuber++;
                    text += tempWord; // добавляем к тексту символы
                }
            }

            return text;
        }

    }
}
