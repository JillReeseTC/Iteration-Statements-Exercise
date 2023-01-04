using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000()
        {
            for (int counter = -1000; counter <= 1000; counter++)
            {
                Console.WriteLine(counter);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Print999By3()
        {
            for (int counter = 3; counter <= 999; counter += 3)
            {
                Console.WriteLine(counter);
            }

        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool EqualInts(int int1, int int2)
        {
            bool equal = false;
            return equal = (int1 == int2) ? true : false;
        }

        //Write a method to check whether a given number is even or odd
        public static string EvenOddInt(int checkedNumber)
        {
            string answer = "";
            return answer = checkedNumber % 2 == 0 ? "Even" : "Odd";
        }

        //Write a method to check whether a given number is positive or negative
        public static string PosNegInt(int checkedNumber)
        {
            string answer = "";
            return answer = checkedNumber >= 0 ? "positive" : "negative";
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            string answer = (age >= 18) ? "Go on into the voting booth!" : "Sorry, come back when you're 18.";
            Console.WriteLine(answer);
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10==
        public static void IntInRange()
        {
            var loopend = false;
            do
            {
                var number = -100; //reset the number counter
                Console.WriteLine("Enter your integer: ");
                number = int.Parse(Console.ReadLine());
                string answer = (number >= -10 && number <= 10) ? "It's in the range!" : "Nope, try again.";
                loopend = (answer == "It's in the range!") ? true : false;
                Console.WriteLine(answer);
            } while (loopend == false);

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication table for {number}");
            for (var counter = 1; counter <= 12; counter++)
            {
                Console.WriteLine($"{counter} x {number} = " + (number * counter));
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            int number = 12;
            int number2 = 8;
            DisplayMultiplicationTable(number);
            IntInRange();
            CanVote();
            Print1000();
            Print999By3();
            bool answer = EqualInts(number, number2);
            string resultEqualInts = (answer == true) ? "true" : "false";
            Console.WriteLine($"EqualInts answer is {resultEqualInts}");
            string answer2 = EvenOddInt(number);
            Console.WriteLine($"EvenOddInt answer is {answer2}");
            string answer3 = PosNegInt(number);
            Console.WriteLine($"PosNegInt answer is {answer3}");
        }
    } 
}
