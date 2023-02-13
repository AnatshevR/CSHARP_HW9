// Показать натуральные числа от M до N, N и M заданы

void showMe(int M, int N)
{
    if(M==N) return;
    if (M>N)
    {
        Console.Write(M + " ");
        showMe (M-1,N);
    }
    else
    {
        Console.Write(M + " ");
        showMe(M+1,N);
    }
}


Console.WriteLine("Enter integer M");
int M= int.Parse(Console.ReadLine());
Console.WriteLine("Enter integer N");
int N= int.Parse(Console.ReadLine());
Console.WriteLine(" ");
showMe (M,N);
Console.WriteLine(N);
