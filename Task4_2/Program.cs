// Массив заполняется случайными трехзначными числами.
// Выводится количество четных чисел в массиве.

Console.WriteLine("Введите количество элементов в массиве с трехзначными числами: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] randArray = new int[N];
CreateArray(N);
ShowArray();
int[] newArray = new int[N];
int count = 0;
count = CheckIfEven();

void CreateArray(int N){
    
    for (int i = 0; i<randArray.Length;i++){
    randArray[i]=new Random().Next(100,999);
    }
}

void ShowArray(){
    for (int i = 0; i<randArray.Length;i++){
        Console.Write(randArray[i]+" ");
    }
    Console.WriteLine();
}

int CheckIfEven(){
    for (int i = 0; i<randArray.Length;i++){
        if (randArray[i] %2 == 0){
            newArray[count] = randArray[i];
            count++;
        }
    }
    return count;
}

Console.WriteLine();
Console.WriteLine($"В массиве {count} четных чисел: ");
for (int c = 0; c<count;c++){
    Console.Write(newArray[c]+" ");
}