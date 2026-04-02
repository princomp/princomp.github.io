public class Person
{
  private string name;
  protected string nickName;
  public string commonName;

  public string GetName()
  {
    return name;
  }

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

  private void NewName(string newNameP)
  {
    name = newNameP + $" (previous name: {name})";
  }
  
  public Person() { }
}
