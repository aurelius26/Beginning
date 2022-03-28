bool check;
int len;

do
{
    Console.Write("\nchislo elementov posledovatelnosti: ");
    check = int.TryParse(Console.ReadLine(), out len);
    if (!check)
    {
        Console.WriteLine("vvedeno neopoznannoe chislo, vvedite povtorno!");
        //Console.ReadKey();
        continue;
    }
    else if (len <= 0)
    {
        Console.WriteLine("vvedeno otricatel'noe chislo ili 0, vvedite povtorno!");
        //Console.ReadKey();
        continue;
    }
    else
    {
        Console.WriteLine($"chislo strok {len} prinyato.");
        break;
    }
}
while (true);

Console.Clear();

Console.Write($"\nchislo elementov posledovatelnosti: {len}\n\n");

int[] posl = new int[len];

for (int i = 0; i < len; i++)
{
    do
    {
        Console.Write($"{i+1}-i element: ");
        check = int.TryParse(Console.ReadLine(), out posl[i]);
        if (!check)
        {
            Console.WriteLine("vvedeno nekorrektnoe chislo, vvedite povtorno!");
            Console.ReadKey();
            continue;
        }
        else
        {
            break;
        }
    }
    while (true);
}

int minPos = 0, minimum = int.MaxValue;
Console.Clear();
Console.WriteLine("posledovatelnost' imeet vid:");
foreach (int i in posl)
{
    Console.Write($"{i} ");
    if(i < minimum)
    {
        minimum = i;
        //minPos = i;
    }
}

Console.WriteLine($"\nminimal'niy chlen posledovatel'nosti: {minimum}");