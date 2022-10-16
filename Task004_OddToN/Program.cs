System.Console.Write("Введите число строго больше нуля > ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number1 = number - 2;
if (number <= 0)
{
    System.Console.Write("Вы ввели число, не отвечающее необходимым условиям. Прочтите внимательно");
}
else
{
    if (number < 2)
    {
    System.Console.Write($"Четных чисел на интервале от 0 до {number} нет");
    }
    else
    {
      while (count <= number1)     
      {
        if (count % 2 == 0)
        {
        System.Console.Write($"{count}, ");
        }
    count++;
      }
    count = number - 1;
    while (count <= number)     
      {
        if (count % 2 == 0)
        {
        System.Console.Write($"{count}");
       }
    count++;
      }
    }
}    