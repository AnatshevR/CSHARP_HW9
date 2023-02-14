//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

void Fnumbers (int First, int Second, int count)
{
    if (count>0)
    {
    int M = First;
    int N = Second;
    int result = M + N;
    Console.WriteLine(result + " ");
    First = N;
    Second = result;
    count = count - 1;
    Fnumbers(First, Second,count);
    }
}

Console.WriteLine("enter first integer");
int P1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter second integer");
int P2 = int.Parse(Console.ReadLine());
Console.WriteLine("enter count");
int PC = int.Parse(Console.ReadLine());
Fnumbers(P1,P2,PC);
