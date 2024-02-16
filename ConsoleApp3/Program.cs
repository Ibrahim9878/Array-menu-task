
string[] names = new string[5] { 
    "HUseyn",
    "Maga",
    "Semed",
    "Ibo",
    "Cavid"
};
int select = 0;
do
{
    Console.Clear();
    for (int i = 0; i <= 4; i++)
    {
    bool isCheck = false;
        if(i == select)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"--> {names[i]}");
            Console.ForegroundColor = ConsoleColor.White;
            isCheck = true;
        }
        if(!isCheck)
        Console.WriteLine(names[i]);
    }

    ConsoleKeyInfo info = Console.ReadKey();
    if (info.Key == ConsoleKey.UpArrow)
    {
        if (select == 0)
            select = 4;
        else select--;
    }
    else if(info.Key == ConsoleKey.DownArrow)
    {
        if (select == 4) select = 0;
        else select++;
    }
    else if(info.Key == ConsoleKey.Enter)
    {

    }
} while (true);
