using System;

class Student : Person
{
  private string major;
  private string id;
  public override string Id
  {
    set
    {
            if (value[0] != 'S')
                throw new ArgumentException(
                  "A student ID must start with an 'S'."
                );
            else id = value;
    }
        get { return id; }
    }
}
