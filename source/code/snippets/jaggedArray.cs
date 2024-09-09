int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[3] { 1, 2, 3};
jaggedArray[1] = new int [2]{ 4, 5};
jaggedArray[2] = new int[5] { 6, 7, 8, 9, 10};

for (int row = 0; row < jaggedArray.Length; row++)
{
    Console.Write("The row #" + row + " contain: ");
    for (int arrayCell = 0; arrayCell < jaggedArray[row].Length; arrayCell++)
    {
        Console.Write(jaggedArray[row][arrayCell]+ " " ); 
    }
    Console.WriteLine("");
} 
