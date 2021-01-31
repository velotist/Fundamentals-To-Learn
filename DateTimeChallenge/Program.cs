using System;

namespace DateTimeChallenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Operation on Date

            DateTime now = DateTime.Now;

            Console.Write("Please enter your previous date    ");
            DateTime previousDate = DateTime.ParseExact(Console.ReadLine(), "m/d/yy", null).Date;

            int daysAgo = (now - previousDate).Days;

            Console.WriteLine($"{now.ToShortDateString()} - {previousDate.ToShortDateString()} = {daysAgo} days ago");

            #endregion

            #region Operation on Time

            Console.WriteLine("Which format do you want to use? ");
            bool isCorrectFormat = int.TryParse(Console.ReadLine(), out int timeFormat);

            Console.Write("Please enter your previous time    ");
            TimeSpan previousTime;

            if (isCorrectFormat && timeFormat == 12)
            {
                previousTime = DateTime.ParseExact(Console.ReadLine(), "hh:mm tt", null).TimeOfDay;
            }
            else if (isCorrectFormat && timeFormat == 24)
            {
                previousTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null).TimeOfDay;
            }
            else
            {
                throw new InvalidOperationException("Not known format");
            }

            string hoursAgo = (now.ToLocalTime() - previousTime).ToShortTimeString();
            Console.WriteLine($"{now.ToLongTimeString()} - {previousTime} = {hoursAgo} hours ago");

            #endregion

            Console.ReadLine();
        }
    }
}
