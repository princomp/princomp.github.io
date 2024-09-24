using System; // required to use String.Format

public static class Crossword
{
    public static string Display(int[,] arrP)
    {
        string ret = "";
        for (int row = 0; row < arrP.GetLength(0); row++)
        {
            ret += "|";
            for (int col = 0; col < arrP.GetLength(1); col++)
            {
                ret += String.Format("{0,4}|", arrP[row, col]);
            }
            ret += "\n";
        }
        return ret;
    }

    public static bool Pair(int[,] arrP, int first, int second)
    {
        return PairRow(arrP, first, second)
            || PairRowInverse(arrP, first, second)
            || PairCol(arrP, first, second)
            || PairColInverse(arrP, first, second)
            || PairDiag(arrP, first, second)
            || PairDiagInverse(arrP, first, second);
    }

    public static bool PairRow(int[,] arrP, int first, int second)
    {
        bool foundPair = false;
        for (int row = 0; row < arrP.GetLength(0); row++)
        {
            for (int col = 0; col + 1 < arrP.GetLength(1); col++)
            {
                if (arrP[row, col] == first && arrP[row, col + 1] == second)
                {
                    foundPair = true;
                }

            }
        }
        return foundPair;
    }
    public static bool PairRowInverse(int[,] arrP, int first, int second)
    {
        return PairRow(arrP, second, first);
    }
    public static bool PairCol(int[,] arrP, int first, int second)
    {
        bool foundPair = false;
        for (int row = 0; row + 1 < arrP.GetLength(0); row++)
        {
            for (int col = 0; col < arrP.GetLength(1); col++)
            {
                if (arrP[row, col] == first && arrP[row+1, col] == second)
                {
                    foundPair = true;
                }

            }
        }
        return foundPair;
    }

    public static bool PairColInverse(int[,] arrP, int first, int second)
    {
        return PairCol(arrP, second, first);
    }
    public static bool PairDiag(int[,] arrP, int first, int second)
    {
        bool foundPair = false;
        for (int row = 0; row + 1 < arrP.GetLength(0); row++)
        {
            for (int col = 0; col +1 < arrP.GetLength(1); col++)
            {
                if (arrP[row, col] == first && arrP[row + 1, col+1] == second)
                {
                    foundPair = true;
                }

            }
        }
        return foundPair;
    }
    public static bool PairDiagInverse(int[,] arrP, int first, int second)
    {
        return PairDiag(arrP, second, first);
    }

}
