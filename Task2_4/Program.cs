// See https://aka.ms/new-console-template for more information
// Программа выводит третью с конца цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите трехзначное число");
int i = Convert.ToInt32(Console.ReadLine());
if (i >99){
    int result = i/100%10;
    Console.WriteLine($"Третья с конца цифра: {result}");
}
else {Console.WriteLine("Третьей с конца цифры нет");}


// Вывести третью цифру с начала

while(i>=1000){
    i = i/10;
}
int res = i%10;
Console.WriteLine($"Третья с начала цифра: {res}");