// See https://aka.ms/new-console-template for more information
// Двумерный массив. Создание массива axb, напр., 3x5: из 3 строк по 5 элементов
Console.WriteLine("Введите число строк в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов в массиве: ");
int b = Convert.ToInt32(Console.ReadLine());


int[,] GererateArray(int a, int b){
    int[,] TwoDimensArray = new int[a, b];      
    Random rnd = new Random();
        for (int i = 0; i < TwoDimensArray.GetLength(0); i++)
        {
            for (int j = 0; j < TwoDimensArray.GetLength(1); j++)
            {
                TwoDimensArray[i, j] = rnd.Next(1, 20);
            }   
        }
    return (TwoDimensArray);
}

void ShowArray(int[,] TwoDimensArray){
    for (int i = 0; i < TwoDimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimensArray.GetLength(1); j++)
        {
            Console.Write(TwoDimensArray[i, j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] TwoDimensArray = GererateArray(a,b);
ShowArray(TwoDimensArray);

int [,] HandmadeArray = new int[2,3]{
    {1,1,3},
    {2,2,2}
};
Console.WriteLine();
ShowArray(HandmadeArray);