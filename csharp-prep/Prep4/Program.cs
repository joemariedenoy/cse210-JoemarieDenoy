using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // GET THE SUM
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // GET THE AVERAGE
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // FIND THE MAX
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");


    }
}