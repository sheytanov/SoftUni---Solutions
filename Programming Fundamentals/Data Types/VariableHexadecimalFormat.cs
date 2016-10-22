using System;

namespace VariableHexadecimalFormat
{
    public class VariableHexadecimalFormat
    {
        public static void Main(string[] args)
        {
            string variableInHex = Console.ReadLine();
            int number = Convert.ToInt32(variableInHex, 16);

            Console.WriteLine(number);
        }
    }
}
