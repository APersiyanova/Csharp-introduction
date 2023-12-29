// See https://aka.ms/new-console-template for more information
// Возвести вторую цифру двузначного числа в степень, равную третьей цифре этого числа
// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
// {
// int b = number / 10 % 10;
// int c = number % 10;
// int result = b ^ c;
// Console.Write($"Вторая цифра {b} в степени третьей цифры {c} равна: {result}");
// }
// else { Console.WriteLine("Введено не трехзначное число"); }

// using Random = System.Random();

// int num = new Random.Next(100,1000);
// Console.WriteLine(num);
// int b = num/10%10;
// int c = num/10;
// int result = 1;
// for (int i = 0; i<c; i++){
    // result=result*b;
// }
// Console.WriteLine(result);

// See https://aka.ms/new-console-template for more information
// Возвести вторую цифру двузначного числа в степень, равную третьей цифре этого числа
// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
// {
// int b = number / 10 % 10;
// int c = number % 10;
// int result = b ^ c;
// Console.Write($"Вторая цифра {b} в степени третьей цифры {c} равна: {result}");
// }
// else { Console.WriteLine("Введено не трехзначное число"); }

// int num = new Random.Next(100,1000);
// Console.WriteLine(num);
// int b = num/10%10;
// int c = num%10;
// int result = 1;
// for (i = 0; i<c; i++){
    // result=result*b;
// }
// Console.WriteLine(result);



// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


int num = new Random().Next(100,1000);
Console.WriteLine(num);

int num2 = num/10 %10;
int num3 = num % 10;
int result = 1;

for (int i = 0; i < num3; i++)
{
result = result * num2;
}
System.Console.WriteLine(result);
