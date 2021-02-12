using System;
using static System.Console;


namespace assignment1
{
    /**
        Name: Kei 
        Date: 2/4/21
    **/
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter an ID number.");
            string idNum = Console.ReadLine();

            System.Console.WriteLine("Enter your dog's name.");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter your dog's breed.");
            string breed = Console.ReadLine();

            System.Console.WriteLine("Enter the amount of week your dog will be staying with us.");
            string numWeek = Console.ReadLine();

            System.Console.WriteLine("Enter yyour dog's weight.");
            int weight = int.Parse(Console.ReadLine());


            if( weight < 15 )
            {
                Console.WriteLine($"For owner {idNum}, your dog {breed} {name} is {weight} pounds. They will be staying with us for {numWeek} & the price is $55");
            }
            else
            {
                if (weight <= 30)
                {
                    Console.WriteLine($"For owner {idNum}, your dog {breed} {name} is {weight} pounds. They will be staying with us for {numWeek} & the price is $75");
                }
                else
                {
                    if (weight < 80)
                    {
                        Console.WriteLine($"For owner {idNum}, your dog {breed} {name} is {weight} pounds. They will be staying with us for {numWeek} & te price is $105");
                    }
                    else
                    {
                        Console.WriteLine($"For owner {idNum}, your dog {breed} {name} is {weight} pounds. They will be staying with us for {numWeek} & the price is $125. You also get a 2% discount!");
                    }
                }

            }
            
        }
    }
}