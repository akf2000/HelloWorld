using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "asif"; // this is a comnment

            string string1 = "string1";
            string string2 = "string2";
            string string3 = string1 + string2; // concatonate 2 strings
            string greettemplate = "hello **NAME**!";
            string greet4 = greettemplate.Replace("**NAME**", string1);

            Console.WriteLine(greet4); 
        }
    }
}
