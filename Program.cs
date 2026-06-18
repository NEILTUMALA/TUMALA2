while (true)
{
    Console.Write("Enter first number (or 'exit' to quit): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    double num1 = Convert.ToDouble(input);

    Console.Write("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter operation +, -, *, /: ");
    string operation = Console.ReadLine();

    double result = 0;

    switch (operation)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            result = num1 / num2;
            break;
        default:
            Console.WriteLine("Invalid operation.");
            continue;
    }

    Console.WriteLine($"Result: {result}");
    Console.WriteLine();
}