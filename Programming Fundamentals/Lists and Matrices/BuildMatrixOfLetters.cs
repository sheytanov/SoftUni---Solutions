using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildMatrixOfLetters
{
    class BuildMatrixOfLetters
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                matrix[currentRow] = new char[cols];
            }

            char filler = 'A';

            for (int currentRow = 0; currentRow < matrix.Length; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrix[currentRow].Length; currentCol++)
                {
                    matrix[currentRow][currentCol] = filler;
                    filler++;
                }
            }


            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }


        }
    }
}
