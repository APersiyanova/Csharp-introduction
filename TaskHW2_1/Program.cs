// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0){
    Console.WriteLine($"Число {number} кратно и 7, и 23");
}
else {
    Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно");
}
