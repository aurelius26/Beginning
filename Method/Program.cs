static string[] SplitString(string str1)
{
    int count = 1;

    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] == ' ')
        {
            count++;
        }
    }

    string[]output = new string[count];
    Console.WriteLine();

    for (int i = 0; i < count; i++)
    {
        output = str1.Split(' ');
    }

    return output;
}

static void WriteString(string[] str1)
{
    for (int i = 0; i < str1.Length; i++)
    {
        Console.WriteLine($"{str1[i]}");
    }
}

WriteString(SplitString(Console.ReadLine()));
