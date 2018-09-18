using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum;
            arrayNum = new int[10];
            for (int i = 0; i < arrayNum.Length; i++)
            {
                String s = Console.ReadLine();
                int a = int.Parse(s);
                arrayNum[i] = a;
            }
            int max = arrayNum[0], min = arrayNum[0];
            for (int j =0; j <arrayNum.Length; j++)
            {
                if(arrayNum[j] > max)
                {
                    max = arrayNum[j];
                }
                if(arrayNum[j] < min)
                {
                    min = arrayNum[j];
                }
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            int sum = 0;
            int average = 0;
            for (int k = 0; k < arrayNum.Length; k++)
            {
                sum += arrayNum[k];
            }
            average = sum / arrayNum.Length;
            Console.WriteLine("The sum = " + sum);
            Console.WriteLine("The average = " + average);
        }
    }
}
