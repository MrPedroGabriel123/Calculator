namespace Calculator;

internal static class Calculator
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter first number...");
            var userFirstNumber = Console.ReadLine();
            Console.WriteLine("Enter second number...");
            var userSecondNumber = Console.ReadLine();
            Console.WriteLine("Enter operation (* / + -)...");
            var operation = Console.ReadLine();

            if (!int.TryParse(userFirstNumber, out var firstNumber))
            {
                Console.WriteLine("Invalid number(s)...");
                continue;
            }

            if (!int.TryParse(userSecondNumber, out var secondNumber))
            {
                Console.WriteLine("Invalid number(s)...");
                continue;
            }

            switch (operation)
            {
                case "*":
                    Console.WriteLine($"Answer: {firstNumber * secondNumber}");
                    break;
                case "/":
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        Console.WriteLine("Cannot divide by zero...");
                        continue;
                    }

                    Console.WriteLine($"Answer: {firstNumber / secondNumber}");
                    break;
                case "+":
                    Console.WriteLine($"Answer: {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Answer: {firstNumber - secondNumber}");
                    break;
                default:
                    Console.WriteLine("Invalid input, try again...");
                    continue;
            }

            break;
        }
    }
}