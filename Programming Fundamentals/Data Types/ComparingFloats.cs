using System;

namespace ComparingFloats
{
    public class ComparingFloats
    {
        public static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double difference = Math.Abs(firstNumber - secondNumber);
            const double epsilon = 0.000001;

            if (difference < epsilon)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
