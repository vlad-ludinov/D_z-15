using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine()!);
printNumbers(number);

void printNumbers(int num)
{
    if (num == 1) 
    {
        Write(num);
    }
    else
    {
        Write($"{num}, ");
        printNumbers(num-1);
    }
}