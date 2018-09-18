using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = new int[99];
            for (int i = 0; i < 99; i++)
            {             
                arrayNum[i] = i + 2;                
            }
            for (int i = 2; i < arrayNum.Length; i++)
            {
                for(int j = 0; j < arrayNum.Length; j++)
                {
                    if (arrayNum[j] != 0)
                    {
                        if (arrayNum[j] % i == 0 && arrayNum[j] / i != 1)
                        {
                            arrayNum[j] = 0;
                        }
                    }
                }
            }
            for (int n = 0; n < arrayNum.Length; n++)
            {
                if (arrayNum[n] != 0)
                {
                    Console.WriteLine(arrayNum[n]);
                }            
            }   
        }
    }
}
