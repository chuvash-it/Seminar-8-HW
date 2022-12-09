//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задайте прямоуголный массив:");
Console.Write("Количество строк и столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [n, n];
CreateArray(array);
PrintArray(array);
int minimum = 0;
int amountline = LineAmount(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int summ = LineAmount(array, i);
  if (amountline > summ)
  {
    amountline = summ;
    minimum = i;
  }
}
Console.WriteLine($"Наименшая сумма чисел в {minimum+1} строке");

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
void PrintArray(int[,] arr)
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
int LineAmount(int[,] arr, int i)
{
  int amount = arr[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    amount += arr[i,j];
  }
  return amount;
}

