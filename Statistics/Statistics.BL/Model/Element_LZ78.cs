using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.BL.Model
{
   public class Element_LZ78 //элемент закодированного значения 
    {
        /// <summary>
        /// номер префикса в словаре
        /// </summary>
        public int NumberPrefix { get; set; }

        /// <summary>
        /// Число вхождений префикса в код
        /// </summary>
        public int NumberOfUses { get; set; } = 0;

        /// <summary>
        /// символ следующий за префиксом
        /// </summary>
        public string NextSymbol { get; set; }

        public Element_LZ78(int numberPrefix, string nextSymbol)
        {
            NumberPrefix = numberPrefix;
            NextSymbol = nextSymbol;
        }

        public override string ToString()
        {
            string code = string.Empty;

            code = "( " + NumberPrefix + " , " + NextSymbol + " )"; //формирование строки

            return code;

        }
    }
}
