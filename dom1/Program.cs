Console.WriteLine("Введите число1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2");
int number2 = int.Parse(Console.ReadLine());
int max, min;

if (number2 > number1)
{
   max = number2;
   min = number1;
}
else 
{
  max = number1;
  min = number2;
}

Console.WriteLine($"Большее число равно {max}");
Console.WriteLine($"Меньшее число равно {min}");