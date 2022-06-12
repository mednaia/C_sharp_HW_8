// Найти произведение двух матриц
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(-10,11);
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

int[,] ProductOfMatrixs(int[,] arr1, int[,] arr2)
{    
    int product = 0;
    int[,] productMass = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)  
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int r = 0; r < arr1.GetLength(1); r++)
            {
                product = product + arr1[i, r] * arr2[r, j];
            }
        productMass[i, j] = product;
        product = 0;
        }
    }
    return productMass;
}      

Console.Write("Enter amount of first matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of first matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns);
Console.Write("Enter amount of second matrix rows: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of second matrix columns: ");
int y = int.Parse(Console.ReadLine() ?? "0");
int[,] array = CreateMatrix(x,y);
if(rows!=y)
    Console.WriteLine("You cann't get a product of this matrixs.");
else 
{
    Console.WriteLine("Your first matrix: ");
    PrintMatrix(matrix);
    Console.WriteLine("Your second matrix: ");
    PrintMatrix(array);
    Console.WriteLine("The product of matrices: ");
    int[,] product = ProductOfMatrixs(matrix, array);
    PrintMatrix(product);
}