
string? x = null;
int startVal = -1;
int endVal = -1;
bool gotInput = false;


do
{
    
    Console.WriteLine("Specifiy non negative integer to start at:");
    x = Console.ReadLine();
    if (x?.Length > 0)
    {
        gotInput = int.TryParse(x, out startVal);
    if (gotInput)
    {
        if (startVal < 0)
        {
            gotInput = false;
            Console.WriteLine("Number cannot be negative, trying again!");
            Console.WriteLine("...");
        }
    }
    else
    {
        Console.WriteLine("Invalid integer input, trying again!");
        Console.WriteLine("...");
    }
    }
    else
    {
        Console.WriteLine("No input given, trying again!");
        Console.WriteLine("...");
    }

}
while (!gotInput);

gotInput = false;
x = null;
do
{
    Console.WriteLine("\nSpecifiy a larger second integer to count up to:");
    x = Console.ReadLine();
    if (x?.Length > 0)
    {
        gotInput = int.TryParse(x, out endVal);
    if (gotInput)
    {
        if (endVal <= startVal)
        {
            gotInput = false;
            Console.WriteLine("End value must be larger than start value, trying again!");
            Console.WriteLine("...");
        }
    }
    else
    {
        Console.WriteLine("Invalid integer input, trying again!");
        Console.WriteLine("...");
    }
    }
    else
    {
        Console.WriteLine("No input given, trying again!");
        Console.WriteLine("...");
    }

}
while (!gotInput);

Console.WriteLine();
for (int i = startVal; i <= endVal; i++)
{
    if ((i % 3) * (i % 5) != 0)
    {
    Console.Write(i);
    }

    if (i % 3 == 0)
    {
        Console.Write("Fizz");
    }
    if (i % 5 == 0)
    {
        Console.Write("Buzz");
    }
    Console.WriteLine();
}