using System;

class Program
{
    public static void Main(string[] args)
    {
        int dice;

        System.Random random = new System.Random();

        Console.Write("if you want positive dice, type 1, if you want a negative, type 2: ");
        dice = Convert.ToInt32(Console.ReadLine());

        if (dice == 1)
        {
            int num;

            num = random.Next(6);

             Console.WriteLine("your number is" + num + ".");
        }
        else
        {
            int num;

            num = random.Next(-6, -1);

             Console.WriteLine("your number is" + num + ".");
        }

        Console.WriteLine("\nDone.");
    }
}