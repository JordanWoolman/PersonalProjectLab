using System;
namespace PersonalProjectLab
{
    public class EmptyClass
    {
        public EmptyClass()
        {
        }
        public decimal CalculatingKillAverage(int kills, int errors, int total)
        {
            //Kill average= (kill - errors)/ total
            decimal avg = 0.00m;

            avg = (decimal)(kills - errors) / total;
            return avg;

        }

        public decimal CalculatingPassingPercentage(int recieving_points, int total_points )
        {
            //passing average is total points divided by recieving points
            decimal pass = 0.00m;

            pass = (total_points / recieving_points);
            return pass;
        }
    }
}
