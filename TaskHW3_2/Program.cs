// See https://aka.ms/new-console-template for more information
// Количество чётных чисел в массиве
// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Начальные условия:
// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6
int[] numbers = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int k=0;
for (int i=0;i <numbers.Length;i++){
    if (numbers[i]%2 == 0){
        k=k+1;
    }
}
Console.WriteLine(k);
