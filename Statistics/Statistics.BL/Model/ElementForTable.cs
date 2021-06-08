using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.BL.Model
{
    public class ElementForTable : IEquatable<ElementForTable>
    {
        public char Symbol { get; set; }

        public BitArray array;

        public ElementForTable(char symbol, BitArray array)
        {
            Symbol = symbol;
            this.array = array;
        }

        public bool Equals(ElementForTable obj)
        {
            if (this.Symbol == obj.Symbol)
            {
                return true;

            }
            return false;
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var item in this.array)
            {
                if (Convert.ToBoolean(item))
                {
                    result += 1;
                }

                else
                {
                    result += 0;
                }
             
            }

            return result;
        }
    }
}
