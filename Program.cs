using System;
using System.Linq;
using System.Collections.Generic;

namespace QueueTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(HW1.QueueTime(customers, n));
        }
    }

    public class HW1
    {

        public static long QueueTime(int[] customers, int n)
        {
            int time = 0;

            int index = 0;

            var min = 0;

            int[] cashbox = new int[n];

            for (int i = 0; i < customers.Length; i++)
            {
                for (int k = 1; k < cashbox.Length; k++)
                for (int k = 0; k < cashbox.Length; k++)
                {
                    if (cashbox[k] < cashbox[min]) 
                        min = k;
                }

                index = min;

                if(n==1)
                {
                    cashbox[index] += customers[i];
                }
                else
                {
                    time += cashbox[index];

                    for (int j = 0; j < cashbox.Length; j++)
                    {
                        cashbox[j] -= cashbox[index];
                    }

                    cashbox[index] = customers[i];
                }
            }
            time += cashbox.Max();

            return time;
        }
    }
}