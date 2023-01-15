using System;
using System.Collections;

namespace usingArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(12);
            myArrayList.Add(12.22);
            myArrayList.Add(1123.662);
            myArrayList.Add(45);
            myArrayList.Add(16);
            myArrayList.Add("Hello there");
            myArrayList.Add("Print these lines");
            myArrayList.Add("12345");
            myArrayList.Add("XX YY ZZ");

            double sum = 0;
            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum = sum + Convert.ToInt16(obj);
                }
                if(obj is double)
                {
                    sum = sum + Convert.ToDouble(obj);
                }
                if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
