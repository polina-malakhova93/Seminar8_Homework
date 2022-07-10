
int[,] numbers = new int[3, 5];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 10);
    }
}
PrintArray(numbers);
int minSumLine = 0;
int sumLine = SumLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(numbers, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"Строкa с наименьшей суммой  элементов :{minSumLine+1} Сумма:{sumLine}");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
    
 

void PrintArray(int[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

