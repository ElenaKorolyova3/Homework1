﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3//

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
   Console.Write("Большее число: ");
   Console.WriteLine(numberOne);
}
else
{
   Console.Write("Большее число: ");
   Console.WriteLine(numberTwo);
}

if (numberOne > numberTwo)
{
   Console.Write("Меньшее число: ");
   Console.WriteLine(numberTwo);
}
else
{
   Console.Write("Меньшее число: ");
   Console.WriteLine(numberOne);
}
