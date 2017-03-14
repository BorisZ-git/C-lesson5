using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/* Boris Z
2 Разработать методы для решения следующих задач. Дано сообщение:
2.1 Вывести только те слова сообщения, которые содержат не более чем n букв;
2.2 Удалить из сообщения все слова, которые заканчиваются на заданный символ;
2.3 Найти самое длинное слово сообщения;
2.4 Найти все самые длинные слова сообщения.
Постарайтесь разработать класс MyString.

 * */

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)

        {            
            string str = "сообщение в котором все тебя ненавидят";
            string UserChoose = Console.ReadLine();
            if (UserChoose=="1")
                str = Console.ReadLine();
            MyString mystr = new MyString(str);
            mystr.ShowLength(10);
            Console.WriteLine("\n\n");


            mystr.RemoveEndSym("я");
            Console.WriteLine("\n\n");


            mystr.LongerWord();
            Console.WriteLine("\n\n");


            mystr.AllLongerWords();
            Console.ReadLine();
        }
    }
    
    class MyString
    {
        string[] field;
        int count = 0;        
        public MyString(string str)
        {
            field = str.Split(' ');
        }
        //2.1
        public void ShowLength(int n)
        {

            for (int i = 0; i < field.Length; i++)
            {
                if (field[i].Length <= n)
                {
                    count++;
                    Console.Write($"{field[i]} ");
                }
                //add a line break
                if (count > 9)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }

        }
        //2.2
        public void RemoveEndSym(string sym)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if (!field[i].EndsWith(sym))
                {
                    count++;
                    Console.Write($"{field[i]} ");
                }
                //add a line break
                if (count > 10)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
        }
        //2.3
        public void LongerWord()
        {
            string max = field[0];
            for (int  i = 0; i < field.Length; i++)
            {
                if (field[i].Length > max.Length)
                    max = field[i];
            }
            Console.WriteLine(max);
        }
        //2.4
        public void AllLongerWords()
        {
            int value = String.Join("",field).Length / field.Length;
            for (int i = 0; i < field.Length; i++)
                if (field[i].Length > value)
                    Console.Write($"{field[i]} ");
        }
    }
}
