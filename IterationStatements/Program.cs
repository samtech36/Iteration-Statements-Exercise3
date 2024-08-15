using System.ComponentModel.Design;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        
        //my answer for #1 
       public static void PrintNumbers()
      {
          for (int i = 1000; i >= -1000; i--)
           {
               Console.WriteLine($"{i}");
           }
       }
        
        
        
     //  2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        //my answer for #2 

           public static void PrintEveryThirdNumber()
           {
              for (int i = 3; i <= 999; i += 3)
              {
                  Console.WriteLine($"{i}");
              }
           }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        
        //my answer for #3 
        
        public static bool AreNumbersEqual(int num1, int num2)
         {
            
           if (num1 == num2)
           {
               return true;
           }
 
              else
              {
                  return false;
            }
           }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        
        //my answer for #4 


        public static bool IsEven(int number)
        {
            
            
           if (number % 2 == 0)
            {
                return true;
            }
         
            else
            {
                return false;
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        
        //my answer for #5

        public static bool IsPositive(int number)

        {
           if (number > 0)
            {
                return true;
            }

           else
          {
                return false;
            }
        }
        
        
        
        
        
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        //my answer for #6

        public static bool CanVote(int age)
        {
            if (age > 18)
            {
                Console.WriteLine("You are allowed to vote");
                return true;
           }
           else
            {
               Console.WriteLine("You are not allowed to vote");
                return false;
               
            }
           
        }
        
        
        
        
        
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number7)
        {
            if (number7 >= -10 && number7 <= 10)
            {
               return true;
           }

            else
          {
                return false;
           }
            
        }
        
        
        
        
        
        
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable()
        
        {
            Console.WriteLine("Enter a number that will be multiplied between numbers 1 and 12: ");
           int userInput = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 12; i++)
            {
              int result = i * userInput;
               
             Console.WriteLine($"{i} * {userInput} = {result}");
            }
            
       }

        
        
        
        
        
        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //problem #1
            PrintNumbers();
            
          //problem #2
            PrintEveryThirdNumber();
            
           //problem #3
           bool answer1 = AreNumbersEqual(8,8);
           Console.WriteLine(answer1);
            
            //problem #4
           bool answer2 = IsEven(22);
            Console.WriteLine(answer2);
           
          //problem #5
            bool answer3 = IsPositive(15);
            Console.WriteLine(answer3);

          //can vote problem #6
          Console.WriteLine("Enter the age if you are allowed to vote: ");
          string age = Console.ReadLine();
          int parsedAge = int.Parse(age);
         bool answer4 = CanVote(parsedAge);
          Console.WriteLine(answer4);
          
          
          //heatin up section problem 1
          Console.WriteLine("Kindly Enter an integer between -10 and 10: ");
          string number7 = Console.ReadLine();
          int userInput = int.Parse(number7);
          bool answer5 = IsInRange(userInput);
          Console.WriteLine(answer5);
          
          
          //heatin up section problem 2
          DisplayMultiplicationTable();







        }
    }
}
