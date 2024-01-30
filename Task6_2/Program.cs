// Вычисление функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
// Если n = 0
//     вернуть m + 1
// Если m = 0, n>0
//     вернуть Akkerman(n-1,1)
// Иначе при положительных n и m
//     вернуть Akkerman(m-1,A(m,n-1))
int Akkermana(int m, int n){
    if (n == 0){
        return m+1;
    }
    else if ((n>0) && (m==0)){
        return Akkermana(n-1,1);
    }
    else if ((n>0) && (m>0)){
        return Akkermana(n-1,Akkermana(n,m-1));
    }
    return Akkermana(n,m);
}

int m = 2;
int n = 3;
int Akk = Akkermana(m,n);
Console.WriteLine(Akk);