using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAMatrix
{
    class RotateAMatrix
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[][] matrix = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split();
            }

            for (int currentCol = 0; currentCol < cols; currentCol++)
            {
                for (int currentRow = rows - 1; currentRow >= 0; currentRow--)
                {
                    Console.Write(matrix[currentRow][currentCol] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
