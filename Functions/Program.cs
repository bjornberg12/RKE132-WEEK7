Console.WriteLine("are you coming or leaving (in or out)");


string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
} 
else
{
    PrintGoodBye();
}



static void PrintHello()
{
    Console.WriteLine("hello, world");
}

static void PrintGoodBye()
{

    Console.WriteLine("goodbye");
}
