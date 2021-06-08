using Statistics.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.BL.Controller
{
    class NameComparer : IComparer<Symbol>
    {
        public int Compare(Symbol sym_1, Symbol sym_2)
        {
            if (sym_1.SymbolName > sym_2.SymbolName)
            {
                return 1;
            }

            else if (sym_1.SymbolName < sym_2.SymbolName)
            {
                return -1;
            }

            return 0;
        }

    }
}
