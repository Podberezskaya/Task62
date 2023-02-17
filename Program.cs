// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите размер массива");
int [ ] size = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] array = new int[size[0], size [1]];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}
void InputArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]}\t");

      else Console.Write($"{array[i,j]}\t");
    }
    Console.WriteLine();
  }
}
InputArray(array);
