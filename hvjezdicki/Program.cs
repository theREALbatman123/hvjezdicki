int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(" (T_T) ");
    }
    Console.WriteLine();
}

for (int i = n; i >= 1; i--)
    {
    for (int j = 1; j <= i; j++) 
        {
        Console.Write(" (T_T) ");
        }
    Console.WriteLine();
    }