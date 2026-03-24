public class Person
{
  private string name;

  public string GetName()
  {
    return name;
  }

  public Person() { }

  public void SetName(string nameP)
  {
    if (name == null)
    {
      name = nameP;
    }
    else
    {
      NewName(nameP);
    }
  }

  private void NewName(string newnameP)
  {
    name = newnameP + $" (previous name: {name})";
  }
}
