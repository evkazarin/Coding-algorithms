using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statistics.BL.Model;

namespace Statistics.BL.Controller
{
   public class HuffmanTree
    {
        private List<Node> nodes = new List<Node>(); // список с узлами
        public Node Root { get; set; } // корневой узел
        public Dictionary<char, int> Frequencies = new Dictionary<char, int>(); // словарь ключ символ число значение

        public List<ElementForTable> elementForTables = new List<ElementForTable>(); // список с кодами для таблицы

        public void Build(string source) // метод создания дерева принимает текст
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (!Frequencies.ContainsKey(source[i])) // если символа в словаре нет то добавляем его в словарь скак ключ и значение 0 
                {
                    Frequencies.Add(source[i], 0); //с частотой 0
                }

                Frequencies[source[i]]++; // здесь вычисляется количество вхождений символа в строку
            }

            //получили словарь с ключем символ - значение кво вхождений символа в строку

            foreach (KeyValuePair<char, int> symbol in Frequencies)
            {
                // TODO : что это за хрень!!!  эта хрень инициализаторо объекта почему не конструктор
                // добавляю в список с узлам узел
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            // занесли все символы в узлы

            while (nodes.Count > 1) // пока число узлов больше 1
            {
                //TODO : что за хрень снова!!
                // создаем список с порядком узлов ему присваиваем ссылку на nodes которую сортируем по возрастанию ключа
                List<Node> orderedNodes = nodes.OrderBy(nodes => nodes.Frequency).ToList<Node>();
                if (orderedNodes.Count >= 2) // если в этом списке больше 2 или 2 узлов то 
                {
                    // Создаем новый список куда заноим два узла из упорядоченного списка узлов
                    List<Node> taken = orderedNodes.Take(2).ToList<Node>();

                    // создаем новый список родитель куда заноим два узла через инициализатор
                    Node parent = new Node() { Symbol = '*', Frequency = taken[0].Frequency + taken[1].Frequency, Left = taken[0], Right = taken[1] };
                    
                    // удаляем из списка (с не сортированными) узлами  в taken хранится два узла с с наименьшими вероятностями
                    nodes.Remove(taken[0]); // метод Remove принимает экземпляр Node и ищет его по сигнатуре в nodes и удаляет его
                    nodes.Remove(taken[1]);
                    nodes.Add(parent); // заменяем два узла с на наименьшей вероятностью на один с суммарной вероятностью
                }

                // присваиваем корневому узлу ссылку на первый элемент в nodes
                this.Root = nodes.FirstOrDefault();

                // так создается дерево
            }

        }

        public BitArray Encode(string source) // BitArray массив с логическими значениями True или False
        {
            List<bool> encodedSource = new List<bool>(); // список с булевыми значениями

            for (int i = 0; i < source.Length; i++) // 
            {
                List<bool> encodedSymbol = this.Root.Traverse(source[i], new List<bool>()); // создаем список с булевыми значениями
                // ему присваеваем ссылку на список из метода который имеет Node который принимает Символ и новый список с булевыми значениями(пустой)
                // типа ссылка ... 
                encodedSource.AddRange(encodedSymbol); // добавляем в encodedSource из encodedSymbol

                // сформировать список для передачи в таблицу

                ElementForTable temp = new ElementForTable(source[i], new BitArray(5));
                //int counts = Alphabet.character.Count();

                if (!elementForTables.Contains(temp))
                {
                    elementForTables.Add(new ElementForTable(source[i], new BitArray(encodedSymbol.ToArray())));
                }

            }

            BitArray bits = new BitArray(encodedSource.ToArray()); //создаем битовый массив со значениями из списка

            return bits;
        }

        public string Decode(BitArray bits) // раскодирование
        {
            Node current = this.Root; // Создаем новый узел Current (текущий) ему присваиваем ссылку на корневой узел
            string decoded = ""; // строка куда декодируем

            foreach (bool bit in bits) //перебор битового массива
            {
                if (bit) // если значение bit true то 
                {
                    if (current.Right != null) // если в текущем узле ссылка на не равна null тоесть она есть
                    {
                        current = current.Right; // приваеваем текущему ссылку на Правый
                    }
                }

                else
                {
                    if (current.Left != null)// если в текущем узле ссылка на не равна null тоесть она есть
                    {
                        current = current.Left;  //присваеваем ссылку на Левый
                    }
                }
                if (IsLeaf(current)) // если текущий лист то присвоить в декодированный Symbol из текущего
                {
                    decoded += current.Symbol;
                    current = this.Root; // и текущий возвратить в начало
                }
            }
            return decoded;

        }

        public bool IsLeaf(Node node) //метод определения листа те конечного узла из которого не выходит не одной дуги
        {
            return (node.Left == null && node.Right == null); //если в узле ссылки на Right и Left отсутствуют то это лист
        }
    }


}

