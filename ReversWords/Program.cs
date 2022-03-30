
/// <summary>
/// метод деления строки на слова (делитель - пробел), возвращает массив слов в той же последовательности
/// </summary>
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

    string[] output = new string[count];
    Console.WriteLine();

    for (int i = 0; i < count; i++)
    {
        output = str1.Split(' ');
    }

    return output;
}

/// <summary>
/// метод выводит массив строк, каждое слово в новой строке; не возвращает что-либо
/// </summary>
static void WriteString(string[] str1)
{
    for (int i = 0; i < str1.Length; i++)
    {
        Console.WriteLine($"{str1[i]}");
    }
}

/// <summary>
/// метод замены очерёдности слов в массиве в обратной последовательности, вазвращает строку
/// </summary>
static string ReversWords(string[] str1)
{   
    string[] temp = new string[str1.Length];
    string OUT = "";

    for (int i = 0; i < str1.Length/2+1; i++)
    {
        temp[i] = str1[str1.Length-1-i];
        temp[str1.Length-1-i] = str1[i];
        //Console.WriteLine(temp[i]);
    }

    for (int i = 0; i < temp.Length; i++)
    {
        OUT+= temp[i] + " ";
    }
        
    return OUT;
}

Console.WriteLine(ReversWords(SplitString(Console.ReadLine())));

System.Threading.Thread.Sleep(5000);