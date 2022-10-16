System.Console.Write("Введите число неравное нулю > ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
{   
  System.Console.Write("Вы ввели 0, число не является четным");
}
else
{
    if (number % 2 == 0)
    {
    System.Console.WriteLine($"Число {number} четное"); 
    }
    else
    {
    System.Console.WriteLine($"Число {number} не является четным");     
    }
}