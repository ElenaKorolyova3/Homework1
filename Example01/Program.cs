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
