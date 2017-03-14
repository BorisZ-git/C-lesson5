using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string str = "Дано сообщение: Вывести только те слова сообщения," +
                "которые содержат не более чем n букв" + "Удалить из сообщения все слова," +
                "которые заканчиваются на заданный символ." +
                "Найти самое длинное слово сообщения" + 
                "Найти все самые длинные слова сообщения.";
            string UserChoose = Console.ReadLine();
            if (UserChoose=="1")
                str = Console.ReadLine();
            MyString mystr = new MyString(str);
            mystr.ShowLength();
        }
    }
    //2.4
    class MyString
    {
        string str;
        public MyString(string str)
        {
            this.str = str;
        }
        public void ShowLength()
        {

        }
    }
}
