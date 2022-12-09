﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m=3;
int n=4;
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);


void FillArray(double[,] array)             
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 10))/10;
        }
    }
}
void PrintArray(double[,] array)                 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
          System.Console.WriteLine();
    }
}
