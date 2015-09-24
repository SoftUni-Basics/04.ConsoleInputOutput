using System;
using System.Collections.Generic;

class KnightPath
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        int row = 0;
        int col = 7;
        matrix[row, col] = 1;

        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int tempRow = row;
            int tempCol = col;
            bool colChecker = false;
            bool rowChecker = false;

            if (input[0] != "stop")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == "left" || input[i] == "right")
                    {
                        if (input[i] == "left")
                        {
                            tempCol -= 2 - i;
                            colChecker = 0 <= tempCol && tempCol < 8;
                        }
                        else
                        {
                            tempCol += 2 - i;
                            colChecker = 0 <= tempCol && tempCol < 8;
                        }
                    }
                    else
                    {
                        if (input[i] == "down")
                        {
                            tempRow += 2 - i;
                            rowChecker = 0 <= tempRow && tempRow < 8;

                        }
                        else
                        {
                            tempRow -= 2 - i;
                            rowChecker = 0 <= tempRow && tempRow < 8;
                        }
                    }
                    if (rowChecker && colChecker)
                    {
                        row = tempRow;
                        col = tempCol;
                        if (matrix[row, col] == 0)
                        {
                            matrix[row, col] = 1;
                        }
                        else
                        {
                            matrix[row, col] = 0;
                        }
                    }
                }
            }
            else
            {
                break;
            }
        }

        List<int> output = GettingValues(matrix);

        if (output.Count == 0)
        {
            Console.WriteLine("[Board is empty]");
        }
        else
        {
            foreach (var value in output)
            {
                Console.WriteLine(value);
            }
        }
    }

    static List<int> GettingValues(int[,] matrix)
    {
        List<int> values = new List<int>();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string binary = string.Empty;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                binary += matrix[i, j];
            }
            int temp = Convert.ToInt32(binary, 2);
            if (temp > 0)
            {
                values.Add(temp);
            }
        }
        return values;
    }
}
