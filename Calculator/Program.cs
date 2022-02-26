namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to calculator!");
            Console.WriteLine("What is your first number?");
            double first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            double second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What will the operation be? (+ / -  *) ");
            string operation = Console.ReadLine()!;
            
           if (operation == "+")
            {
                Console.WriteLine("Your Result: {0}", (first + second));
            }
            if (operation == "-")
            {
                Console.WriteLine("Your Result: {0}", (first - second));
            }
            if (operation == "*")
            {
                Console.WriteLine("Your Result: {0}", (first * second));

            }
            if (operation == "/")
            {
                Console.WriteLine("Your Result: {0}", (first / second));
            }


        }
    }
}

