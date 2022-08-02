using System;

namespace cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "\"Tuyo\"";
            string phrase1 = "My name is Adedolapo ";
            string phrase2 = " Olutuyo.";

            Console.WriteLine(phrase1 + name + phrase2);

            Console.WriteLine(phrase2.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(phrase1.Contains("name"));
            Console.WriteLine(phrase1.Substring(11, 3));
            Console.WriteLine(phrase1.Length);



            Console.ReadLine();
        }
    }
}
