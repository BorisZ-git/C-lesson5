using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/* Boris Z
 * Написать игру “Верю. Не верю”. В файле хранятся некоторые данные и правда это или нет.
Например: “Шариковую ручку изобрели в древнем Египте”, “Да”.
Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задает их игроку.
Игрок пытается ответить правда или нет, то что ему загадали и набирает баллы. Список вопросов
ищите во вложении или можно воспользоваться Интернетом.
*/

namespace HW_FromPrevious2
{
    class Program
    {

        static void Main(string[] args)
        {
            Create();
            string[] fields = new string[2];
            string[] answer = new string[5];
            string[] question = new string[5];
            string[] lines = Load(question);

            for (int i = 0;i<question.Length;i++ )
            {
                fields = lines[i].Split('|');
                question[i] = fields[0];
                answer[i] = fields[1];
            }

            #region через Двумерный массив
            //string [,] question = new string [2,5];
            //for (int i = 0;i<question.GetLenght(1);i++ )
            //{
            //fields = lines[i].Split('|');
            //question (0,i) = fields[0];
            //question (1,i) = fields[1];
            //}

            #endregion

            int score= 0;
            for (int j = 0; j < question.Length; j++)
            {
                Console.WriteLine(question[j]);
                string UserAnswer = Console.ReadLine();
                if (UserAnswer == answer[j] || UserAnswer == answer[j].ToLower()
                    || UserAnswer == answer[j].ToUpper()) score++;
                else Console.WriteLine("Ответ не верный!");
            }
            Console.WriteLine($"Ваши очки = {score}");
            Console.ReadLine();
        }
        static void Create()
        {
            #region variables
            string[] str = new string[10];
            str[0] = "В Древнем Риме альбомом называли доску, покрытую белым гипсом|Да";
            str[1] = "На луну воют только волки-одиночки|Нет";
            str[2] = "Бамбук самая высокая трава в мире.|Да";
            str[3] = "Авторучка была изобретена ещё в Древнем Египте?|Да";
            str[4] = "Совы не могут вращать глазами?|Да";
            str[5] = "Дети могут слышать более высокие звуки, чем взрослые?|Да";
            str[6] = "Лось является разновидностью оленя?|Да";
            str[7] = "Мойву эскимосы сушат и едят вместо хлеба?|Да";
            str[8] = "Радугу можно увидеть и в полночь?|Да";
            str[9] = "Утром вы выше ростом, чем вечером?|Да";


            #endregion
            StreamWriter stw = null;
            try
            {
                stw = new StreamWriter("data.txt");
                //stw.WriteLine(str[0]);
                for (int i = 0; i < str.Length; i++)
                    stw.WriteLine(str[i]);
                stw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        static string[] Load(string[] _question)
        {
            Random rnd = new Random();
            string[] lines = new string[10];
            string[] question = _question;            
            string check;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("data.txt");
                for (int i = 0; !sr.EndOfStream; i++)
                    lines[i] = sr.ReadLine();


                int a;                
                for (int i = 0; i < question.Length; i++)
                {
                    a = rnd.Next(0, lines.Length);
                    check = lines[a];
                    for (int j = 0; j < question.Length; j++) 
                        if (question[j]==check)
                        {
                            a = rnd.Next(0, lines.Length);
                            check = lines[a];
                            j = -1;
                        }
                    question[i] = check;
                }
            }


            catch (Exception e)
            {
               Console.WriteLine(e);
            }            
            return question;

        }

    }
}
