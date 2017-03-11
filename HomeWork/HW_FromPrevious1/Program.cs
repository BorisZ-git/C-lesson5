using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/* Boris Z
 * 2.1 Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий
массив случайными числами. Создать методы, которые возвращают сумму всех элементов
массива, сумму всех элементов массива больше заданного, свойство, возвращающее
минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод,
возвращающий номер максимального элемента массива (через параметры, используя
модификатор ref или out)
* 2.2 Добавить конструктор и методы, которые загружают данные из файла и записывают данные в
файл.*/

namespace HW_FromPrevious1
{
    //2.1
    class DoubleArray
    {
        int[,] dArray;
        Random rnd = new Random();       
        public DoubleArray(int n,int a,int min,int max)
        {
            dArray = new int[n, a];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < a; j++)
                    dArray[i, j] = rnd.Next(min, max);
        }
    }
    //2.2
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
