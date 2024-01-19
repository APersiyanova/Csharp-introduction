// See https://aka.ms/new-console-template for more information
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия:
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5
int[] array;
array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива

int i;
int k = 0;
for (i = 0; i < array.Length; i++)
{
    if (array[i] >=10 && array[i]<=90)
    {
    k= k+1;
    }
}
Console.WriteLine(k);
