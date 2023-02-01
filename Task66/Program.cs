using static System.Console;

Write("Введите числа промежуток между которыми надо суммировать через запятую: ");
string [] interval = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);
int sum = findSum(int.Parse(interval[0]), int.Parse(interval[1]));
WriteLine($"Сумма чисел между {int.Parse(interval[0])} и {int.Parse(interval[1])} = {sum}");

int findSum(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + findSum(M+1,N);
    }
}