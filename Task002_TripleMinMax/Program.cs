﻿System.Console.Write("Введите первое число > ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число > ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число > ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
System.Console.Write($"max={max}");  