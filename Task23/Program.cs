﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

static void Main(){
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
   for (int i = 1; i <= number; i++)
   {
     Console.WriteLine(Math.Pow(i, 3));
   }
}
Main();