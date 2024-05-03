﻿using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
        for (int i = 2; i <= number; i += 2)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 5;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}