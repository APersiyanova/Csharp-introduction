// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = int.Parse(Console.ReadLine());

// if(num1 == num2*num2)
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }


//программа на вход принимает целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Console.WriteLine("Введите положительное число");
// long N = int.Parse(Console.ReadLine());
// long i = -1 * N;
// while (i <= N)
// {
// Console.Write(i);
// Console.Write(' ');
// i=i+1;
// }

// Программа принимает трехзначное число и вываодит сумму первого и последнего чисел
// 456 => 10
// 782 => 9
// 918 => 17
Console.WriteLine("введите трехзначное число");
int a = int.Parse(Console.ReadLine());
int a1 = a / 100;
int a3 = a % 10;
int result = a1 + a3;
Console.WriteLine(a1);
Console.WriteLine(a3);
Console.Write("first + third number is: ");
Console.Write(result);

Console.WriteLine();
int a2 = a/10%10; 
// Console.Write("second number is: "+a2); //Конкатенация строк
// Console.Write(a2);
Console.WriteLine($"second number is: {a2}"); // Интерполяция строк