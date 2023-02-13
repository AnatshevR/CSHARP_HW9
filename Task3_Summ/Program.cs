// Найти сумму элементов от M до N, N и M заданы

int Summ (int M, int N)
{
    if (M==N) return M;
    if (M>N)
    {
        return M + Summ(M-1,N);
    }
    else
    {
        return M + Summ(M+1,N);
    }
}


Console.WriteLine("Enter integer M");
int M= int.Parse(Console.ReadLine());
Console.WriteLine("Enter integer N");
int N= int.Parse(Console.ReadLine());
Console.Write("sum of numbers from " + M + " to " + N + " = ");
Console.WriteLine(Summ(M,N));
