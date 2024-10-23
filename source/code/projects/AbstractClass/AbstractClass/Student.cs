using System;

class Student:Person
{
    private string major;
    public override string Id
    {
        set
        {
            if (value[0] != 'S')
                throw new ArgumentException("A student ID must start with an 'S'.");
        }
    }
}
