//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Задайте 2 прямоуголных массива:");
Console.Write("Количество строк и столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array1 = new int [n, n];
int [,] array2 = new int [n, n];
CreateArray(array1);
CreateArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
int [,] array3 = MatrixProduct(array1, array2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
PrintArray(array3);
void CreateArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 9);
        }
    }
}
void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int [,] MatrixProduct (int [,] arr1, int [,] arr2)
{
    int [,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                arr3[i,j] += arr1[i,k] * arr2[k,j];
            }
        }
    }
   return arr3;
}


