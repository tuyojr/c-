using System;

namespace cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Working with Strigs
            //string name = "\"Tuyo\"";
            //string phrase1 = "My name is Adedolapo ";
            //string phrase2 = " Olutuyo.";
            //string firstName = "John";
            //string lastName = "Doe";
            //string name1 = $"My full name is: {firstName} {lastName}";

            //Console.WriteLine(name1);

            //Console.WriteLine(phrase1 + name + phrase2);

            //Console.WriteLine(phrase2.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(phrase1.Contains("name"));
            //Console.WriteLine(phrase1.Substring(11, 3));
            //Console.WriteLine(phrase1.Length);

            ////2. Working with numbers

            //int num = 4;
            //num++; //adds 1 to the num variable
            ////num-- subtracts 1 from the num variable

            //Console.WriteLine(num);
            //Console.WriteLine( 4 % 2 );
            //Console.WriteLine( (4 + 4) * 3 );
            //Console.WriteLine( 10 / 3 );
            //Console.WriteLine(10 / 3.0);
            //Console.WriteLine( Math.Abs(-300) ); //prints the absolute value to the screen
            //Console.WriteLine( Math.Pow(2, 3) ); //second number is the power which the first is raised to
            //Console.WriteLine( Math.Sqrt(64) ); //prints the square root of 64
            //Console.WriteLine( Math.Max( 10, 100 )); //prints out the greater number
            //Console.WriteLine( Math.Min( 10, 100 )); //prints out the lesser number
            //Console.WriteLine( Math.Round( 7.3 )); //rounds up the number to the nearest whole number. below .5 returns the number before the decimal point
            //Console.WriteLine( Math.Round( 7.5 )); //rounds up the number to the nearest whole number. .5 and above adds 1 to the number before the decimal point
            //Console.WriteLine(Convert.ToString(num));



            ////3. Getting User Input
            ////Console.WriteLine(); prints a line of text and then goes to a new line
            ////Console.ReaLine(); takes the line of text the user enters and saves it as a string


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ", you are " + age + "years old.");



            //4. Building a calculator

            ////for inetgers
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //for decimals
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sum is " + (num1 + num2));




            Console.ReadLine();
        }
    }
}
