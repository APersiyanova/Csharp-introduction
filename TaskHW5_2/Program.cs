// See https://aka.ms/new-console-template for more information
// Поменяйте местами первую и последнюю строку массива
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Начальные условия:
// int[,] numbers = new int[,] {
    // {1, 2, 3, 4},
    // {5, 6, 7, 8},
    // {9, 10, 11, 12}
// }; 
// Выводится:
// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 

int[] intermediateArray = new int[]{0,0,0,0};

for (int j = 0; j<numbers.GetLength(1);j++){
    // Console.WriteLine(numbers[0,j]+" "+numbers.GetLength(0));
    intermediateArray[j] = numbers[0,j];
    numbers[0,j] = numbers[numbers.GetLength(0)-1,j];
    numbers[numbers.GetLength(0)-1,j] = intermediateArray[j];
}

for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j]+"	");
        }
        Console.WriteLine();
    }