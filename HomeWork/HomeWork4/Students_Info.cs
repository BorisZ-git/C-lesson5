using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Students_Info
    {
        string[] name = new string[10];
        string[] secodname = new string[10];
        string[] valuation = new string[10];        
        public string[] ShowString()
        {
            string[] N = new string[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                N[i] = name[i] + secodname[i] + valuation[i];
            }            
            return N;
        }
    }
    
}
