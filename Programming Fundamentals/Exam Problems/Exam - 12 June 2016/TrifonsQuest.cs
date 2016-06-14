using System;
using System.Collections.Generic;
using System.Linq;

namespace TrifonsQuest
{
    public class TrifonsQuest
    {
        public static void Main(string[] args)
        {
            long healthPoints = long.Parse(Console.ReadLine());
            string[] dimensions = Console.ReadLine().Split();
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            
            char[][] map = new char[rows][];
            
            int currentTurns = 0;
            bool isAlive = true;
            int deadRow = -1;
            int deadCol = -1;
            
            for (int i = 0; i < rows; i++)
            {
                map[i] = Console.ReadLine().ToCharArray();
            }
            
            
            for (int currentCol = 0; currentCol < cols; currentCol++)
            {
                if (currentCol % 2 == 0 && isAlive)
                {
                    for (int currentRow = 0; currentRow < rows; currentRow++)
                    {
                        switch (map[currentRow][currentCol])
                        {
                            case 'F':
                                healthPoints = healthPoints - (currentTurns / 2);
                                if (healthPoints <= 0)
                                {
                                    isAlive = false;
                                    deadCol = currentCol;
                                    deadRow = currentRow;
                                }
                                currentTurns++;
                                break;
                            case 'H':
                                healthPoints = healthPoints + (currentTurns / 3);
                                currentTurns++;
                                break;
                            case 'E':
                                currentTurns++;
                                break;
                            case 'T':
                                currentTurns += 3;
                                break;
                        }
                        if (!isAlive)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int currentRow = rows - 1; currentRow >= 0; currentRow--)
                    {
                        switch (map[currentRow][currentCol])
                        {
                            case 'F':
                                healthPoints = healthPoints - (currentTurns / 2);
                                if (healthPoints <= 0)
                                {
                                    isAlive = false;
                                    deadCol = currentCol;
                                    deadRow = currentRow;
                                }
                                currentTurns++;
                                break;
                            case 'H':
                                healthPoints = healthPoints + (currentTurns / 3);
                                currentTurns++;
                                break;
                            case 'E':
                                currentTurns++;
                                break;
                            case 'T':
                                currentTurns += 3;
                                break;
                        }
                        if (!isAlive)
                        {
                            break;
                        }
                    }
                }
                if (!isAlive)
                {
                    break;
                }
            }
            if (!isAlive)
            {
                Console.WriteLine($"Died at: [{deadRow}, {deadCol}]");
            }
            else
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {healthPoints}");
                Console.WriteLine($"Turns: {currentTurns}");

            }
            

        }
    }
}