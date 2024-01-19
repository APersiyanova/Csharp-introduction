// See https://aka.ms/new-console-template for more information
// Дано натуральное трехзначное число. Создать массив из цифр этого числа.
// Младший разряд этого числа должен располагаться на 0 индексе массива,
// старший - на 2.
// FullNumber = Convert.ToInt32(Console.ReadLine()); // Дано натуральное трехзначное число
Console.Write("Введите число элементов в массива: ");
int N=Convert.ToInt32(Console.ReadLine());
int i;
int FullNumber = 0;
int k=N-1;
// int[] arrInicial = new int[5]{1,2,3,4,5};
int[] arrInicial = new int[N];
Console.Write("Массив:           ");
for (i = 0; i < arrInicial.Length; i++)
{
    arrInicial[i] = new Random().Next(0, 9);
    // Console.Write("arrInicial: "+arrInicial[i] + "\t");
    Console.Write(arrInicial[i]);
    FullNumber = FullNumber + arrInicial[i] * Convert.ToInt32(Math.Pow(10,k));
    // Console.WriteLine("k: "+k+"\t"+"Math.Pow"+Math.Pow(10,k)+"\t"+"FullNumber"+FullNumber+"\t");
    k = k-1;
}
Console.WriteLine();
Console.WriteLine("В форме числа: "+FullNumber);
int[] arrOutput = new int[arrInicial.Length];
k = 0;
// Console.WriteLine();
Console.Write("Обратный порядок: ");
// Вариант с изменением порядка элементов перебором индексов
// for (i=arrInicial.Length-1;i>=0;i--){
    // arrOutput[k] = arrInicial[i];
    // k+=k;
    // Console.Write(arrInicial[i]+"\t");
// }

for (k=0;k<arrInicial.Length;k++,FullNumber=FullNumber/10){
    arrOutput[k]=FullNumber%10;
    // FullNumber=FullNumber/10;
    Console.Write(arrOutput[k]);
}
