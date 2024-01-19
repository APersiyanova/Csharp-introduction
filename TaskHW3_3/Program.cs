// See https://aka.ms/new-console-template for more information
// Разница между максимальным и минимальным элементами массива
// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Начальные условия:
// double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// Выводится: 5.15
double[] numbers = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};

double kMin=numbers[0];
for (int i = 1; i<numbers.Length;i++){
    if (numbers[i]<kMin){
        kMin=numbers[i];
    }
}

double kMax=numbers[0];
for (int i = 1; i<numbers.Length;i++){
    if (numbers[i]>kMax){
        kMax=numbers[i];
    }
}

Console.WriteLine(kMin);
Console.WriteLine(kMax);
Console.WriteLine(kMax-kMin);
