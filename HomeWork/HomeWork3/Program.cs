using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/* Boris Z
3 Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Регистр можно не учитывать.
3.1 с использованием методов C#
3.2 разработав собственный алгоритм
Например:
badc являются перестановкой abcd
*/

namespace HomeWork3
{
    class Program
    {

        static void Main(string[] args)
        {
            string str1 = "badc";
            string str2 = "abcd";
            StrEqual(str1, str2);
            MyAlg(str1, str2);
            str1 = "!";
            str2 = "1";
            StrEqual(str1, str2);
            MyAlg(str1, str2);



            Console.ReadLine();
        }
        //3.1
        static void StrEqual(string str1,string str2)
        {
            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            str1 = new string(a);
            str2 = new string(b);
            int result = String.Compare(str1, str2, true);
            if (result == 0)
                Console.WriteLine("Строки равны");
            else
                Console.WriteLine("Строки не равны");
        }
        //3.2
        static void MyAlg(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                Console.WriteLine("Строки не равны");
            else 
            {
                int count = 0;
                for (int i = 0; i < str1.Length; i++)
                    for (int j = 0; j < str2.Length; j++)
                        if (str1[i] == str2[j])
                            count++;
                if (count == str1.Length)
                    Console.WriteLine("Строки равны");
                else Console.WriteLine("Строки не равны");
            }
        }

    }
}
