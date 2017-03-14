using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/* Boris Z
1 Создать программу, которая будет проверять корректность ввода логина. Корректным логином
будет строка от 2-х до 10-ти символов, содержащая только буквы или цифры, и при этом цифра
не может быть первой.
1.1 без использования регулярных выражений;
1.2 с использованием регулярных выражений
 * */

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            // 1.1
            string Login = Console.ReadLine();            char[] check = Login.ToCharArray();
            if (char.IsDigit(check[0]))
                Console.WriteLine("Первым символом пароля не может быть цифра!");            if (check.Length<2||check.Length>10)                Console.WriteLine("Логин строго от 2-х до 10-ти символов ");            for (int i = 0; i < check.Length; i++)
                if (!char.IsLetterOrDigit(check[i]))                    Console.WriteLine("Логин может содержать только буквы или цифры");            Console.WriteLine("Все верно");
            //1.2
            string LoginReg = Console.ReadLine();            
            Regex reg = new Regex(@"\w");                Console.WriteLine(reg.IsMatch());                            
            Console.ReadLine();
        }

    }
}
