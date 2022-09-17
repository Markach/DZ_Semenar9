// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAckermann(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAckermann(m - 1, 1);
  else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
}

try
{
    Console.WriteLine("Введите натуральные числа");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int Ackermann = FunctionAckermann(m, n);
    Console.Write($"Функция Аккермана = {Ackermann} ");
}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}
