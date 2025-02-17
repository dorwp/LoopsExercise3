namespace IterationStatements
{
    public class Program
    {
        
        
        
        
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        // 2. Write a method that prints very third number from 3 to 999 to the console.
        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i+=3)
            { 
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Integers are equal");
                return true;
            }
            else
            {
                Console.WriteLine("Integers are not equal");
                return false;
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Integer is even");
                return true;
            }
            else
            {
                Console.WriteLine("Integer is not even");
                return false;
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        public static bool IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Integer is positive");
                return true;
            }
            else if (number < 0)
            {
                Console.WriteLine("Integer is negative");
                return false;
            }
            else
            {
                Console.WriteLine("Integer is 0! NOT ");
                return false;
            }
        }
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        public static bool CanVote()
        {
            Console.WriteLine("Please enter age: ");
            
            int age = Convert.ToInt32(Console.ReadLine());
            //age = int.Parse(Console.ReadLine());
            
            Console.WriteLine(age);
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
                return true;
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
                return false;
            }
        }
        
        
        
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        public static bool IsInRange()
        {
            Console.WriteLine("Please enter a number: ");
            
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = -10; i <= 10; i++)
            {
                if (num == i)
                {
                    Console.WriteLine($"The number {num} is in range");
                    return true;
                }
            }
            Console.WriteLine($"The number {num} is not in range");
            return false;
            
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
                Console.WriteLine($"{i} * number = {number * i}");
            
        }
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
           PrintNumbers();
           PrintEveryThirdNumber();
           AreNumbersEqual(2, 2);
           AreNumbersEqual(3, 1);
           IsEven(3);
           IsEven(50);
           CanVote();
           IsInRange();
           DisplayMultiplicationTable(2);
           DisplayMultiplicationTable(24);

        }
    }
}
