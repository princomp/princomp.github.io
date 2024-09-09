bool isMagic(int[,] arrayP)
{
    bool magicSoFar = true;
    if (arrayP.GetLength(0) == arrayP.GetLength(1))
    { // The array is a square.
        int magicConstant = 0;
        for (int i = 0; i < arrayP.GetLength(1); i++)
        {
            magicConstant += arrayP[i, i];
        }
        int testedValue = 0;
        for (int i = 0; i < arrayP.GetLength(1); i++)
        {
            testedValue += arrayP[i, arrayP.GetLength(1) - i - 1];
        }
        if (testedValue == magicConstant)
        {// The diagonal and anti-diagonal have the same sums.
            // We test the rows.
            for (int row = 0; row < arrayP.GetLength(0); row++)
            {
                testedValue = 0;
                for (int col = 0; col < arrayP.GetLength(1); col++)
                {
                    testedValue += arrayP[row, col];

                }

                if (testedValue != magicConstant)
                {
                    magicSoFar = false;
                }
            }
            // We test the columns.
            for (int col = 0; col < arrayP.GetLength(1); col++)
            {
                testedValue = 0;
                for (int row = 0; row < arrayP.GetLength(0); row++)
                {
                    testedValue += arrayP[row, col];
                }

                if (testedValue != magicConstant)
                {
                    magicSoFar = false;
                }
            }
        }
        else
        {// The diagonal and anti-diagonal have different same sums.
            magicSoFar = false;
        }
    }
    else
    { // The array is not a square.
        magicSoFar = false;
    }

    return magicSoFar;
} 
