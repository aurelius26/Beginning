bool check = true;
int strings, columns;
do
{
    Console.Write("\nvvedite chislo strok: ");
    check = int.TryParse(Console.ReadLine(),out strings);
    if (!check)
    {
        Console.WriteLine("vvedeno neopoznannoe chislo, vvedite povtorno!");
        Console.ReadKey();
        continue;
    }
    else if (strings <= 0)
    {
        Console.WriteLine("vvedeno otricatel'noe chislo ili 0, vvedite povtorno!");
        Console.ReadKey();
        continue;
    }
        else
        {
            Console.WriteLine($"chislo strok {strings} prinyato.");
            break;
        }
}
while (true) ;

do
{
    Console.Write("vvedite chislo stolbcov: ");
    check = int.TryParse(Console.ReadLine(), out columns);
    if (!check)
    {
        Console.WriteLine("\nvvedeno neopoznannoe chislo, vvedite povtorno!");
        Console.ReadKey();
        continue;
    }
    else if (columns <= 0)
    {
        Console.WriteLine("vvedeno otricatel'noe chislo ili 0, vvedite povtorno!");
        Console.ReadKey();
        continue;
    }
    else
    {
        Console.WriteLine($"chislo strok {columns} prinyato.");
        break;
    }
}
while (true);

Console.Clear();
Console.WriteLine($"matrica {strings} na {columns}:\n");

int[,] matrix = new int[strings,columns];
Random r = new Random();
int sum = 0;

for (int i = 0; i < strings; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = r.Next(-50,50);
        Console.Write($"{matrix[i,j]} ");
        sum+= matrix[i,j];
    }
    Console.WriteLine();
}

Console.WriteLine($"summa elementov matrici: {sum}");