using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            while (shouldContinue)
            {
                //Prompt use to choose which stat they want to calculate 
                Console.WriteLine("Enter k for kill average and p for passing average");
                string stat = Console.ReadLine();

                //If they select kill average 
                if (stat == "k")
                {
                    string input = "";
                    int kills = 0;
                    int errors = 0;
                    int total = 0;

                    //Prompt them to enter kills, errors, and total attempts
                    Console.WriteLine("Enter the number of kills");
                    input = Console.ReadLine();
                    kills = int.Parse(input);
                    Console.WriteLine("Enter the number of errors");
                    input = Console.ReadLine();
                    errors = int.Parse(input);
                    Console.WriteLine("Enter the number of total");
                    input = Console.ReadLine();
                    total = int.Parse(input);

                    //calculate Kill average                  
                    VolleyballStats stats = new VolleyballStats();
                    decimal avg = stats.CalculatingKillAverage(kills, errors, total);                   

                    //Write batting average to the console
                    Console.WriteLine("Kills average:" + avg);
                }
                //Else if they select passing average
                else if (stat == "p")
                {
                    string input = "";
                    int receiving_points = 0;
                    int total_points = 0;

                    //Ask to enter amount of receiving points and total points
                    Console.WriteLine("Enter the number of receiving_points");
                    input = Console.ReadLine();
                    receiving_points = int.Parse(input);
                    Console.WriteLine("Enter the number of total_points");
                    input = Console.ReadLine();
                    total_points = int.Parse(input);

                    //calculate passing average
                    VolleyballStats stats = new VolleyballStats();
                    decimal avg = stats.CalculatingPassingPercentage(receiving_points,total_points);

                    //write passing average in console
                    Console.WriteLine("Passing percentage: " + avg);
                }
                //Prompt user if they want to continue
                //If yes return to beginning 
                Console.WriteLine("Enter yes for new stat or no to quit");
                string anotherStat = Console.ReadLine();

                if (anotherStat == "no")
                {
                    //Else end the program
                    shouldContinue = false;
                }
                
            }
           Console.WriteLine("I hope this was helpful :)"); 

        }
    }
}