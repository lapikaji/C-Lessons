using System;

public class Answer
{
    public int FindMax(int num1, int num2, int num3)
    {
        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Answer answer = new Answer();
        int maxNumber = answer.FindMax(5, 10, 3);
        Console.WriteLine($"Максимальное число: {maxNumber}");
    }
}