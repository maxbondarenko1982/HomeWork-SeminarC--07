// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[,]{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

System.Console.Write("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
CheckArray(array);

void CheckArray(int[,] array)
{
    if (n > array.GetLength(0) || m > array.GetLength(1))
    System.Console.WriteLine("такого числа нет в массиве");
    else
    Console.WriteLine($"{array[n-1,m-1]}");
}
