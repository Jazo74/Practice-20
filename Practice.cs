using System;
using System.Collections.Generic;
using static dotnet_core_practice_toolbox.toolbox;

namespace dotnet_core_practice
{
    public static class Practice
    {

        public static void Circle()
        {
            Console.Clear();
            int x = JustNumber("What is the radian of the cirle or sphere?: ");
            Console.WriteLine("The circumferenc of the circle is " + Convert.ToString(2 * x * Math.PI));
            Console.WriteLine("The area of the circle is " + Convert.ToString(Math.Pow(x, 2) * Math.PI));
            Console.WriteLine("The area of the surface of the sphere is " + Convert.ToString(4 * Math.Pow(x, 2) * Math.PI));
            Console.WriteLine("The volume of the sphere is " + Convert.ToString(4 * Math.Pow(x, 3) * Math.PI / 3));
            Console.ReadKey();
        }
        public static void Threenumbers()
        {
            List<int> numberList = new List<int>();

            Console.Clear();
            for (int i = 1; i < 4; i++)
            {
                string message = "Give me the " + Convert.ToString(i) + ". number: ";
                numberList.Add(JustNumber(message));
            }
            numberList.Sort();
            Console.Write("The numbers in descending order: ");
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                Console.Write(numberList[i] + ", ");
            }
            Console.ReadKey();
        }
        public static void Triangle()
        {
            Console.Clear();
            int a, b, c;
            a = JustNumber("Give me the lenght of the 'a' side: ");
            b = JustNumber("Give me the lenght of the 'b' side: ");
            c = JustNumber("Give me the lenght of the 'c' side: ");
            if (a + b > c & a + c > b & b + c > a)
            {
                Console.WriteLine("This is a triangle.");
            }
            else
            {
                Console.WriteLine("This is not a triangle!");
            }
            Console.ReadKey();
        }
        public static void IsItNegative()
        {
            Console.Clear();
            int number = JustNumber("Give me the number: ");
            if (number >= 0)
            {
                Console.WriteLine("This is not negative.");
            }
            else
            {
                Console.WriteLine("This is negative.");
            }
            Console.ReadKey();
        }
        public static void BaseMath()
        {
            Console.Clear();
            int a, b;
            float div;
            a = JustNumber("Give me number 'a': ");
            b = JustNumber("Give me number 'b': ");
            Console.WriteLine("a + b = " + Convert.ToString(a + b));
            Console.WriteLine("a - b = " + Convert.ToString(a - b));
            Console.WriteLine("a * b = " + Convert.ToString(a * b));
            div = a / (float)b;
            Console.WriteLine("a / b = " + Convert.ToString(div));
            Console.ReadKey();
        }
        public static void IsItTrue()
        {
            if (Console.ReadLine().ToLower() == "true")
            {
                Console.WriteLine("IGAZ");
            }
        }
        public static void Average()
        {
            Console.Clear();
            int a = JustNumber("Give me number 'a': ");
            int b = JustNumber("Give me number 'b': ");
            float avg = ((float)a + b) / 2;
            Console.WriteLine("The average is " + Convert.ToString(avg));
            Console.ReadKey();
        }
        public static void Cuboid()
        {
            Console.Clear();
            int a = JustNumber("Give me number 'a': ");
            int b = JustNumber("Give me number 'b': ");
            int c = JustNumber("Give me number 'c': ");
            double sideDiagonalAB = Math.Sqrt(a * a + b * b);
            double sideDiagonalAC = Math.Sqrt(a * a + c * c);
            double sideDiagonalBC = Math.Sqrt(b * b + c * c);
            double cuboidDiagonal = Math.Sqrt(Math.Pow(sideDiagonalAB, 2) + Math.Pow(c, 2));
            double surface = (a * b + a * c + b * c) * 2;
            double volume = a * b * c;
            Console.WriteLine("The diagonal of side A-B is " + Convert.ToString(sideDiagonalAB));
            Console.WriteLine("The diagonal of side A-C is " + Convert.ToString(sideDiagonalAC));
            Console.WriteLine("The diagonal of side B-C is " + Convert.ToString(sideDiagonalBC));
            Console.WriteLine("The diagonal of the cuboid is " + Convert.ToString(cuboidDiagonal));
            Console.WriteLine("The surface of the cuboid is " + Convert.ToString(surface));
            Console.WriteLine("The volume of the cuboid is " + Convert.ToString(volume));
            Console.ReadKey();
        }
        public static void Cuboid2()
        {
            Console.Clear();
            int a = JustNumber("Give me number 'a': ");
            int b = JustNumber("Give me number 'b': ");
            int c = JustNumber("Give me number 'c': ");
            double sumSideLines = a * 4 + b * 4 + c * 4;
            Console.WriteLine("The summ of all edges is " + Convert.ToString(sumSideLines));
            Console.WriteLine("At the second part of the task, I don't know what the poet was thinking about...");
            Console.ReadKey();
        }
        public static void Volume()
        {
            Console.Clear();
            float a = JustNumber("Give me volume of the liquid in deciliter: ");
            Console.WriteLine("This is " + Convert.ToString(a/10) + " liter.");
            Console.WriteLine("This is " + Convert.ToString(a / 1000) + " hectoliter.");
            Console.ReadKey();
        }
        public static void CanBeDivideBy9()
        {
            Console.Clear();
            float a = JustNumber("Give me number: ");
            string number = Convert.ToString(a);
            int x = 0;
            foreach (char letter in number)
            {
                x += Convert.ToInt16(letter.ToString());
            }
            int y = x % 9;
            if (x == 9 && y == 0)
            {
                Console.WriteLine("This number can be divided by 9. (double checked!)");
            }
            else
            {
                Console.WriteLine("This number can not be divided by 9.");
            }
            Console.ReadKey();
        }
        public static void HowLong()
        {
            Console.Clear();
            int number = JustNumber("Give me the number: ");
            if (number >= 0)
            {
                Console.WriteLine("This is number has " + Convert.ToString(number).Length + " digits.");
            }
            else
            {
                Console.WriteLine("This is negative.");
            }
            Console.ReadKey();
        }
        public static void Seasons()
        {
            Console.Clear();
            string input = AnyInput("Give me the name of the month: ");
            if (input.ToLower() == "january" || input.ToLower() == "february" || input.ToLower() == "december")
            {
                Console.WriteLine(input + " is in winter.");
            }
            else if (input.ToLower() == "march" || input.ToLower() == "april" || input.ToLower() == "may")
            {
                Console.WriteLine(input + " is in spring.");
            }
            else if (input.ToLower() == "june" || input.ToLower() == "july" || input.ToLower() == "august")
            {
                Console.WriteLine(input + " is in summer.");
            }
            else if (input.ToLower() == "september" || input.ToLower() == "october" || input.ToLower() == "november")
            {
                Console.WriteLine(input + " is in autumn / fall.");
            }
            else
            {
                Console.WriteLine(input + " is not a month");

            }
            Console.ReadKey();
        }
        public static void IsProfitable()
        {
            Console.Clear();
            int income = JustNumber("Give me the income of the company: ");
            int expense = JustNumber("Give me the expense of the company: ");

            if (income > expense)
            {
                Console.WriteLine("The company has profit: " + Convert.ToString(income - expense) + " $.");
            }
            else if (income < expense)
            {
                Console.WriteLine("The company has loss: " + Convert.ToString(income - expense) + " $.");
            }
            else
            {
                Console.WriteLine("The company has no profit, nor loss: ");

            }
            Console.ReadKey();
        }
        public static void Language()
        {
            Console.Clear();
            List<string> question = new List<string>();
            List<string> output = new List<string>();
            string input;
            int count = 0;
            question.Add("Do you speak Hungarian? ");
            question.Add("Do you speak English? ");
            question.Add("Do you speak Spanish? ");
            output.Add("Jó reggelt!");
            output.Add("Good Morning!");
            output.Add("Buenos días!");
            for (int i = 0; i < 3; i++)
            {
                input = AnyInput(question[i]);
                if (input.ToLower() == "yes" || input.ToLower() == "yes, i do" || input.ToLower() == "i do")
                {
                    Console.WriteLine(output[i]);
                }
                else
                {
                    count += 1;
                }
            }
            if (count == 3) { Console.WriteLine("♥"); }
            AnyInput("Press any key to continue...");
        }
        public static void PasswordCheck()
        {
            Console.Clear();
            string password = AnyInput("Choose a new password!: ");
            int counter = JustNumber("How many tries allowed?: ");
            int tries = 0;
            for (int i=0; i<counter; i++)
            {
                string input = AnyInput("Enter the password: ");
                if (input == password)
                {
                    Console.WriteLine("The password is right.");
                    tries += 1;
                    break;
                }
                else
                {
                    Console.WriteLine("The password is wrong.");
                    tries += 1;
                }
                if (tries == counter)
                {
                    Console.WriteLine("No more tries left.");
                }
            }
            AnyInput("Press any key to continue...");

        }
        public static void Seasons2()
        {
            Console.Clear();
            int input = JustNumber("Give me the number of the month: ");
            if (input == 1 || input == 2 || input == 12)
            {
                Console.WriteLine(input + ".month is in winter.");
            }
            else if (input == 3 || input == 4 || input == 5)
            {
                Console.WriteLine(input + ".month is in spring.");
            }
            else if (input == 6 || input == 7 || input == 8)
            {
                Console.WriteLine(input + ".month is in summer.");
            }
            else if (input == 9 || input == 10 || input == 11)
            {
                Console.WriteLine(input + ".month is in autumn / fall.");
            }
            else
            {
                Console.WriteLine("There is no such month");
            }
            AnyInput("Press any key to continue...");
        }
        public static void AvgTemp()
        {
            Console.Clear();
            float temp = 0;
            string message;
            for (int i=1; i<13; i++)
            {
                message = "Give me the average temperature of the " + i.ToString() + ". month: ";
                temp += JustFloat(message);
            }
            Console.WriteLine("The average tempereture of this year is " + (temp / 12).ToString() + " Celsius degree.");
            AnyInput("Press any key to continue...");
        }
        public static void CupOfJoe()
        {
            Console.Clear();
            int price = 100;
            Console.WriteLine("The simple coffee is 100Ft.");
            bool doubleJoe = BoolInput("Would you like a double coffee? (Y/N) /+20Ft: " );
            bool withCream = BoolInput("Would you like the coffee with cream? (Y/N) /+50Ft: ");
            bool withOutCup = BoolInput("Would you like the coffee without a cup? (Y/N) /-10Ft: ");
            if (doubleJoe) { price += 20; }
            if (withCream) { price += 50; }
            if (withOutCup) { price -= 10; }
            Console.WriteLine("The price is " + price.ToString() + " Ft.");
            AnyInput("Press any key to continue...");
        }
        public static void Money()
        {
            Console.Clear();
            List<int> notesList = new List<int>();
            string notes = AnyInput("Give me all the notes, separated with comma :");
            if (notes[notes.Length-1].ToString() != ",")
            {
                notes += ",";
            }
            notes.Replace(" ", "");
            string temp = "";
            foreach (char x in notes)
            {
                if (x.ToString() != ",")
                {
                    temp += x.ToString();
                }
                else
                {
                    int y;
                    if (int.TryParse(temp, out y))
                    {
                        notesList.Add(int.Parse(temp));
                    }
                    temp = "";
                }
            }
            notesList.Sort();
            int minNote = notesList[0];
            notesList.Reverse();
            int money = JustNumber("How much money do you need?: ");
            foreach (int aNote in notesList)
            {
                if (money / aNote > 0)
                {
                    Console.WriteLine((money / aNote).ToString() + "x '" + aNote.ToString() + "' note");
                    money = money % aNote;
                }
            }
            Console.WriteLine("The left money is " + money.ToString());
            AnyInput("Press any key to continue...");
        }
    }
}
