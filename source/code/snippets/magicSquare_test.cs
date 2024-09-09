// Examples courtesy of https://en.wikipedia.org/wiki/Magic_square
int[,] arrayP1 = {
{ 4, 9, 2 },
{ 3, 5, 7 },
{ 8, 1, 6}
};


int[,] arrayP2 = {
{ 2 , 16 , 13 , 3}, 
{ 11 , 5 , 8 , 10}, 
{ 7 , 9 , 12 , 6}, 
{ 14 , 4 , 1 , 15}
};

int[,] arrayP3 = {
{ 2 , 16 , 13 , 3}, 
{ 11 , 5 , 8 , 10}, 
{ 7 , 9 , 12 , 6}, 
{ 14 , 4 , 1 , 15 }
};

int[,] arrayP4 = {
{ 1 , 23 , 16 , 4 , 21}, 
{ 15 , 14 , 7 , 18 , 11}, 
{ 24 , 17 , 13 , 9 , 2}, 
{ 20 , 8 , 19 , 12 , 6}, 
{ 5 , 3 , 10 , 22 , 25 }
};

int[,] arrayP5 = {
{ 13 , 22 , 18 , 27 , 11 , 20}, 
{ 31 , 4 , 36 , 9 , 29 , 2}, 
{ 12 , 21 , 14 , 23 , 16 , 25}, 
{ 30 , 3 , 5 , 32 , 34 , 7}, 
{ 17 , 26 , 10 , 19 , 15 , 24}, 
{ 8 , 35 , 28 , 1 , 6 , 33 }
};

int[,] arrayP6 = {
{ 46 , 8 , 16 , 20 , 29 , 7 , 49}, 
{ 3 , 40 , 35 , 36 , 18 , 41 , 2}, 
{ 44 , 12 , 33 , 23 , 19 , 38 , 6}, 
{ 28 , 26 , 11 , 25 , 39 , 24 , 22}, 
{ 5 , 37 , 31 , 27 , 17 , 13 , 45}, 
{ 48 , 9 , 15 , 14 , 32 , 10 , 47}, 
{ 1 , 43 , 34 , 30 , 21 , 42 , 4}
};

int[,] arrayP7 = {
{ 61 , 3 , 2 , 64 , 57 , 7 , 6 , 60}, 
{ 12 , 54 , 55 , 9 , 16 , 50 , 51 , 13}, 
{ 20 , 46 , 47 , 17 , 24 , 42 , 43 , 21}, 
{ 37 , 27 , 26 , 40 , 33 , 31 , 30 , 36}, 
{ 29 , 35 , 34 , 32 , 25 , 39 , 38 , 28}, 
{ 44 , 22 , 23 , 41 , 48 , 18 , 19 , 45}, 
{ 52 , 14 , 15 , 49 , 56 , 10 , 11 , 53}, 
{ 5 , 59 , 58 , 8 , 1 , 63 , 62 , 4 }
};

int[,] arrayP8 = {
{ 31 , 76 , 13 , 36 , 81 , 18 , 29 , 74 , 11}, 
{ 22 , 40 , 58 , 27 , 45 , 63 , 20 , 38 , 56}, 
{ 67 , 4 , 49 , 72 , 9 , 54 , 65 , 2 , 47}, 
{ 30 , 75 , 12 , 32 , 77 , 14 , 34 , 79 , 16}, 
{ 21 , 39 , 57 , 23 , 41 , 59 , 25 , 43 , 61}, 
{ 66 , 3 , 48 , 68 , 5 , 50 , 70 , 7 , 52}, 
{ 35 , 80 , 17 , 28 , 73 , 10 , 33 , 78 , 15}, 
{ 26 , 44 , 62 , 19 , 37 , 55 , 24 , 42 , 60}, 
{ 71 , 8 , 53 , 64 , 1 , 46 , 69 , 6 , 51}
};

Console.WriteLine("Example 1 is magic: " + isMagic(arrayP1));
Console.WriteLine("Example 2 is magic: " + isMagic(arrayP2));
Console.WriteLine("Example 3 is magic: " + isMagic(arrayP3));
Console.WriteLine("Example 4 is magic: " + isMagic(arrayP4));
Console.WriteLine("Example 5 is magic: " + isMagic(arrayP5));
Console.WriteLine("Example 6 is magic: " + isMagic(arrayP6));
Console.WriteLine("Example 7 is magic: " + isMagic(arrayP7));
Console.WriteLine("Example 8 is magic: " + isMagic(arrayP8));
