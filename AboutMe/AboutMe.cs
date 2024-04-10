using System;

class AboutMe
{
    public static void Main(string[] args)
    {
        Console.Title = "bennytrt's About Me";
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.Clear();
        Console.WriteLine("Hello, Welcome To bennytrt's About Me .CS File, Or .EXE File. (Press F To Continue.)");

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (char.ToUpper(keyInfo.KeyChar) == 'F' || char.ToUpper(keyInfo.KeyChar) == 'f')
        {
            Console.Clear();
            Console.WriteLine("Hello, Welcome To bennytrt's About Me .CS File, Or .EXE File. (Press F To Continue.)");
            Console.WriteLine("\nIn This Interactive Console, You'll Learn Stuff About Me, This Is Made Out Of Pure Boredom");
        }

        Console.WriteLine("Press Any Key To Quit");
        Console.ReadKey();
    }
}