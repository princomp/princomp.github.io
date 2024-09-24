using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] mat =
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
    };
        Console.WriteLine(Crossword.Display(mat));
        // Test Row:
        Console.WriteLine("13 is next to 15 on the same row: " + Crossword.PairRow(mat, 13, 15));
        Console.WriteLine("14 is next to 15 on the same row: " + Crossword.PairRow(mat, 14, 15));
        // Test "anti-row":
        Console.WriteLine("15 is next to 13 on the same row: " + Crossword.PairRowInverse(mat, 15, 13));
        Console.WriteLine("15 is next to 14 on the same row: " + Crossword.PairRowInverse(mat, 15, 14));
        // Test Col:
        Console.WriteLine("10 is next to 16 on the same col: " + Crossword.PairCol(mat, 10, 16));
        Console.WriteLine("10 is next to 14 on the same col: " + Crossword.PairCol(mat, 10, 14));
        // Test "anti-col":
        Console.WriteLine("16 is next to 10 on the same col: " + Crossword.PairColInverse(mat, 16, 10));
        Console.WriteLine("14 is next to 10 on the same col: " + Crossword.PairColInverse(mat, 14, 10));
        // Test Diag:
        Console.WriteLine("10 is next to 16 diagonally: " + Crossword.PairDiag(mat, 10, 16));
        Console.WriteLine("10 is next to 15 diagonally: " + Crossword.PairDiag(mat, 10, 15));
        // Test "anti-diag":
        Console.WriteLine("16 is next to 10 anti-diagonally: " + Crossword.PairDiagInverse(mat, 16, 10));
        Console.WriteLine("15 is next to 10 anti-diagonally: " + Crossword.PairDiagInverse(mat, 15, 10));

        for (int i = 1; i < 17; i++)
        {
            for (int j = 1; j < 17; j++)
            {
                if (Crossword.Pair(mat, i, j)) {
                            Console.WriteLine($"{i} is next to {j}.");
                              
                }
            }
        }
    }
}