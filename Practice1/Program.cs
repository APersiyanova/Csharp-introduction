// See https://aka.ms/new-console-template for more information
// Программа на вход принимает 2 числа и проверяет, является ли первое квадратом второго
//int a = 9;
//int b = -3;
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
//int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
int b = int.Parse(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine("да, первое число является квадратом второго");
}
else { Console.WriteLine("нет, первое число не является квадратом второго"); }
