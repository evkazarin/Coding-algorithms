using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.BL.Model
{
    //элемент таблицы
    public class TableElement: IEquatable<TableElement> // добавляем интерфейс для сравнения
    {
        public string String { get; set; } // строка
       public int Code { get; set; } // код который присваиваем

       public TableElement(string stringText, int code )
        {
            String = stringText;
            Code = code;
        }


        public bool Equals(TableElement obj) // для сравнения 
        {
            if (this.String == obj.String)
            {
                return true;
            }

            return false;
        }


        public bool EqualsSecond(TableElement obj) //второй метод для сравнения
        {
            if (this.Code == Code)
            {
                return true;
            }

            return false;
        }


        public override string ToString()
        {
            return String ;
        }
    }
}
