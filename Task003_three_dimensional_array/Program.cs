// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента
int[,,] Create3DMatrix(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows,columns,depth];
    int count = 10;
    for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
                for(int g=0; g<depth; g++)
                {
                    matrix[i,j,g] = count;
                    count++;
                }
            }
        }
    return matrix;
}


void Print3DMatrix(int[,,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            for(int g=0; g<matrix.GetLength(2); g++)
            {
                Console.Write($"[{i},{j},{g}]:{matrix[i,j,g]}  ");
            }
        }
    Console.WriteLine();
    }

}

Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix depth: ");
int depth = int.Parse(Console.ReadLine() ?? "0");
int[,,] matrix = Create3DMatrix(rows,columns,depth);
if (rows*columns*depth+9>99)
{
    Console.WriteLine("You cannot fill matrix unique double-digit numbers.");
}
else
{
    Console.WriteLine("Your matrix: ");
    Print3DMatrix(matrix);
}






