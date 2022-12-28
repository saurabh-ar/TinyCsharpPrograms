using System;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2d Array

            int[,] twoDArray = new int[,] 
            { 
                { 0, 0 },  //row 1
                { 0, 1 },  //row 2
                { 1, 0 },  //row 3
                { 1, 1 }   //row 4
            };

            //3d Array
            int[,,] threeDArray = new int[,,]
            {
                { //row 1
                    {0,0},
                    {1,0}
                },
                { //row 2
                    {0,0},
                    {1,0}
                }
            };

            Console.WriteLine(twoDArray[0,1]);
            Console.WriteLine(threeDArray[0,1,0]);
        }
    }
}
