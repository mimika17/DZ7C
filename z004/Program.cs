// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
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
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 100);
    }
    return array;

}
Console.WriteLine("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
int[] newone = FilloneArray(mas, m, n);
SelectionSort(newone);
int[,] newmas = FilltwoArray(newone, m, n);
Console.WriteLine();
PrintArray(newmas);
int[] FilloneArray(int[,] array, int m, int n)
{
    int a = m * n;
    int[] onemas = new int[a];
    int z = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            onemas[z] = array[i, j];
            z++;
        }
    }
    return onemas;

}
void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {

            if (array[j] < array[minPosition]) minPosition = j;

        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }


}
int[,] FilltwoArray(int[] array, int m, int n)
{
    int z = 0;
    int[,] twoarray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            twoarray[i, j] = array[z];
            z++;
        }
    }
    return twoarray;

}
