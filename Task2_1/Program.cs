// See https://aka.ms/new-console-template for more information
// Принять на вход трехзначное число и удалить вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
// int number = int.Parse(Console.ReadLine()); 
int number = Convert.ToInt32(Console.ReadLine()); //Работает дольше, но переводит в целое любой тип, не только строку
if (number > 99 && number<1000){ // || логическое или
    int a = number / 100;
    int c = number % 10;
    int result = a * 10 + c;
    Console.WriteLine(result);
}
else Console.WriteLine("Введено не трехзначное число!");
