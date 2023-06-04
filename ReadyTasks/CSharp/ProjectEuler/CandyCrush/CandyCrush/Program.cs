using System;
using System.Linq;
using System.Collections.Generic;

namespace CandyCrush
{
    public class Solution
    {
        private void RemoveCandy(int[][] board, int indi, int indj)
        {
            for (int i = indi; i > 0; i--)
            {
                board[i][indj] = board[i - 1][indj];
            }
            board[0][indj] = 0;
        }

        private bool CheckVertical(int[][] board, int i, int j)
        {
            if (board[i][j] == 0)
            {
                return false;
            }
            int indL = i;
            while (indL >= 0 && board[indL][j] == board[i][j])
            {
                indL--;
            }
            indL++;
            int indH = i;
            while (indH < board.Length && board[indH][j] == board[i][j])
            {
                indH++;
            }
            indH--;
            return (indH - indL) >= 2;
        }

        private bool CheckHorizontal(int[][] board, int i, int j)
        {
            if (board[i][j] == 0)
            {
                return false;
            }
            int indL = j;
            while (indL >= 0 && board[i][indL] == board[i][j])
            {
                indL--;
            }
            indL++;
            int indH = j;
            while (indH < board[i].Length && board[i][indH] == board[i][j])
            {
                indH++;
            }
            indH--;
            return (indH - indL) >= 2;
        }

        private List<(int, int)> GetSimilarCells(int[][] board)
        {
            List<(int, int)> result = new List<(int, int)>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (CheckHorizontal(board, i, j) || CheckVertical(board, i, j))
                    {
                        result.Add((i, j));
                    }
                }
            }
            return result;
        }

        public int[][] CandyCrush(int[][] board)
        {
            int[][] copy = board.Select(x => x.ToArray()).ToArray();
            List<(int, int)> list = null;
            do
            {
                list = GetSimilarCells(copy);
                foreach (var c in list)
                {
                    RemoveCandy(copy, c.Item1, c.Item2);
                }
                Console.WriteLine("\n\n\n");
                Console.WriteLine(String.Join("\n", copy.Select(x => String.Join(", ", x.Select(y => y.ToString("D3"))))));
            }
            while (list.Count > 0);
            return copy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new[]{110, 5, 112, 113, 114 },
                new[]{210, 211, 5, 213, 214 },
                new[]{310, 311, 3, 313, 314 },
                new[]{410, 411, 412, 5, 414 },
                new[]{5, 1, 512, 3, 3 },
                new[]{610, 4, 1, 613, 614 },
                new[]{710, 1, 2, 713, 714 },
                new[]{810, 1, 2, 1, 1 },
                new[]{1, 1, 2, 2, 2 },
                new[]{4, 1, 4, 4, 1014 }
            };
            Console.WriteLine(String.Join("\n", arr.Select(x => String.Join(", ", x.Select(y => y.ToString("D3"))))));
            Console.WriteLine("\n\n\n");
            var res = new Solution().CandyCrush(arr);
            Console.WriteLine(String.Join("\n", res.Select(x => String.Join(", ", x.Select(y => y.ToString("D3"))))));
        }
    }
}
