using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/* Boris Z
 * 2.1 Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий
массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива,
сумму всех элементов массива больше заданного(видимо заданного числа), свойство, возвращающее
минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод,
возвращающий номер максимального элемента массива (через параметры, используя
модификатор ref или out)
* 2.2 Добавить конструктор и методы, которые загружают данные из файла и записывают данные в
файл.*/
/* Вопросы: Что такое свойство? Для чего используется? В чем выгода его применения? */

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
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < dArray.GetLength(0); i++)
                for (int j = 0; j < dArray.GetLength(1); j++)
                    sum += dArray[i, j];
            return sum;
        }
        public int Sum(int a)
        {
            int sum = 0;
            for (int i = 0; i < dArray.GetLength(0); i++)
                for (int j = 0; j < dArray.GetLength(1); j++)
                    if (dArray[i, j]>a) sum += dArray[i, j];
            return sum;
        }
        //Через метод?
        public int Min()
        {
            int min = dArray[0,0];
            for (int i = 0; i < dArray.GetLength(0); i++)
                for (int j = 0; j < dArray.GetLength(1); j++)
                    if (dArray[i, j] < min) min = dArray[i, j];
            return min;
        }
        public int Max()
        {
            int max = dArray[0, 0];
            for (int i = 0; i < dArray.GetLength(0); i++)
                for (int j = 0; j < dArray.GetLength(1); j++)
                    if (dArray[i, j] > max) max = dArray[i, j];
            return max;
        }
        //Через свойства?
        int minval = 0;
        int maxval = 0;
        public int MinVal
        {
            get
            {
                return minval;
            }
            set
            {
                for (int i = 0; i < dArray.GetLength(0); i++)
                    for (int j = 0; j < dArray.GetLength(1); j++)
                        if (dArray[i, j] < minval) minval = dArray[i, j];
            }
        }
        public int MaxVal
        {
            get
            {
                for (int i = 0; i < dArray.GetLength(0); i++)
                    for (int j = 0; j < dArray.GetLength(1); j++)
                        if (dArray[i, j] > maxval) maxval = dArray[i, j];
                return maxval;
            }          
        }
        //Индекс через цикл
        public void IndMax()
        {            
            for (int i = 0; i < dArray.GetLength(0); i++)
                for (int j = 0; j < dArray.GetLength(1); j++)
                    if (dArray[i, j].Equals(Max())) { Console.WriteLine($"{i},{j}"); }                       
        }
        //Индекс через параметры
        public void MaxValInd(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j].Equals(Max(arr))) { Console.WriteLine($"{i},{j}"); }

        }
        public int[,] Create(int n, int a, int min, int max)
        {
             int[,] dArray2 = new int[n, a];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < a; j++)
                    dArray2[i, j] = rnd.Next(min, max);
            return dArray2;
        }
        public int Max(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > max) max = a[i, j];
            return max;
        }
        //Show
        public void ShowValue()
        {
            for (int i =0;i<dArray.GetLength(0);i++)
                for(int j = 0;j<dArray.GetLength(1);j++)
                Console.Write($"El: {i},{j} = {dArray[i,j]}   ");
        }
    }
    //2.2
    class LoadDA
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            DoubleArray dArray = new DoubleArray(2, 2, 0, 10);
            int[,] thearray = dArray.Create(2,3,0,100);
            Console.WriteLine("Вывести значения элементов: ");
            dArray.ShowValue();
            Console.WriteLine();
            Console.WriteLine($"Вывести максимальное значение элементов: {dArray.Max()}");
            Console.WriteLine($"Вывести сумму элементов: {dArray.Sum()}");
            Console.WriteLine($"Вывести сумму элементов от заданного числа: {dArray.Sum(4)}");
            Console.Write("Вывести индекс элемента с маскимальным значением: ");
            dArray.IndMax();
            Console.WriteLine($"Вывести элемент с минимальным значением: {dArray.Min()} ");
            Console.WriteLine($"Вывести элемент с минимальным"+
                $" значением(properties): {dArray.MinVal} ");
            Console.WriteLine($"Вывести элемент с минимальным" +
                $" значением(properties): {dArray.MaxVal} ");
            Console.Write("Вывести значения элементов: ");
            for (int i = 0; i < thearray.GetLength(0); i++)
                for (int j = 0; j < thearray.GetLength(1); j++)
                    Console.Write($"El: {i},{j} = {thearray[i, j]}   ");
            Console.WriteLine();

            Console.Write("Вывести индекс элемента с маскимальным значением (ref): ");
            dArray.MaxValInd(ref thearray);


            Console.ReadLine();
        }

    }
}

