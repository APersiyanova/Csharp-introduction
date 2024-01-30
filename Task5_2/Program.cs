// See https://aka.ms/new-console-template for more information
// Вывести на экран элементы двумерного массива, сумма цифр которых четная
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
                TwoDimensArray[i, j] = rnd.Next(100, 999);
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

void ShowEven(int[,] TwoDimensArray){
    for (int i = 0; i < TwoDimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimensArray.GetLength(1); j++)
        {
            int Even = 0;
            int TwoDimensArrayReserv = TwoDimensArray[i,j];
            while (TwoDimensArrayReserv>0){
                Even += TwoDimensArrayReserv % 10;
                TwoDimensArrayReserv /= 10;
            }
            if (Even %2 == 0){
                Console.Write(TwoDimensArray[i, j]+" ");
            }
        }
        Console.WriteLine();
    }
}

int[,] TwoDimensArray=GererateArray(a,b);
ShowArray(TwoDimensArray);
Console.WriteLine();
ShowEven(TwoDimensArray);
