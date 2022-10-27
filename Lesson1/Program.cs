Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

if (name.ToLower() == "meow")
{
    Console.WriteLine("Hello, Meow!!!");
}
else 
{
    Console.WriteLine("Hello, " + name);
}

int numberOne = new Random().Next(0, 100);
int numberTwo = new Random().Next(0, 100);
Console.WriteLine(numberOne);
Console.WriteLine(numberTwo);
Console.WriteLine(numberOne + numberTwo);