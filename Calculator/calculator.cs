namespace Calculator;

internal static class Calculator
{
    private static void Main()
    {
        while (true) //Because you want to be in the loop for the entire thing so you don't have to repeat statements
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter first number...");
            var userFirstNumber = Console.ReadLine();
            Console.WriteLine("Enter second number...");
            var userSecondNumber = Console.ReadLine();
            Console.WriteLine("Enter operation (* / + -)...");
            var operation = Console.ReadLine();

            if (!int.TryParse(userFirstNumber, out var firstNumber))
            {   ///int.TryParse = Returns Bool (True or False).
              ///  It will literally "Try to Parse" the provided input.
 //If the input is a number, (TRUE condition) it will pass the input to the output(out). 
 ///If the input is a letter, (FALSE condition) it will go into the if Statement(Due to the!int.TryParse(!inverts the condition)) and will continue; skipping the rest of the loop and starting again.
            Console.WriteLine("Invalid number(s)...");
                continue; /// skips EVERYTHING AFTER in the loop and starts again from the top of the loop.
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
                    break;///Note, there's two breaks, one in the switch statement and one at the end. 
                         /// The one in the switch statement will break out of the Switch Statement which will put it at the very end of the loop which break;s out again.
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
