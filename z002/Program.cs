// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 100);
    }
    return array;

}
Console.WriteLine("Введите номер строки  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[5, 5];
FillArray(mas);
PrintArray(mas);
if (m > mas.GetLength(0) || n > mas.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
else Console.WriteLine($"Значение элемента [{m},{n}] равно {mas[m - 1, n - 1]} ");