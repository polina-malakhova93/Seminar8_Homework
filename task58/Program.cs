int[,] firstMatrix = new int[5,5];
FiLLArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = new int[5,5];
FiLLArray(secondMatrix);
PrintArray(secondMatrix);
int[,] resultMatrix = new int[5,5];

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
   
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
           resultMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
        }
        
    }
}

Console.WriteLine("Произведение двух матриц: ");
PrintArray(resultMatrix);
void FiLLArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }   
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
}
