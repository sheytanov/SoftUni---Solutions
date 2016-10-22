using System;

namespace ConvertSpeedUnits
{
    public class ConvertSpeedUnits
    {
        public static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = hours*3600 + minutes*60 + seconds;
            float metersPerSeconds = distanceInMeters/totalSeconds;
            float kilometersPerHour = (distanceInMeters/1000)/totalSeconds;
            //(metersPerSeconds*18)/5.0f;
            float milesPerHour = (distanceInMeters/1609)/totalSeconds;
                //kilometersPerHour/1.609f;

            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
