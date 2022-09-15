// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumLoop(int M, int N)
    {
        if (N < M) return 0;
        return N + SumLoop(M, N-1);
    }
try
{
    Console.WriteLine("Введите натуральные числа");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumLoop(m, n));
}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}

