int N = 10;
int[] array = { 2, 34, 56, 557, 23, 13, 2, 5, 7, 68 };
int i = 0;

while (i < N)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}