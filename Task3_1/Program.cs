// See https://aka.ms/new-console-template for more information
int[] firstArray = new int[5] { 1, 11, 111, 1111, 11111 }; //new int[] выделение памяти для массива
int[] secondArray = {2,22,222,2222,22222};
int i;
// for (i = 0; i < 5; i++)
// {
    // Console.WriteLine(firstArray[i]);
// }
// for (i = 0; i < 5; i++)
// {
    // Console.WriteLine(secondArray[i]);
// }

// Задача 1. Создать массив
Console.WriteLine("введите количество элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] arrTask1 = new int[N];
// Заполнить массив натуральными числами в количестве N

for (i = 0; i < arrTask1.Length; i++)
{
    arrTask1[i] = i + 1;
    Console.Write($"{arrTask1[i]} "); // Вывести элементы массива на экран.
}
// Вывести четные элементы массива на экран.
Console.WriteLine();
for (i = 0; i < arrTask1.Length; i=i+2)
{
    Console.Write($"{arrTask1[i]} ");
}

Console.WriteLine();
Random r = new Random();
for (i = 0; i < arrTask1.Length; i++)
{
    arrTask1[i]=r.Next(0,100);
    if (arrTask1[i] % 2 == 0)
    {
        Console.Write($"{i} - {arrTask1[i]} ");
    }
}