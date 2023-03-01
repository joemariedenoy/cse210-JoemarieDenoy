using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("This is a  sample")

        Console.Write("Enter number ");
        string valueFromUser = Console.ReadLine();
        
        int x = int.Parse(valueFromUser);
        int y = 5;

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Lesser");
        }
        else
        {
            Console.WriteLine("Equal");
        }
    }
}