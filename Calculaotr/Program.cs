

Console.WriteLine("enter the opartion +-");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("enter a");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("enter b");
    int secondNum = Int32.Parse(Console.ReadLine());    

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;

    case '-':
        Subtract(firstNum, secondNum); 
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}


static void Addition(int a, int b)
{

    Console.WriteLine($"{a} + {b} = {a +b}");

}

static void Subtract(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");

}