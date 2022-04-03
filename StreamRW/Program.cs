var dirs = new DirectoryInfo(@"C:\").GetDirectories();

StreamWriter sw = new StreamWriter("SW.txt");

foreach (DirectoryInfo dir in dirs)
{
    sw.WriteLine(dir.Name);
    Console.WriteLine($">>{dir.FullName}");
}
sw.Close();

using (StreamReader sr = new StreamReader("SW.txt"))
{
    while (!sr.EndOfStream)
    {
        Console.WriteLine(sr.ReadLine());
    }
}