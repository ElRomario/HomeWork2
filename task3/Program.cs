﻿/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/ 

Console.WriteLine("Введите число N:");
int num = int.Parse(Console.ReadLine());
for(int i =0; i <= num; i++)
{
    Console.WriteLine($"{Math.Pow(i, 3)}");
}
