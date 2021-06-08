using Statistics.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.BL.Controller
{
    /// <summary>
    /// Класс с методами обработки данных символов
    /// </summary>
    public class Methods
    {
        /// <summary>
        /// метод создания списка символов из файла
        /// </summary>
        public static void CreateListenSymbol()
        {
            string path = @"D:\Tolstoy Lev. Anna Karenina.txt"; //путь к файлу

            List<char> tempChar = new List<char>(); //временый

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        tempChar.Add((char)sr.Read());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            int count = tempChar.Count();//число знаков в тексте
            Random rand = new Random();
            int countStart = rand.Next(0, count - 3000); // начальная поозиция для считывания символов

            for (int i = countStart; i < countStart + 2500; i++)
            {
                Alphabet.symbols.Add(tempChar[i]); // получаем список с символами несортированными
            }

            tempChar.Clear();

        }

        /// <summary>
        /// метод сортировки списка с символами из текста
        /// </summary>
        public static void SortingCharacter()
        {
            bool flag = false; // флажок для добавления в список

            foreach (char item in Alphabet.symbols)
            {
                if (Alphabet.character.Count() != 0)
                {
                    foreach (Symbol symbol in Alphabet.character)
                    {
                        if (symbol.SymbolName == item)
                        {
                            symbol.SymbolCount++;

                            flag = true;

                            //break;

                        }
                    }

                    if (!flag)
                    {
                        Alphabet.character.Add(new Symbol(item)); // создаем новый объект экземпляр класса Symbol
                    }
                }

                else
                {
                    Alphabet.character.Add(new Symbol(item)); // создаем новый объект экземпляр класса Symbol
                }

                flag = false;

            }

            NameComparer nc = new NameComparer();

            Alphabet.character.Sort(nc);

        }

        /// <summary>
        /// метод расчета вероятностей
        /// </summary>
        public static void CalculatingProbability()
        {
            foreach (Symbol item in Alphabet.character)
            {
                item.SymbolChance = item.SymbolCount / (double)Alphabet.symbols.Count();

            }
        }
        /// <summary>
        /// метод расчета полной вероятности
        /// </summary>
        /// <returns></returns>
        public static double SumProbability()
        {
            double sum = 0.0;

            foreach (Symbol item in Alphabet.character)
            {
                sum += item.SymbolChance;
            }

            return sum;
        }
        /// <summary>
        /// вычисление количества символов
        /// </summary>
        /// <returns></returns>
        public static int CountSymbols()
        {
            int count = 0;

            foreach (Symbol item in Alphabet.character)
            {
                count += item.SymbolCount;
            }

            return count;
        }

        /// <summary>
        /// метод вычисления энтропии
        /// </summary>
        public static void CalculationEntropy ()
        {
            foreach (Symbol item in Alphabet.character)
            {
                item.SymbolEntropy = item.SymbolChance * (Math.Log(item.SymbolChance, 2));
             }

        }


       public static double CalculationEntropySum()
        {
            double entropy = 0.0;

            foreach (Symbol item in Alphabet.character)
            {
                entropy += item.SymbolEntropy;
            }
            
            return entropy;
        }

        /// <summary>
        /// расчет коэффициента избыточности
        /// </summary>
        public static double MethodRedundancy(double number_1, int number_2)
        {
            double value = 0.0;

            value = 1 - (number_1 / (Math.Log(number_2, 2)));
                       
            return value;
        }

    }
}
