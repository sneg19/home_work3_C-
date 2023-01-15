Console.WriteLine("Введите любое число: ");
int number = Int32.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.WriteLine($"{number} четное");
}
else 
{
    Console.WriteLine($"{number} нечетное");
}