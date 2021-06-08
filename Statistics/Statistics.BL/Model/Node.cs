using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.BL.Model
{
    /// <summary>
    /// класс описывает узел в графе
    /// </summary>
   public class Node
    {

        public char Symbol { get; set; } //свойство с символами
        public int Frequency { get; set; } // частота

        public Node Right { get; set; } // правый сылка на него
        public Node Left { get; set; }// левый

        public List<bool> Traverse(char symbol, List<bool> data) // метод принимает символ и список с булевыми значениями
        {
            if (Right == null && Left == null) //если в этом узле ссылок на правый и левый нет то && логическое умножение возвращает true если оба одновеременно true
            {
                if (symbol.Equals(this.Symbol)) // если аргумент равен Symbol в этом узле то вернуть data
                {
                    return data;
                }
                else
                {
                    return null; //если символ не равен Symbol то вернуть null 
                }
            }

            else //если Right или Leth имеют ссылки то
            {
                List<bool> left = null;  // создаем булевый список leth  и присваеваем ему null
                List<bool> right = null;

                if (Left != null) // если на Left есть ссылка то
                {
                    List<bool> leftPath = new List<bool>(); //создаем новый список lethPath левая дорожка
                    leftPath.AddRange(data); // в него добавляем булевый список data 
                    leftPath.Add(false); // в него добавляем значение false

                    left = Left.Traverse(symbol, leftPath); // к этому списоку left прицепляем   список из Left
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }

                if (left != null) //возвращаем left или right
                {
                    return left;
                }

                else
                {
                    return right;
                }
            }
        }

    }
}

