using System;
class Class2 : Class1
{
    private int attribute;
    public override int Property
    {
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            else attribute = value;
        }
        get
        {
            return attribute;
        }
    }
}
