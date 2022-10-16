System.Console.Write("Введите первое число >");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число >");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    System.Console.WriteLine($"max=min={number1}");
}
else
{
if (number1 > number2)
    {
System.Console.WriteLine($"max={number1}, min={number2}"); 
    }
    else 
    {
        System.Console.WriteLine($"max={number2}, min={number1}");
    }
}   

