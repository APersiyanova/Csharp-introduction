// Вывести элементы массива от M до N, начиная с конца, используя рекурсию
void MassiveOutput(int M, int N, int[] ourarray)
{
    if (M > N)
    {
        return;
    }
    Console.WriteLine($"{ourarray[M]} ");
    MassiveOutput(M + 1, N, ourarray);
}

int M = 3;
int N = 7;
int[] ourarray = new int[] { 17, 18, 13, 3, 4, 5, 6, 7, 64, 23, 91, 61 };
MassiveOutput(M, N, ourarray);

