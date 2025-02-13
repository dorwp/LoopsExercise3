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
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
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
            
        }
    }
}
