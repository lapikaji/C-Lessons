﻿int N = 10;
int[] arr = new int[N];
int i = 0;

while (i < arr.Length)
//while (i < N)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(arr[' ']);
    Console.Write($"{arr[i]} ");
    i = i + 1;
}