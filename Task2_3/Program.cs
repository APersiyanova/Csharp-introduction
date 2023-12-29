// See https://aka.ms/new-console-template for more information
// Программа принимает на вход 2 числа и выводит, является ли второе число кратным первому
// Если второе число не кратно первому, то выводится остаток от деления
Console.WriteLine("Введите первое число");
int a1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число. Выполнится проверка, кратно ли оно первому числу");
int a2=int.Parse(Console.ReadLine());
if (a2%a1 == 0){
    Console.WriteLine($"Второе число {a2} кратно первому {a1}");
}
if (a2%a1 != 0){
    Console.WriteLine($"Второе число {a2} не кратно первому {a1}, остаток от деления {a2%a1}");
}

