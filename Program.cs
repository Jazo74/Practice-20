using System;
using System.IO;
using System.Threading;

namespace dotnet_core_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Menu();
                loop = Choice();
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Practice Menu");
            Console.WriteLine();
            Console.WriteLine("(0) Exit program");
            Console.WriteLine("(1) Circles and Spheres");
            Console.WriteLine("(2) Reverse number list");
            Console.WriteLine("(3) Is this a triangle?");
            Console.WriteLine("(4) Is it negative?");
            Console.WriteLine("(5) Base Math");
            Console.WriteLine("(6) Is it True?");
            Console.WriteLine("(7) Average");
            Console.WriteLine("(8) Cuboid");
            Console.WriteLine("(9) Cuboid...and whose army?");
            Console.WriteLine("(10) Volume convert");
            Console.WriteLine("(11) Can it be divided by 9?");
            Console.WriteLine("(12) How many digits in this number");
            Console.WriteLine("(13) Which season");
            Console.WriteLine("(14) Company profit");
            Console.WriteLine("(15) Language");
            Console.WriteLine("(16) Password");
            Console.WriteLine("(17) Seasons... again");
            Console.WriteLine("(18) Average temperature");
            Console.WriteLine("(19) Wending machine");
            Console.WriteLine("(20) Bank notes");
            Console.WriteLine();
            Console.Write("Choose a number...: ");
        }
        static bool Choice()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Practice.Circle();
                    return true;
                case "2":
                    Practice.Threenumbers();
                    return true;
                case "3":
                    Practice.Triangle();
                    return true;
                case "4":
                    Practice.IsItNegative();
                    return true;
                case "5":
                    Practice.BaseMath();
                    return true;
                case "6":
                    Practice.IsItTrue();
                    return true;
                case "7":
                    Practice.Average();
                    return true;
                case "8":
                    Practice.Cuboid();
                    return true;
                case "9":
                    Practice.Cuboid2();
                    return true;
                case "10":
                    Practice.Volume();
                    return true;
                case "11":
                    Practice.CanBeDivideBy9();
                    return true;
                case "12":
                    Practice.HowLong();
                    return true;
                case "13":
                    Practice.Seasons();
                    return true;
                case "14":
                    Practice.IsProfitable();
                    return true;
                case "15":
                    Practice.Language();
                    return true;
                case "16":
                    Practice.PasswordCheck();
                    return true;
                case "17":
                    Practice.Seasons2();
                    return true;
                case "18":
                    Practice.AvgTemp();
                    return true;
                case "19":
                    Practice.CupOfJoe();
                    return true;
                case "20":
                    Practice.Money();
                    return true;
                case "0":
                    return false;
                default:
                    Console.Write(" Wrong choice!");
                    Thread.Sleep(1000);
                    return true;
            }
        }

    }
}
//float  y = 5.2f;
/*int x = 10;

int z;

Console.WriteLine(float.TryParse("123,3", out y));
Console.WriteLine(int.TryParse("alma", out x));
Console.WriteLine(int.TryParse("123alma", out x));
Console.WriteLine(int.TryParse("alma123korte5", out x));
x = int.Parse("456");
Console.WriteLine(x);*/



/*string fajlnev = "proba.txt";
StreamWriter irok = new StreamWriter(fajlnev, false);
irok.WriteLine("1. meg ezt a sort");
irok.WriteLine("2/ meg ezt a sort");
irok.WriteLine("3) meg ezt a sort");
irok.WriteLine("4} meg ezt a sort");
irok.Close();
StreamReader olvasok = new StreamReader(fajlnev);
while (olvasok.EndOfStream != true)
{ 
    Console.WriteLine(olvasok.ReadLine());
}
olvasok.Close();*/
