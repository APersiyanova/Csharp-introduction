// See https://aka.ms/new-console-template for more information
// Программа показывает наибольшую цифру числа из диапазона [10,99]
Console.WriteLine("Введите число от 10 до 99 включительно");
int number = int.Parse(Console.ReadLine());
if (number >= 10 && number <= 99)
{
    int max = number / 10;
    int b = number % 10;
    if (b > max)
    {
        max = b;
    }
    Console.WriteLine($"Самая большая цифра введенного числа: {max}");
}
else {Console.WriteLine("Введенное число выходит за допустимые пределы");}