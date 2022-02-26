namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to calculator!");
            Console.WriteLine("What is your first number?");
            var first = Console.ReadLine();
            Console.WriteLine("What is your second number?");
            var second = Console.ReadLine();
            Console.WriteLine("What will the operation be? (+ / -  *) ");
            var third = Console.ReadLine();

        }
    }
}

