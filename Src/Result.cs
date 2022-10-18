using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int priDiagonal = 0;
            int secDiagonal = 0;

            for (int i = 0; i < arr[0].Count; i++)
            {
                priDiagonal += arr[i][i];
                secDiagonal += arr[i][(arr.Count - 1) - i];
            }

            return Math.Abs(priDiagonal - secDiagonal);
        }
    }
}