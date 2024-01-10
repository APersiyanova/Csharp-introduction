// See https://aka.ms/new-console-template for more information
// Random number = new Random();
// int c = number.Next(0,100);
// int d = number.Next(0,100);
// int a = number.Next(0,100);
// int b = number.Next(0, 100);
// int e = number.Next(0, 100);
// Console.WriteLine("Введите количество элементов массива со случайными значениями:");
// int N = Convert.ToInt32(Console.ReadLine());
Random number = new Random();
int N = number.Next(10,20);
int[] arrayWeight = new int[N];
int i;
for (i=0;i<N;i++){
    arrayWeight[i]=number.Next(0,100);
}
for (i =0;i<N;i++){
    Console.Write($"{arrayWeight[i]} ");
}
Console.WriteLine();
// int max = a;
int max=arrayWeight[0];
for (i=1;i<N;i++){
    if (arrayWeight[i]>max){
        max=arrayWeight[i];
    }
}
// if (max < b)
// {
    // max = b;
// }
// if (max < c)
// {
    // max = c;
// }
// if (max < d)
// {
    // max = d;
// }
// if (max < e)
// {
    // max = e;
// }
Console.Write($"In the array of {N} elements maximum is: {max}");