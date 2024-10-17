using System;

class Program
{
    static void Main()
    {
        int x = 1;
        int y = 2;
        int z;
        char c = Foo(x, ref y, out z);
        char d = Foo(x, ref y, out z, '%');
    }
    
    static char Foo(int x, ref int y, out int z, char symb = '*')
    {
        x++;
        y--;
        z = x + y;
        return symb;
    }
}
