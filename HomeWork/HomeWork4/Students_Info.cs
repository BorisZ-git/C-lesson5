using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork4
{
    class Students_Info
    {
        string[] name = new string[10];
        string[] secodname = new string[10];
        string[] valuation = new string[10];        
        public string[] GetString()
        {
            string[] N = new string[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                N[i] = name[i] + secodname[i] + valuation[i];
            }            
            return N;
        }
        public Students_Info()
        {
            //stremreder
            StreamReader sr = null;
            string[] studentsinfo = null;
            try
            {
                sr = new StreamReader("studentsinfo.txt");
                while (true)
                {
                    for (int i = 0;i<100;i++)
                    studentsinfo[i] = sr.ReadLine();
                    if (sr.EndOfStream)
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            #region string
            string[] studentsinfo = new string[10];
            studentsinfo[0] = "Петров | Петр | 4 5 3";
            studentsinfo[1] = "Иванов | Иван | 3 4 3";
            studentsinfo[2] = "Олегов | Олег | 5 5 5";
            studentsinfo[3] = "Иванова | Ксения | 3 3 3";
            studentsinfo[4] = "Козлов | Козел | 2 5 4";
            studentsinfo[5] = "Козлова | Ольга | 5 3 2";
            studentsinfo[6] = "Калашникова | Анастасия | 4 3 2";
            studentsinfo[7] = "Синев | Роберт | 3 2 3";
            studentsinfo[8] = "Сивале | Никсон | 4 3 2";
            studentsinfo[9] = "Никифоров | Алексей | 4 4 4";
            #endregion
            #region split nd set
            string[] fields = null;
            for (int i = 0; i < studentsinfo.Length; i++)
            {
                fields = studentsinfo[i].Split('|');
                //if i.lenght>15
                name[i] = fields[0];
                secodname[i] = fields[1];
                valuation[i] = fields[2];
            }
            #endregion

        }
        public void MidBaddestRes()
        {
            int min;
        }
    }
    
}
