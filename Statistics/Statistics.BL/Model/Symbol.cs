using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.BL.Model
{

    /// <summary>
    /// Класс в котором описывается символы
    /// </summary>
    public class Symbol
    {

        public char SymbolName { get; set; } //имя символа
        public int SymbolCount { get; set; } // количество символов
        public double SymbolChance { get; set; } = 0; // Вероятность выпадения символа
        public double SymbolEntropy { get; set; } = 0; //энтропия




        public Symbol(char symbol)
        {
            SymbolName = symbol;
            SymbolCount = 1;
        }

    }
}
