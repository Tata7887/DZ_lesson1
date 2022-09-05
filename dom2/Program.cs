Console.WriteLine("Введите число1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число3");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2) {
    if (number1 > number3) {
        Console.WriteLine($"Максиммальное число равно {number1}");
    } else {
        Console.WriteLine($"Максимальное число равно {number3}");
    }
} else {
    if (number2 > number3){
        Console.WriteLine($"Максимальное чисор равно {number2}");
    } else {
        Console.WriteLine($"Максимальное число равно {number3}");
    }
}
