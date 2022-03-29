bool check;
int len;
Console.WriteLine("Игра \"Угадай число\"");
Console.WriteLine("1. вводится максимально возможное для загадывания число. минимальное - 0");
Console.WriteLine("2. вводится предполагаемое пользователем число");
Console.WriteLine("игра завершается, если число отгадано, либо если введено \"пустое\" число");

do
{
    Console.Write("\nмаксимальное число: ");
    check = int.TryParse(Console.ReadLine(), out len);
    if (!check)
    {
        Console.WriteLine("введено неопознанное число, введите повторно!");
        //Console.ReadKey();
        continue;
    }
    else if (len <= 0)
    {
        Console.WriteLine("введено отрицательное число или 0, введите повторно!");
        //Console.ReadKey();
        continue;
    }
    else
    {
        Console.WriteLine($"максимальное число ({len}) принято.");
        break;
    }
}
while (true);

int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    arr[i] = i;
}

Random r = new Random();
int GuessNum = r.Next(0, len + 1);
//Console.WriteLine($"{GuessNum}");

int UserTry = 0;
bool ustal = false;
string proba;
do
{
    do
    {
        Console.Write("\nвведите число: ");
        proba = Console.ReadLine();
        if (proba == "")
        {
            ustal = true;
            break;
        }
        check = int.TryParse(proba, out UserTry);
        if (!check)
        {
            Console.WriteLine("введено неопознанное число, введите повторно!");
            //Console.ReadKey();
            continue;
        }
        else if (UserTry < 0)
        {
            Console.WriteLine("введено отрицательное число, введите повторно!");
            //Console.ReadKey();
            continue;
        }
        else
        {
            break;
        }
    }
    while (true);

    if (UserTry == GuessNum && !ustal)
    {
        Console.WriteLine($"Верно! число {GuessNum} отгадано.");
        break;
    }
    else
    {
        if (UserTry < GuessNum && !ustal)
        {
            Console.WriteLine("Это число меньше, введите БОЛЬШЕЕ");
            continue;
        }
        else
            if (UserTry > GuessNum && !ustal)
            {
                Console.WriteLine("Это число БОЛЬШЕ, введите меньшее");
                continue;
            }
            else
            {
            Console.WriteLine($"устал? понимаю\nБыло загадано число {GuessNum}");
            }     
    }
}
while (true && ustal == false);