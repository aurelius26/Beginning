FileInfo file = new FileInfo(@"sw1.txt");
StreamWriter sw = new StreamWriter("sw1.txt",true);
StreamReader sr = new StreamReader("sw1.txt");
StringWriter strw = new StringWriter();

static void WriteString(StringWriter strw_temp)
{
    DateTime dateTime = DateTime.Now;
    TimeSpan age;
    int age2;
    string Birth;
    //StreamWriter sw_temp = new StreamWriter("sw1.txt");
    Console.Write("vvedite nomer: ");
    strw_temp.Write(Console.ReadLine() + "#");

    strw_temp.Write(dateTime.ToString("g")+"#");

    Console.Write("vvedite FIO: ");
    strw_temp.Write(Console.ReadLine() + "#");

    Console.Write("vvedite datu rojdeniya (format: dd.mm.gggg): ");
    Birth = Console.ReadLine();
    //sw_temp.Write(DateTime.Now - DateTime.ParseExact(Birth,"d",null) + "#");
    age = DateTime.Now - DateTime.ParseExact(Birth, "d", null);
    strw_temp.Write($"{age.Days / 365}#");
    strw_temp.Write($"{Birth}#");

    Console.Write("vvedite mesto rojdeniya: ");
    strw_temp.Write(Console.ReadLine()+"\n");

    strw_temp.Close();
}

static void ReadString(StreamReader strr_temp)
{
    string[] words = strr_temp.ReadLine().Split('#');
    foreach (string item in words)
    {
        Console.Write($"{item}___");
    }
}

Console.WriteLine("vvedite: 1 (vivesti dannie ns ekran) ili 2 (zapolnenie dannyh):");

var i = Console.ReadLine();
switch (i)
{
    case "2":
        WriteString(strw);
        Console.WriteLine(strw);
        sw.Write(strw.ToString());
        sw.Close();
        break;
    case "1":
        ReadString(sr);
        break;
    default:
        Console.WriteLine("neverno vvedeno chislo vybora");
        break;
}