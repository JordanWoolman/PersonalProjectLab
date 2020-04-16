using System;
namespace PersonalProjectLab
{
    public class VolleyballStats
    {
        public VolleyballStats()
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

            pass = ((decimal)total_points / recieving_points);
            return pass;
        }
    }
}
