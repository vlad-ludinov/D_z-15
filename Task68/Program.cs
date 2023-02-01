using static System.Console;

int accerman = findAccerman(3,2);
WriteLine(accerman);

int findAccerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return findAccerman(n - 1, 1);
    else
      return findAccerman(n - 1, findAccerman(n, m - 1));
}