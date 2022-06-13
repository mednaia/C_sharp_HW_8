// Показать треугольник Паскаля 
System.Console.Write("Enter the number of rows: ");
int number = int.Parse(Console.ReadLine() ?? "0");
for (int y = 0; y < number; y++)
{         
    int count = 1;
    for (int q = 0; q < number - y; q++)
    {
        System.Console.Write("   ");
    }
    for (int x = 0; x <= y; x++)
    {
        System.Console.Write("   {0:d} ", count); //{0:d} применяет строку формата "d" к первому объекту в списке объектов
        count = count * (y - x) / (x + 1);
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}
System.Console.WriteLine();

