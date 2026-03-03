using System;

namespace Topic_5._3_Multiple_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // This program checks if the user is a teenager based on their age.
            // COMPARISON OPERATORS
            // >=  Greater than or equal to
            // <=  Less than or equal to
            // >   Greater than
            // <   Less than
            // ==  Equal to (used for comparison, NOT assignment)
            // !=  Not equal to
            // BOOLEAN OPERATORS
            // && (AND)
            //     - BOTH conditions must be true
            //
            // || (OR)
            //     - At least ONE condition must be true
            //
            // ! (NOT)
            //     - Reverses a boolean value
            //     - Example: !working means "not working"



            // To be a teenager:
            // Age must be >= 13 AND <= 19
            // BOTH conditions must be true

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }

            else
            {
                Console.WriteLine("You are not a teenager.");
            }

            // Movie Eligibility Program
            // To go to the movies:
            // Must have at least $20.00
            // AND must NOT be working
            // !working means the person is not workin

            Console.WriteLine("How much money do you have?");
            double money = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you currently working? (true/false)");
            bool working = bool.Parse(Console.ReadLine());

            if (money >= 20.00 && !working)
            {
                Console.WriteLine("You can go to the movies!");
            }

            else
            {
             Console.WriteLine("You cannot go to the movies.");
            }

            // Password Check Program
            // The password must match EXACTLY (==)
            // AND guesses must be less than 5

            Console.WriteLine("Enter your passwords:");
            string password = Console.ReadLine();

            Console.WriteLine("How many guesses did you take?");
            int guesses = int .Parse(Console.ReadLine());

            if (password == "Ishq" && guesses < 5)
            {
                Console.WriteLine("Open sesame!");
            }

            else
            {
                Console.WriteLine("Access denied.");
            }

            //Pizza Topping Program
            // If the topping matches ANY favourite topping,
            // print "Yum!"
            // OR operator is used because only ONE must be true


            Console.Write("Enter a pizza topping: ");
            string topping = Console.ReadLine().ToLower();

            if (topping == "pepperoni" || topping == "mushrooms" || topping == "bacon")
            {
                Console.WriteLine("Yum!");
            }
            else
            {
                Console.WriteLine("Not my favourite, but enjoy!");
            }

            // Bus Pass Price Program
            // Discount applies if:
            // Age is 60 or older (senior)
            // OR
            // Age is 12 or younger (child)

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 60 || age <= 12)
            {
                Console.WriteLine("Your bus pass costs $2.00");
            }
            else
            {
                Console.WriteLine("Your bus pass costs $3.50");
            }

            //Favourite Animal Program
            // If animal is cat OR dog → print "Me too"

            Console.Write("What is your favourite type of animal? ");
            string animal = Console.ReadLine().ToLower();

            if (animal == "cat" || animal == "dog")
            {
                Console.WriteLine("Me too!");
            }
            else
            {
                Console.WriteLine("To each their own.");
            }

            //Weather Program
            // If it is sunny OR temperature is above 25,
            // then it is swim time.
            // Only ONE condition needs to be true.

            Console.Write("Enter the temperature: ");
            int temperature = int.Parse(Console.ReadLine());

            Console.Write("Enter the weather condition (sunny/cloudy): ");
            string condition = Console.ReadLine().ToLower();

            if (condition == "sunny" || temperature > 25)
            {
                Console.WriteLine("Swim time!");
            }
            else
            {
                Console.WriteLine("Nap time.");
            }

            // About AND (&&) and OR (||) Operators

         //   if ((age >= 13 && age <= 19) || age >= 60)

         // IMPORTANT NOTE ABOUT COMBINING CONDITIONS
         // You can combine AND and OR together.
         // Use brackets () to control the order of evaluation.
         //
         // Example:
         // if ((age >= 13 && age <= 19) || age >= 60)
         //
         // This means:
         // (Teenager) OR (Senior)
         //
         // Brackets make your logic clear and prevent errors.








        }
    }
}
