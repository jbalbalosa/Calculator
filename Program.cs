Console.WriteLine("Building a Conditional-Based Calculator\n");

int num1 = 0;
int num2 = 0;
int result = 0;
int operation = 0;

Console.WriteLine("Input your first number:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input your second number:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Choose arithmetic operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

operation = int.Parse(Console.ReadLine());
switch (operation)
{ 
    case 1:
        {
            result = num1 + num2;
            break;
        }
    case 2:
        {
            result = num1 - num2;
            break;
        } 
    case 3: 
        {
            result = num1 * num2;
            break;
        }
    case 4: 
        {
            result = num1 / num2;
            break;
        }
}

Console.WriteLine($"Result of {num1} + {num2} is {result}");
Console.ReadKey();