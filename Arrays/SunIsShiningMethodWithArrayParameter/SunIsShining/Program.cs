using System;

namespace SunIsShining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = new int[] { 34, 76, 56, 89, 100 };
            foreach(int value in happiness)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("------after------");
            SunIsShining(happiness);
            foreach (int value in happiness)
            {
                Console.WriteLine(value);
            }
        }
        static int[] SunIsShining(int[] happyValues)
        {
            for(int i = 0; i < happyValues.Length; i++)
            {
                happyValues[i] += 2;
            }
            return happyValues;
        }
    }
}
