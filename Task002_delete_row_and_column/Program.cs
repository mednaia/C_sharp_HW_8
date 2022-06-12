// В двумерном массиве целых чисел. 
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(-100,101);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}

int[,] DeleteMinValue(int[,] matrix)
{
    int min = matrix[0,0];
    int rowMin = 0;
    int columnMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j]<min) 
            {
                min = matrix[i, j];
                rowMin = i;
                columnMin = j;
            }
        }

    int[,] matrixNew = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    for(int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            if (i >= rowMin && j < columnMin)
                matrixNew[i, j] = matrix[i + 1, j];
            else if (j >= columnMin && i < rowMin)
                matrixNew[i, j] = matrix[i, j + 1];
            else if (i >= rowMin && j >= columnMin)
                matrixNew[i, j] = matrix[i + 1, j + 1];
            else
                matrixNew[i, j] = matrix[i, j];
        }       
    }
    return matrixNew;
}


Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
Console.WriteLine("Your changed matrix: ");
int[,] arrayNew = DeleteMinValue(matrix);
PrintMatrix(arrayNew);