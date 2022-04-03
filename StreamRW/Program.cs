//var dirs = new DirectoryInfo(@"C:\").GetDirectories();

//StreamWriter sw = new StreamWriter("SW.txt");

//foreach (DirectoryInfo dir in dirs)
//{
//    sw.WriteLine(dir.Name);
//    Console.WriteLine($">>{dir.FullName}");
//}
//sw.Close();

//using (StreamReader sr = new StreamReader("SW.txt"))
//{
//    while (!sr.EndOfStream)
//    {
//        Console.WriteLine(sr.ReadLine());
//    }
//}
//string path;
//Console.WriteLine("vvedite put' k papke: ");
//path = Console.ReadLine();

//DirectoryInfo dirInfo = new DirectoryInfo(path);

//string[] AllDirs = Directory.GetDirectories(dirInfo.FullName);
//string[] AllFiles = Directory.GetFiles(dirInfo.FullName);
////dirInfo.CreateSubdirectory("created");
//using (StreamWriter sw = new StreamWriter("SW.txt"))
//{
//    do
//    {
//        sw.WriteLine(dirInfo.Name);
//    }
//    while ();
//}
//StreamReader sr = new StreamReader("SW.txt");
//sr.Close(); 
//foreach (string filename in AllDirs)
//{
//    Console.WriteLine(filename);
//}
//foreach (string filename in AllFiles)
//{   
//    Console.WriteLine($"_{filename}");
//}
Console.WriteLine("vvedite put' k papke: ");
string path = Console.ReadLine();

//File.Delete("sw.txt");
StreamWriter sw = new StreamWriter("SW.txt", false);

static void getdirs (StreamWriter sw_temp, string path, string trim = "")
{
    DirectoryInfo dir = new DirectoryInfo (path);
    foreach (var item in dir.GetDirectories())
    {
        Console.WriteLine($"{trim}{item.Name}");
        sw_temp.WriteLine(trim+item.Name);
        getdirs (sw_temp, item.FullName, trim+"-");

        foreach (var item_f in item.GetFiles())
        {
            Console.WriteLine($"{trim}{item_f.Name}");
            sw_temp.WriteLine(trim+item_f.Name);
        }
    }

//    foreach (var item in dir.GetFiles())
//    {
//        Console.WriteLine($"{trim}{item.Name}");
//        sw_temp.WriteLine(trim+item.Name);
//    }
}

getdirs(sw, path);
sw.Close();
sw.Dispose();