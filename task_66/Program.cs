
int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}


Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");;