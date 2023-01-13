using System;

namespace ParamsInArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            paramsMethod("Hello ", "there! ", "This is a ","params ", "example ", "program. ", "That ", "can take ", "any ", "number ", "of ", "arguments. ", "So, ", "just ", "testing ", "same.", "Thank", "You!");
        }

        //params : Allow us to pass as many values as we want.
        // Definition -> params <object[]> objectName
        public static void paramsMethod(params string[] sentence )
        {
            for (int i=0; i<sentence.Length; i++)
            {
                Console.Write("Loop number "+ i + " = ");
                Console.WriteLine(sentence[i]);
            }
        }
    }
}
