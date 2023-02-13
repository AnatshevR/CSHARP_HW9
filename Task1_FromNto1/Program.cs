// Показать натуральные числа от N до 1, N задано


void showMe( int N)
{
    if(N==0) return;
    Console.Write(N+" ");
    showMe(N-1);
}

Console.WriteLine("enter any integer");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
showMe(N);
