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

            ////for decimals
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("The sum is " + (num1 + num2));


            ////5. Building a Mad Libs Game

            //string verb_ed, verb, noun_body_part, noun, adjective,
            //    noun_beverage, noun_something_gross;

            //Console.Write("Enter a verb ending in -ed: ");
            //verb_ed = Console.ReadLine();

            //Console.Write("Enter a verb: ");
            //verb = Console.ReadLine();

            //Console.Write("Enter a noun(body part): ");
            //noun_body_part = Console.ReadLine();

            //Console.Write("Enter a noun: ");
            //noun = Console.ReadLine();

            //Console.Write("Enter an adjective: ");
            //adjective = Console.ReadLine();

            //Console.Write("Enter a noun(beverage): ");
            //noun_beverage = Console.ReadLine();

            //Console.Write("Enter a noun(something gross): ");
            //noun_something_gross = Console.ReadLine();

            //Console.WriteLine(

            //   "If zombies " + verb_ed + " a picnic, what would they "
            //   + verb + " to eat? Everybody knows zombies love to " +
            //   verb + " " + noun_body_part + ", but did you know they also enjoy "
            //   + noun_body_part + " and even " + noun_body_part + "? The best "
            //   + noun + " for a zombie picnic is when the moon is " + adjective +
            //   ". At least one zombie will bring " + noun_beverage + " to drink, and it is not a picnic without "
            //   + noun_body_part + " with extra " + noun_something_gross
            //   + " on top. After eating, zombies will " + verb + adjective
            //   + " games like kick the " + noun_body_part + " and "
            //   + noun_body_part + " toss."
            //);



            ////6. Arrays

            //int[] arr = { 2, 4, 6, 8, 10, 12, 14};
            ////update an element in the array
            //arr[0] = 16;

            //string[] topArtists = new string[10];
            //topArtists[0] = "J. Cole";
            //topArtists[1] = "Dave";
            //topArtists[2] = "Cordae";
            //topArtists[3] = "Juice Wrld";
            //topArtists[4] = "XXXTENTACION";
            //topArtists[5] = "2pac";
            //topArtists[6] = "The Notorious B.I.G.";
            //topArtists[7] = "Drake";
            //topArtists[8] = "Masego";
            //topArtists[9] = "Aaron May";

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(topArtists[5]);

            ////7. Methods
            ////Call the method created outside Main

            //SayHi("Jermaine", 37);
            //SayHi("Pac", 51);
            //SayHi("Cordae", 24);

            ////8. Return statement 

            //int cubed = Cube(16);

            //Console.WriteLine(Cube(8));
            //Console.WriteLine(cubed);


            ////9. If Statements

            //bool genderM = true;
            ////if it is false, nothing is printed.
            ////else statement is used to print something when the condition is false.

            //bool heightTall = true;

            ////&& - both conditions have to be true.
            ////|| - one of the condition has to be true.

            //if (genderM && heightTall)
            ////M=true, Tall=true
            ////male and tall
            //{
            //    Console.WriteLine("This person is a tall Male.");
            //}
            //else if (genderM && !heightTall)
            ////M=true, Tall=false
            ////male and not tall.
            ////if heigthTall was true, the ! would make it false and vice versa
            //{
            //    Console.WriteLine("This person is a Male that's not tall.");
            //}
            //else if (!genderM && heightTall)
            ////M=false, Tall=true
            ////not male, but tall.
            //{
            //    Console.WriteLine("This person is not a male, but tall.");
            //}
            //else
            ////M=false, Tall=false
            ////neither male nor tall.
            //{
            //    Console.WriteLine("This person is either not tall or not a Male or both.");
            //}


            ////10. Comparisons in if statements

            //Console.WriteLine(MaxNum(3, 17, 11));


            ////11. Buliding a better calculator

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter an operator: ");
            //string oprtr = Console.ReadLine();

            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (oprtr == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //} else if (oprtr == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //} else if (oprtr == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //} else if (oprtr == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //} else if (oprtr == "%")
            //{
            //    Console.WriteLine(num1 % num2);
            //} else
            //{
            //    Console.WriteLine("Please enter a valid operator.");
            //}


            ////12. Switch Statements

            //Console.WriteLine(DayOfWeek(0));
            //Console.WriteLine(DayOfWeek(1));
            //Console.WriteLine(DayOfWeek(2));
            //Console.WriteLine(DayOfWeek(3));
            //Console.WriteLine(DayOfWeek(4));
            //Console.WriteLine(DayOfWeek(5));
            //Console.WriteLine(DayOfWeek(6));
            //Console.WriteLine(DayOfWeek(16));



            ////13. While loops

            //int num = 1;
            ////the code keeps executing until the condition is false
            //while (num <= 10)
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}
            //////do...while loop
            ////do
            ////{
            ////    Console.WriteLine(num);
            ////    num++;
            ////} while (num <= 10);


            ////14. Building a guessing game.


            //string secretWord = "Wolf";
            //string guess = "";
            ////let's now give the player some number of tries
            //int guessCount = 0;
            //int guessLimit = 5;
            //bool guessLimitReached = false;


            //while (guess != secretWord && !guessLimitReached)
            //{
            //    if (guessCount == 0 && guessCount < guessLimit)
            //    {
            //        Console.WriteLine("Guess the name of the animal that moves in a pack. (NB: You have 5 tries.)");
            //        Console.Write("Enter your answer: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    } else if (guessCount == 1 && guessCount < guessLimit)
            //    {
            //        Console.WriteLine("Guess the name of the animal that moves in a pack. (NB: You have 4 tries.)");
            //        Console.Write("Wrong! Enter your answer: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else if (guessCount == 2 && guessCount < guessLimit)
            //    {
            //        Console.WriteLine("Guess the name of the animal that moves in a pack. (NB: You have 3 tries.)");
            //        Console.Write("Wrong! Enter your answer: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else if (guessCount == 3 && guessCount < guessLimit)
            //    {
            //        Console.WriteLine("Guess the name of the animal that moves in a pack. (NB: You have 2 tries.)");
            //        Console.Write("Wrong! Enter your answer: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else if (guessCount == 4 && guessCount < guessLimit)
            //    {
            //        Console.WriteLine("Guess the name of the animal that moves in a pack. (NB: You have 1 trial left!)");
            //        Console.Write("Wrong! Enter your answer: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        //when guessCount < guessLimit is false.
            //        //this is otherwise called a boolean flag
            //        guessLimitReached = true;
            //    }
            //}

            //if (guessLimitReached)
            //{
            //    Console.WriteLine("Oops, you did not get the animal! Also, you're out of guesses");
            //} else
            //{
            //    Console.WriteLine("You guessed right!");
            //}


            ////15. For Loops

            //////int i = 1;

            //////while (i <= 5)
            //////{
            //////    Console.WriteLine(i);
            //////    i++;
            //////}

            /////*
            //// the for loop will contain the
            ////- variable initialization
            ////- the condition
            ////-increment or decrement
            //// */
            ////for (int i = 1; i <= 5; i++)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //int[] nums = { 2, 4, 6, 8, 10, 12, 14, 16 };

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            ////16. Building an Exponent Method

            //Console.WriteLine(Pow(2, 3));


            ////17. 2D Arrays

            //int[,] twoDarr = {
            //    { 1, 3 },
            //    { 2, 4 }
            //};

            ///*
            //in a situation you dont know how many values you want to populate the array with
            //you can write it as:
            //*/

            ////int[,] arr = new int[3, 4]; // new int[rows, columns]

            //Console.WriteLine(twoDarr[1,1]);


            //18. Comments

            //Comments are ignored by the computer
            //You can easily add a single line comment with this forwardslash.
            /*
            or you can wirte a double line comment
            just like this.
            */


            ////19. Exception Handling

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter a second number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            ////catch (Exception e) //this takes an exception parameter and we call it 'e'.
            //////you can also specify a specific exception, but it will not catch other tyoes of exception
            ////{
            ////    Console.WriteLine("Error: " + e.Message); //e.Message explains what went wrong
            ////}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}
            ////finally //any code here gets executed no matter what (optional)
            ////{

            ////}


            ////20. Classes and Objects

            ////an object is an instance of a class...
            ////object is creating the book inside our program
            ////you can create as many objects as you want

            //Book book1 = new Book();
            //book1.Title = "2014 Forest Hills Drive";
            //book1.Author = "J.Cole";
            //book1.Pages = 13;

            //Book book2 = new Book();
            //book2.Title = "From A Bird\'s Eye View";
            //book2.Author = "Cordae";
            //book2.Pages = 14;

            //Console.WriteLine(book2.Title);


            ////21. Constructors

            //Book book1 = new Book("2014 Forest Hills Drive", "J.Cole", 13); //this calls the constructor method

            //Book book2 = new Book("From A Bird\'s Eye View", "Cordae", 14);

            ////You can modify the values
            //book1.Pages = 14;

            //Console.WriteLine(book2.Title);
            //Console.WriteLine(book1.Title);
            //Console.WriteLine(book1.Pages); //the number of pages changes from 13 to 14


            ////22. Object Methods

            ////we want to figure out if any of these students is on the honor roll
            ////we create an object method in our class

            //Student student1 = new Student("Alade", "Frontend Development.", 4.8);
            //Student student2 = new Student("Luchesse", "Data Analysis.", 2.8);
            //Student student3 = new Student("Sherlock", "Backend Development.", 4.9);
            //Student student4 = new Student("Donnie", "UI and UX.", 3.2);
            //Student student5 = new Student("Tuyo", "Cloud Engineering and Game Design.", 4.7);


            //Console.WriteLine(student1.Honors());
            //Console.WriteLine(student2.Honors());
            //Console.WriteLine(student3.Honors());
            //Console.WriteLine(student4.Honors());
            //Console.WriteLine(student5.Honors());



            ////23. Getters and Setters

            ////Ratings G, PG, PG-13, R, NR

            //Movies movie1 = new Movies("Avengers: Infinity War", "Marvel", "G");
            //Movies movie2 = new Movies("Avengers: Endgame", "Marvel", "PG");

            //Console.WriteLine(movie1.Rating);



            //24. Static Class Attributes

            //new calls the constructor
            Football team1 = new Football("P.S.G.", "Lionel Messi", 30);

            Console.WriteLine(Football.numberOfPlayers);
            Console.WriteLine(team1.getNumberOfPlayers());

            Football team2 = new Football("Barcelona", "Pedri Gonzalez", 8);

            Console.WriteLine(Football.numberOfPlayers);
            Console.WriteLine(team2.getNumberOfPlayers());









            Console.ReadLine();
        }

        ////7. Methods

        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + "! Whoa! you're " + age + "years old? Cool!");
        //}

        ////8. Return statement

        //static int Cube(int x)
        //    //you can also return "string" "double" "double[]" etc.
        //{
        //    int result = x * x * x;
        //    return result;
        //}

        //10. Comparisons in if statements

        //static int MaxNum(int num1, int num2, int num3)
        //{
        //    int result;
        //    //if (num1 > num2)
        //    //// > comparison resolves down to a true or false
        //    //{
        //    //    result = num1;
        //    //} else
        //    //{
        //    //    result = num2;
        //    //}

        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    } else if (num2 >= num1 && num2 >= num3)
        //    {
        //        return num2;
        //    } else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //}


        //12. Switch Statements

        //static string DayOfWeek (int dayNum)
        //{
        //    string dayName;

        //    switch (dayNum)
        //    {
        //        //in the case that dayNum is 0 (...to the last case 6), do dayNum = "Sunday".
        //        //the break statement helps us get out of the structure we're in.
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid day of the week number.";
        //            break;
        //    }


        //    return dayName;
        //}


        ////16. Building an Exponent Method

        //static int Pow (int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for (int i = 0; i < powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }

        //    return result;
        //} 
    }
}
