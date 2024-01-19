// See https://aka.ms/new-console-template for more information
// using System;
// System.Console.Write("Введите число элементов в массиве: ");
Console.Write("Введите число элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
//Random r = new Random(); // Экземпляр класса создаём и заносим в переменную r
int i;
for (i = 0; i < arr.Length; i++)
{
    //arr[i] = r.Next(0, 20);
    arr[i] = new Random().Next(-10,10); //Создаёи экземпляр класса
}
for (i = 0; i < arr.Length; i++)
{
    //Console.Write($"{arr[i]} ");
    Console.Write(arr[i]+" ");
}
// Определить, есть ли заданное число в массиве. 
Console.WriteLine();
Console.WriteLine("Введите число для проверки, есть ли это заданное число в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
bool nFound = false;
foreach (int e in arr)
{
    if (e == n)
    {
        //Console.WriteLine($"В массиве есть число {n}");
        nFound = true;
    }
}
if (!(nFound))
{
    Console.WriteLine($"В массиве нет числа {n}");
}
if (nFound)
{
    Console.WriteLine($"В массиве есть число {n}");
}

// Заменить положительные элементы на отрицательные, а отрицательные на положительные
for (i = 0;i <arr.Length;i++){
    arr[i]=arr[i]*(-1);
}
foreach (int e in arr){
    Console.Write(e+" ");
}
// Найти произведение пар чисел в массиве. Парой считать первый и последний, второй и предпоследние элементы и т.д.
Console.WriteLine();
int[] arrOutput = new int[arr.Length / 2 + arr.Length % 2];
for (i = 0; i < arrOutput.Length; i++)                   //i < (arr.Length / 2 + (arr.Length % 2))
{
    arrOutput[i] = arr[i] * arr[arr.Length - 1 - i];
    Console.Write(arrOutput[i] + " ");
}