// See https://aka.ms/new-console-template for more information
// Программа на вход принимает натуральное число N, а на выходе показывает его цифры через запятую
Console.WriteLine("Введите натуральное число");
int N = Convert.ToInt32(Console.ReadLine());

int result;
while (N>=10){
    result = N%10; 
    Console.Write(result + ",");
    N /= 10;
}
result = N%10; 
Console.WriteLine(result);



