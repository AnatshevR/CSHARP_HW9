// Написать программу вычисления функции Аккермана
		
int AkkermanFunc(int m, int n)
{
	if(m == 0)
	{
		return n + 1;
	}
	if(m > 0 && n == 0)
	{
		return AkkermanFunc(m - 1, 1);
	}
	return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
Console.WriteLine("enter any integer M (for int type max value is 3)");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("enter any integer N (for int type max value is 11) ");
int N = int.Parse(Console.ReadLine());
Console.Write("result is: ");
Console.WriteLine(AkkermanFunc(M,N));
