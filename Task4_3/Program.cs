// See https://aka.ms/new-console-template for more information
// Программа переворачивает одномерный массив: последний элемент становится первым, 
// первый - последним, второй - предпоследним
Console.WriteLine("Введите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] randArray = new int[N];
CreateArray(N);
ShowCreatedArray(randArray);
int[] invertedArray = new int[randArray.Length];
UpsideDownArray();
Console.WriteLine("Инвертированный массив: ");
ShowCreatedArray(invertedArray);

void CreateArray(int N){
    for (int i = 0; i<randArray.Length;i++){
    randArray[i]=new Random().Next(0,9);
    }
}

void ShowCreatedArray(int[] Array){
    for (int i = 0; i<Array.Length;i++){
    Console.Write(Array[i]+" ");
    } 
Console.WriteLine();
}

int[] UpsideDownArray(){
    int j=randArray.Length-1;
    for (int i = 0;i<randArray.Length;i++,j--){
        invertedArray[j] = randArray[i];
    }
    return invertedArray;
}

